using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
using Better.StateMachine.Runtime.Modules.Snapshot;
using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        private void Initialize()
        {
            if (!ValidateInitialized(false))
            {
                return;
            }

            if (!IsInitializable())
            {
                var message = "Must be initializable";
                LogUtility.LogException(message);

                return;
            }

            Initialized = true;
            CompletedLoops = 0;

            InitializeStates();

            var state = GetHandlingState<StoppedState>();
            state.SuppressNextNotify();
            _handlingMachine.ChangeState(state);

            OnInitialized();
        }

        private void TryInitialize()
        {
            if (!Initialized && IsInitializable())
            {
                Initialize();
            }
        }

        private void InitializeStates()
        {
            _activityMachine = new();
            _handlingMachine = new();

            _handlingMachine.AddModule<HandlingState, SnapshotModule<HandlingState>>();
            var activityCacheModule = _activityMachine.AddModule<ActivityState, CacheModule<ActivityState>>();
            var handlingCacheModule = _handlingMachine.AddModule<HandlingState, CacheModule<HandlingState>>();

            _activityMachine.Run();
            _handlingMachine.Run();

            _activityMachine.StateChanged += OnActivityStateChanged;
            _handlingMachine.StateChanged += OnHandlingStateChanged;
            activityCacheModule.StateCached += OnActivityStateCached;
            handlingCacheModule.StateCached += OnHandlingStateCached;
        }

        protected abstract void OnInitialized();
    }
}