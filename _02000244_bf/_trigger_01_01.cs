using System;

namespace Maple2.Trigger._02000244_bf {
    public static class _trigger_01_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {701, 702}, arg2: true);
                context.SetMesh(arg1: new int[] {709, 710}, arg2: true);
                context.DestroyMonster(arg1: new int[] {631, 632, 633, 634, 635, 636, 637, 638, 639});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "201")) {
                    context.State = new State몹생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {631, 632, 633, 634, 635, 636, 637, 638, 639}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {631, 632, 633, 634, 635, 636, 637, 638, 639})) {
                    context.State = new State통과(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000303}, arg2: 0)) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {701, 702}, arg2: false);
                context.SetMesh(arg1: new int[] {709, 710}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}