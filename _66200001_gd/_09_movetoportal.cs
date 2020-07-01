using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _09_movetoportal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MoveToTeamPortal", value: 0);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "MoveToTeamPortal", value: 1)) {
                    context.State = new StateMoveUserbyTag(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveUserbyTag : TriggerState {
            internal StateMoveUserbyTag(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9900, userTagId: 1, portalId: 11);
                context.MoveToPortal(boxId: 9900, userTagId: 2, portalId: 12);
                context.SetUserValue(triggerID: 11, key: "BannerCheckIn", value: 1);
                context.SetUserValue(triggerID: 13, key: "BannerCheckIn", value: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9900})) {
                    context.State = new StateMoveUserbyTag(context);
                    return;
                }

                if (context.UserValue(key: "MoveToTeamPortal", value: 2)) {
                    context.State = new StateQuitDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuitDelay : TriggerState {
            internal StateQuitDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6, arg2: false, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}