namespace Maple2.Trigger._02000304_bf {
    public static class _minion_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {111})) {
                    context.CreateMonster(arg1: new[] {1001, 1002}, arg2: false);
                    return new State종료체크(context);
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State종료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1001, 1002})) {
                    return new State대기시간(context);
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.DestroyMonster(arg1: new[] {1001, 1002});
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000304, arg2: 10, arg3: 111);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}