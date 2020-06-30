using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _11_banner_thenumberofsurvivor {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BannerCheckIn", value: 1)) {
                    context.State = new StateBannerCheckIn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBannerCheckIn : TriggerState {
            internal StateBannerCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromUserCount(triggerBoxID: 9001, key: "BannerNumberOfBlue", userTagID: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshID: 700, digitCount: 2);
                context.SetUserValueFromUserCount(triggerBoxID: 9001, key: "BannerNumberOfRed", userTagID: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshID: 1700, digitCount: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNextWait(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(key: "BannerCheckIn", value: 0);
            }
        }

        private class StateNextWait : TriggerState {
            internal StateNextWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BannerCheckIn", value: 1)) {
                    context.State = new StateBannerCheckIn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}