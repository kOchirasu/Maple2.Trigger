namespace Maple2.Trigger._02000246_bf {
    public static class _trigger_04_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {631, 632, 633, 634, 635, 636, 637, 638, 639});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {204})) {
                    return new State몹생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {631, 632, 633, 634, 635, 636, 637, 638, 639}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {631, 632, 633, 634, 635, 636, 637, 638, 639})) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}