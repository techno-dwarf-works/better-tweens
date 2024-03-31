using Better.Tweens.Runtime.Logs;

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

            _statesCache = new();
            _statesCache.Cached += OnCachedState;
            
            _stateMachine = new();
            _stateMachine.AddModule(_statesCache);
            _stateMachine.Run();

            var state = _statesCache.GetOrAdd<StoppedState>();
            state.SuppressNextNotify();
            _stateMachine.ChangeState(state);

            Initialized = true;
            OnInitialized();
        }

        private void TryInitialize()
        {
            if (!Initialized && IsInitializable())
            {
                Initialize();
            }
        }

        protected abstract void OnInitialized();
    }
}