namespace Maple2.Trigger._02000163_bf {
    public static class _06_doll_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{405}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000106}, arg2: 0)) {
                    return new State로봇사라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로봇사라짐 : TriggerState {
            internal State로봇사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{405}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000106}, arg2: 1)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
