namespace Maple2.Trigger._02000242_bf {
    public static class _trigger_03_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {705, 706}, arg2: false);
                context.DestroyMonster(arg1: new[] {622, 623, 624, 625, 626, 627, 628, 629, 630});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {203})) {
                    return new State몹생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {622, 623, 624, 625, 626, 627, 628, 629, 630}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {622, 623, 624, 625, 626, 627, 628, 629, 630})) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}