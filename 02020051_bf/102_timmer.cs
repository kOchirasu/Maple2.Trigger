using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020051_bf {
    public static class _102_timmer {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "990");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Timmer") == 1) {
                    return new State타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "990", arg2: 600, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 600000)) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "Timmer") == 3) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_shy", script: "$02020051_BF__102_TIMMER__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.SetUserValue(triggerId: 104, key: "End", value: 3);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Timmer") == 2) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}