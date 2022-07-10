namespace Maple2.Trigger._02000253_bf {
    public static class _wall_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9003, 9004}, visible: true);
                context.SetMesh(triggerIds: new []{503, 504, 604, 605, 606}, visible: true);
                context.SetInteractObject(interactIds: new []{10000438}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000438}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9003, 9004}, visible: false);
                context.SetMesh(triggerIds: new []{503, 504, 604, 605, 606}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
