namespace Maple2.Trigger._02000253_bf {
    public static class _wall_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9001, 9002}, visible: true);
                context.SetMesh(triggerIds: new []{501, 502, 601, 602, 603}, visible: true);
                context.SetInteractObject(interactIds: new []{10000437}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000437}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9001, 9002}, visible: false);
                context.SetMesh(triggerIds: new []{501, 502, 601, 602, 603}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
