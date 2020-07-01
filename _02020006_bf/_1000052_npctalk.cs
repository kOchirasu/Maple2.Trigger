namespace Maple2.Trigger._02020006_bf {
    public static class _1000052_npctalk {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "NPCTalk") == 1) {
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
                context.AddBalloonTalk(spawnPointId: 15501, msg: "$02020006_BF__1000052_NPCTALK__0$", duration: 3000, delayTick: 0);
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

                if (context.GetUserValue(key: "NPCTalk") == 0) {
                    // context.State = new StateNPCTalkOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOff : TriggerState {
            internal StatePortalOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 15501);
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