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
            SettingsData = TweensSettings.Instance.Current;
            CompletedLoops = 0;
            
            InitializeStates();

            var state = _handlingStates.GetOrAdd<StoppedState>();
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
            _activityStates = new();
            _handlingStates = new();
            _activityMachine = new();
            _handlingMachine = new();

            _activityMachine.AddModule(_activityStates);
            _handlingMachine.AddModule(_handlingStates);

            _activityMachine.StateChanged += OnActivityStateChanged;
            _handlingMachine.StateChanged += OnHandlingStateChanged;
            _activityStates.Cached += OnActivityStateCached;
            _handlingStates.Cached += OnHandlingStateCached;

            _activityMachine.Run();
            _handlingMachine.Run();
        }

        protected abstract void OnInitialized();
    }
}