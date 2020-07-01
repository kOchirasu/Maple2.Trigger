namespace Maple2.Trigger._99999874 {
    public static class _1000051_npctalk {
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
                context.AddBalloonTalk(spawnPointId: 15401, msg: "쳇!! 요즘 애들은 너무 인사성이 없어!!", duration: 3000, delayTick: 0);
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
                context.RemoveBalloonTalk(spawnPointId: 15401);
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