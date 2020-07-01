namespace Maple2.Trigger._52000012_qd {
    public static class _main2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
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
                context.SetTimer(arg1: "19", arg2: 1);
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
                    return new State포털생성(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {10002611}, arg3: new byte[] {3})) {
                    return new State포털생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9001})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new State대기(context);
            }

            public override void OnExit() { }
        }
    }
}