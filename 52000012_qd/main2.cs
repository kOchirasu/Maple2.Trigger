namespace Maple2.Trigger._52000012_qd {
    public static class _main2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 10002, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {10011, 10012}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002610}, arg3: new byte[] {2})) {
                    return new State문열림1(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002610}, arg3: new byte[] {3})) {
                    return new State문열림1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {2000}, arg2: false);
                context.DestroyMonster(arg1: new[] {5000, 101, 102, 103});
            }
        }

        private class State문열림1 : TriggerState {
            internal State문열림1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "19", arg2: 1);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {10011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    return new State문열림2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림2 : TriggerState {
            internal State문열림2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 10002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {10012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {10002611}, arg3: new byte[] {2})) {
                    return new StatePortalCreation(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {10002611}, arg3: new byte[] {3})) {
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

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9001})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}