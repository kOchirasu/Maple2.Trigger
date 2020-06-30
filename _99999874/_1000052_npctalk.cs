using System;

namespace Maple2.Trigger._99999874 {
    public static class _1000052_npctalk {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NPCTalk", value: 1)) {
                    context.State = new StateNPCTalkOnWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCTalkOnWait : TriggerState {
            internal StateNPCTalkOnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateNPCTalkOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCTalkOn : TriggerState {
            internal StateNPCTalkOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 15501, msg: "(뭐지... 왜 빤히 보는거지...엎드리지만 않았으면...)", duration: 3000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkDelay : TriggerState {
            internal StateTalkDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    context.State = new StateNPCTalkOn(context);
                    return;
                }

                if (context.UserValue(key: "NPCTalk", value: 0)) {
                    // context.State = new StateNPCTalkOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOff : TriggerState {
            internal StatePortalOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointID: 15501);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}