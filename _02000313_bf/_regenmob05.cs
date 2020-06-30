using System;

namespace Maple2.Trigger._02000313_bf {
    public static class _regenmob05 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 13, arg2: new int[] {91})) {
                    context.State = new State소환몹등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환몹등장 : TriggerState {
            internal State소환몹등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103, 104});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103, 104})) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }
    }
}