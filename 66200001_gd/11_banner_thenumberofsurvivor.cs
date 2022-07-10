namespace Maple2.Trigger._66200001_gd {
    public static class _11_banner_thenumberofsurvivor {
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
                context.SetUserValueFromUserCount(boxId: 9001, key: "BannerNumberOfBlue", userTagId: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshId: 700, digitCount: 2);
                context.SetUserValueFromUserCount(boxId: 9001, key: "BannerNumberOfRed", userTagId: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshId: 1700, digitCount: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNextWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "BannerCheckIn", value: 0);
            }
        }

        private class StateNextWait : TriggerState {
            internal StateNextWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BannerCheckIn") == 1) {
                    return new StateBannerCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
