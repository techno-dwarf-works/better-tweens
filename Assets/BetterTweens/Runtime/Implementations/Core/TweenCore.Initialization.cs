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

            InitializeMachines();
            _activityMachine.Run();
            _handlingMachine.Run();

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

        private void InitializeMachines()
        {
            _activityMachine = new();
            var activityCacheModule = _activityMachine.AddModule<ActivityState, CacheModule<ActivityState>>();
            var activityOverflowModule = _activityMachine.AddModule<ActivityState, StackOverflowModule<ActivityState>>();

            _activityMachine.StateChanged += OnActivityStateChanged;
            activityCacheModule.StateCached += OnActivityStateCached;
            activityOverflowModule.Locked += OnMachineOverflowed;
            
            _handlingMachine = new();
            _handlingMachine.AddModule<HandlingState, SnapshotModule<HandlingState>>();
            var handlingCacheModule = _handlingMachine.AddModule<HandlingState, CacheModule<HandlingState>>();
            var handlingOverflowModule = _handlingMachine.AddModule<HandlingState, StackOverflowModule<HandlingState>>();
            
            _handlingMachine.StateChanged += OnHandlingStateChanged;
            handlingCacheModule.StateCached += OnHandlingStateCached;
            handlingOverflowModule.Locked += OnMachineOverflowed;
        }

        protected abstract void OnInitialized();
    }
}