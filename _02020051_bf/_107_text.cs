using System;

namespace Maple2.Trigger._02020051_bf {
    public static class _107_text {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State가이드시작(context);

        private class State가이드시작 : TriggerState {
            internal State가이드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Text", value: 1)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State가이드_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드_1 : TriggerState {
            internal State가이드_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise",
                    script: "$02020051_BF__107_TEXT__0$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Text", value: 2)) {
                    context.State = new State가이드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}