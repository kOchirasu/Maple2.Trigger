namespace Maple2.Trigger._02000334_bf {
    public static class _gameover {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {200, 999}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {200})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {999});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}