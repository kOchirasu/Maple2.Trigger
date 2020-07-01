namespace Maple2.Trigger._02000543_bf {
    public static class _mob_1_1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "WaveStart") == 1) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
            }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.GetUserValue(key: "WaveEnd") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}