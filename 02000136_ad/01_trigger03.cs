namespace Maple2.Trigger._02000136_ad {
    public static class _01_trigger03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{804}, visible: false);
                context.SetInteractObject(interactIds: new []{10000068}, state: 1);
                context.SetMesh(triggerIds: new []{15}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000068}, arg2: 0)) {
                    return new StateSetupSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn : TriggerState {
            internal StateSetupSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{15}, visible: true);
                context.SetEffect(triggerIds: new []{804}, visible: true);
                context.SetTimer(timerId: "2", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
