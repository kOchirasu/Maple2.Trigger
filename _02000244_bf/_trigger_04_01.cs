namespace Maple2.Trigger._02000244_bf {
    public static class _trigger_04_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {707, 708}, arg2: true);
                context.DestroyMonster(arg1: new[] {613, 614, 615, 616, 617, 618, 619, 620, 621});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {204})) {
                    context.State = new State몹생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {613, 614, 615, 616, 617, 618, 619, 620, 621}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {613, 614, 615, 616, 617, 618, 619, 620, 621})) {
                    context.State = new State통과(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000301}, arg2: 0)) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {707, 708}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}