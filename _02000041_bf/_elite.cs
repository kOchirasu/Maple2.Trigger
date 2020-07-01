namespace Maple2.Trigger._02000041_bf {
    public static class _elite {
        public class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1001, 1002})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}