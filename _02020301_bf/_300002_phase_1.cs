using System;

namespace Maple2.Trigger._02020301_bf {
    public static class _300002_phase_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "AI_Phase", value: 1)) {
                    context.State = new State텍스트_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State텍스트_대기 : TriggerState {
            internal State텍스트_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State패이즈_1_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패이즈_1_시작 : TriggerState {
            internal State패이즈_1_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "AI_Phase", value: 0);
                context.SideNpcTalk(type: "talk", npcID: 11004205, illust: "ArcaneBlader_unfair",
                    script: "$02020301_BF__300002_PHASE_1__0$", duration: 4176);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}