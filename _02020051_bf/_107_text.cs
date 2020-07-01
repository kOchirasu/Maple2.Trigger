namespace Maple2.Trigger._02020051_bf {
    public static class _107_text {
        public class State가이드시작 : TriggerState {
            internal State가이드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Text") == 1) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State가이드_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드_1 : TriggerState {
            internal State가이드_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_surprise", script: "$02020051_BF__107_TEXT__0$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Text") == 2) {
                    return new State가이드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}