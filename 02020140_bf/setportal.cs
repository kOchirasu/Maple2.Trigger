namespace Maple2.Trigger._02020140_bf {
    public static class _setportal {
        public class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateWait99(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait99 : TriggerState {
            internal StateWait99(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 118, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 128, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 138, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 218, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 228, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 238, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 318, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 328, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 338, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 428, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StatePortalCreation(context);
                }

                if (context.GetUserValue(key: "SetLight") == 1) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 118, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 128, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 138, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 218, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 228, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 238, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 318, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 328, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 338, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 428, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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