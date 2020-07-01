namespace Maple2.Trigger._02000498_bf {
    public static class _r11_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {111001})) {
                    context.State = new State몹스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹스폰 : TriggerState {
            internal State몹스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111004}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {111001})) {
                    context.DestroyMonster(arg1: new[] {111004});
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {111004})) {
                    context.State = new State몹스폰(context);
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