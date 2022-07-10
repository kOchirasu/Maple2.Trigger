namespace Maple2.Trigger._66200001_gd {
    public static class _10_banner_thenumberofwaiting {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BannerCheckIn") == 1) {
                    return new StateBannerCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBannerCheckIn : TriggerState {
            internal StateBannerCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromUserCount(boxId: 9021, key: "BannerNumberOfBlue", userTagId: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshId: 1500, digitCount: 2);
                context.SetUserValueFromUserCount(boxId: 9022, key: "BannerNumberOfRed", userTagId: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshId: 2500, digitCount: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNextWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextWait : TriggerState {
            internal StateNextWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BannerCheckIn") == 1) {
                    return new StateBannerCheckIn(context);
                }

                if (context.GetUserValue(key: "BannerCheckIn") == 0) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromUserCount(boxId: 9021, key: "BannerNumberOfBlue", userTagId: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshId: 1500, digitCount: 2);
                context.SetUserValueFromUserCount(boxId: 9022, key: "BannerNumberOfRed", userTagId: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshId: 2500, digitCount: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
