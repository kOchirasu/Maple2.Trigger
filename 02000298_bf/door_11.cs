namespace Maple2.Trigger._02000298_bf {
    public static class _door_11 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 211, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3111, 3112}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{9111, 9112, 9113}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{111})) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 211, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3111}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3112}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetAgent(triggerIds: new []{9111, 9112, 9113}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
