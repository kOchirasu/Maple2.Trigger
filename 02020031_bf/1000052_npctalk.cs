namespace Maple2.Trigger._02020031_bf {
    public static class _1000052_npctalk {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NPCTalk") == 1) {
                    return new StateNPCTalkOnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCTalkOnWait : TriggerState {
            internal StateNPCTalkOnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateNPCTalkOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCTalkOn : TriggerState {
            internal StateNPCTalkOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 15501, msg: "$02020031_BF__1000052_NPCTALK__0$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkDelay : TriggerState {
            internal StateTalkDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new StateNPCTalkOn(context);
                }

                if (context.GetUserValue(key: "NPCTalk") == 0) {
                    // return new StateNPCTalkOff(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOff : TriggerState {
            internal StatePortalOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 15501);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
