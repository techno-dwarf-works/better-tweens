using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
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
                LogUtility.LogException(message, this);

                return;
            }

            Initialized = true;
            InitializeOverridableSources();
            InitializeMachines();

            _activityMachine.Run();
            _handlingMachine.Run();

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
            var handlingCacheModule = _handlingMachine.AddModule<HandlingState, CacheModule<HandlingState>>();
            var handlingOverflowModule = _handlingMachine.AddModule<HandlingState, StackOverflowModule<HandlingState>>();

            _handlingMachine.StateChanged += OnHandlingStateChanged;
            handlingCacheModule.StateCached += OnHandlingStateCached;
            handlingOverflowModule.Locked += OnMachineOverflowed;
        }

        protected virtual void InitializeOverridableSources()
        {
            _dependUnityTimeScale.SetSource(SettingsData.DependUnityTimeScale);
            _dependGlobalTimeScale.SetSource(SettingsData.DependGlobalTimeScale);
            _sleepingDuration.SetSource(SettingsData.SleepingDuration);
            _completionAction.SetSource(SettingsData.CompletionAction);
            _rewoundAction.SetSource(SettingsData.RewoundAction);
        }

        protected virtual void OnInitialized()
        {
            var stoppedState = GetHandlingState<StoppedState>();
            stoppedState.SuppressNextNotify();
            _handlingMachine.ChangeState(stoppedState);
        }
    }
}