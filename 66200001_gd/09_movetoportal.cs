namespace Maple2.Trigger._66200001_gd {
    public static class _09_movetoportal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MoveToTeamPortal", value: 0);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MoveToTeamPortal") == 1) {
                    return new StateMoveUserbyTag(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveUserbyTag : TriggerState {
            internal StateMoveUserbyTag(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9900, userTagId: 1, portalId: 11);
                context.MoveToPortal(boxId: 9900, userTagId: 2, portalId: 12);
                context.SetUserValue(triggerId: 11, key: "BannerCheckIn", value: 1);
                context.SetUserValue(triggerId: 13, key: "BannerCheckIn", value: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new StateMoveUserbyTag(context);
                }

                if (context.GetUserValue(key: "MoveToTeamPortal") == 2) {
                    return new StateQuitDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuitDelay : TriggerState {
            internal StateQuitDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}