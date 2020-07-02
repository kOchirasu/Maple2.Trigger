namespace Maple2.Trigger._02000428_bf {
    public static class _startportalremove {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateStartingPortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartingPortalCreation : TriggerState {
            internal StateStartingPortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 40000)) {
                    return new StateStartingPortalRemoveSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartingPortalRemoveSetup : TriggerState {
            internal StateStartingPortalRemoveSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 770) == 1) {
                    return new StateStartingPortal_RemoveNotification(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStartingPortalRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartingPortal_RemoveNotification : TriggerState {
            internal StateStartingPortal_RemoveNotification(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000428_BF__BARRICADE__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStartingPortalRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartingPortalRemove : TriggerState {
            internal StateStartingPortalRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}