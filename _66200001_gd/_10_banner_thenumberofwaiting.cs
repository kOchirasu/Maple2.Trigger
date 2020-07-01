namespace Maple2.Trigger._66200001_gd {
    public static class _10_banner_thenumberofwaiting {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BannerCheckIn") == 1) {
                    context.State = new StateBannerCheckIn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBannerCheckIn : TriggerState {
            internal StateBannerCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromUserCount(triggerBoxId: 9021, key: "BannerNumberOfBlue", userTagId: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshId: 1500, digitCount: 2);
                context.SetUserValueFromUserCount(triggerBoxId: 9022, key: "BannerNumberOfRed", userTagId: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshId: 2500, digitCount: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNextWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNextWait : TriggerState {
            internal StateNextWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BannerCheckIn") == 1) {
                    context.State = new StateBannerCheckIn(context);
                    return;
                }

                if (context.GetUserValue(key: "BannerCheckIn") == 0) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromUserCount(triggerBoxId: 9021, key: "BannerNumberOfBlue", userTagId: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshId: 1500, digitCount: 2);
                context.SetUserValueFromUserCount(triggerBoxId: 9022, key: "BannerNumberOfRed", userTagId: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshId: 2500, digitCount: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}