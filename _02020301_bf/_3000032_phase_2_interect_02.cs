using System;

namespace Maple2.Trigger._02020301_bf {
    public static class _3000032_phase_2_interect_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Phase_2_Interect_02", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {701}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {701})) {
                    context.State = new State재생성(context);
                    return;
                }

                if (context.UserValue(key: "Phase_2_Interect_02", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재생성 : TriggerState {
            internal State재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.UserValue(key: "Phase_2_Interect_02", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}