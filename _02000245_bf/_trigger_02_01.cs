namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_02_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {703, 704}, arg2: false);
                context.DestroyMonster(arg1: new[] {604, 605, 606, 607, 608, 609, 610, 611, 612});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {202})) {
                    return new State몹생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {604, 605, 606, 607, 608, 609, 610, 611, 612}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {604, 605, 606, 607, 608, 609, 610, 611, 612})) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {703, 704}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}