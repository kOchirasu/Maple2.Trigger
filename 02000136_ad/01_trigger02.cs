namespace Maple2.Trigger._02000136_ad {
    public static class _01_trigger02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{801, 802, 803}, visible: false);
                context.SetInteractObject(interactIds: new []{10000067}, state: 1);
                context.SetMesh(triggerIds: new []{14, 17, 16}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000067}, arg2: 0)) {
                    return new StateSetupSpawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn1 : TriggerState {
            internal StateSetupSpawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{14}, visible: true);
                context.SetEffect(triggerIds: new []{801}, visible: true);
                context.SetTimer(timerId: "2", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateSetupSpawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn2 : TriggerState {
            internal StateSetupSpawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{17}, visible: true);
                context.SetEffect(triggerIds: new []{802}, visible: true);
                context.SetTimer(timerId: "3", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateSetupSpawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn3 : TriggerState {
            internal StateSetupSpawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{16}, visible: true);
                context.SetEffect(triggerIds: new []{803}, visible: true);
                context.SetTimer(timerId: "4", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
