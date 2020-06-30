namespace Maple2.Trigger {
    public abstract class TriggerState {
        protected readonly ITriggerContext context;

        protected TriggerState(ITriggerContext context) {
            this.context = context;
        }

        public abstract void OnEnter();
        public abstract void Execute();
        public abstract void OnExit();
    }
}