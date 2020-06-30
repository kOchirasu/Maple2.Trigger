using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _10_banner_thenumberofwaiting {
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
                context.SetUserValueFromUserCount(triggerBoxID: 9021, key: "BannerNumberOfBlue", userTagID: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshID: 1500, digitCount: 2);
                context.SetUserValueFromUserCount(triggerBoxID: 9022, key: "BannerNumberOfRed", userTagID: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshID: 2500, digitCount: 2);
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
                if (context.UserValue(key: "BannerCheckIn", value: 1)) {
                    context.State = new StateBannerCheckIn(context);
                    return;
                }

                if (context.UserValue(key: "BannerCheckIn", value: 0)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromUserCount(triggerBoxID: 9021, key: "BannerNumberOfBlue", userTagID: 1);
                context.UserValueToNumberMesh(key: "BannerNumberOfBlue", startMeshID: 1500, digitCount: 2);
                context.SetUserValueFromUserCount(triggerBoxID: 9022, key: "BannerNumberOfRed", userTagID: 2);
                context.UserValueToNumberMesh(key: "BannerNumberOfRed", startMeshID: 2500, digitCount: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}