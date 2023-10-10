namespace Maple2.Trigger._02000346_bf {
    public static class _heal01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000803}, state: 0);
                context.SetSkill(triggerIds: new []{701}, enabled: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
