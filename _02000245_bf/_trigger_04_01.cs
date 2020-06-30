using System;

namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_04_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {707, 708}, arg2: false);
                context.DestroyMonster(arg1: new int[] {616, 617, 618, 619, 620, 621, 622, 623, 624});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "204")) {
                    context.State = new State몹생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {616, 617, 618, 619, 620, 621, 622, 623, 624}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {616, 617, 618, 619, 620, 621, 622, 623, 624})) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {707, 708}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}