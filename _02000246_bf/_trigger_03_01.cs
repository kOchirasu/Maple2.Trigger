namespace Maple2.Trigger._02000246_bf {
    public static class _trigger_03_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {621, 622, 623, 624, 625, 626, 627, 628, 629});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {203})) {
                    context.State = new State몹생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {621, 622, 623, 624, 625, 626, 627, 628, 629}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 120);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {621, 622, 623, 624, 625, 626, 627, 628, 629})) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}