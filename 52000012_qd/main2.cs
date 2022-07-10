namespace Maple2.Trigger._52000012_qd {
    public static class _main2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 10001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 10002, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{10011, 10012}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002610}, questStates: new byte[]{2})) {
                    return new State문열림1(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002610}, questStates: new byte[]{3})) {
                    return new State문열림1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
                context.DestroyMonster(spawnIds: new []{5000, 101, 102, 103});
            }
        }

        private class State문열림1 : TriggerState {
            internal State문열림1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "19", seconds: 1);
                context.SetActor(triggerId: 10001, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{10011}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "19")) {
                    return new State문열림2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림2 : TriggerState {
            internal State문열림2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 10002, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{10012}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{10002611}, questStates: new byte[]{2})) {
                    return new StatePortalCreation(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{10002611}, questStates: new byte[]{3})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}
