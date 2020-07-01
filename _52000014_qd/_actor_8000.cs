namespace Maple2.Trigger._52000014_qd {
    public static class _actor_8000 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8100}, arg2: false);
                context.DestroyMonster(arg1: new[] {800, 801});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State약화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State약화01 : TriggerState {
            internal State약화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {800}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new State교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교체01 : TriggerState {
            internal State교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.DestroyMonster(arg1: new[] {800});
                context.CreateMonster(arg1: new[] {801}, arg2: false);
                context.MoveNpc(arg1: 801, arg2: "MS2PatrolData_801");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State일어남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일어남01 : TriggerState {
            internal State일어남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State포효01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포효01 : TriggerState {
            internal State포효01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 5);
                context.SetEffect(arg1: new[] {8100}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료01 : TriggerState {
            internal State종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8100}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}