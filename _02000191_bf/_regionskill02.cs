using System;

namespace Maple2.Trigger._02000191_bf {
    public static class _regionskill02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 202, arg2: new int[] {900})) {
                    context.State = new State스킬작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬작동 : TriggerState {
            internal State스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {301}, arg2: true);
                context.SetSkill(arg1: new int[] {303}, arg2: true);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 202, arg2: new int[] {900})) {
                    context.State = new State트리거초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {301}, arg2: false);
                context.SetSkill(arg1: new int[] {303}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}