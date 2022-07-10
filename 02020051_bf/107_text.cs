using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020051_bf {
    public static class _107_text {
        public class StateGuide시작 : TriggerState {
            internal StateGuide시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Text") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateGuide_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide_1 : TriggerState {
            internal StateGuide_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", script: "$02020051_BF__107_TEXT__0$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Text") == 2) {
                    return new StateGuide시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
