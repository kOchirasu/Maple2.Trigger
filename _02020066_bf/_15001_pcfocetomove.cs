using System;

namespace Maple2.Trigger._02020066_bf {
    public static class _15001_pcfocetomove {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PortalOn", value: 0);
                context.SetPortal(arg1: 15700, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "PortalOn", value: 1)) {
                    context.State = new StatePortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 15700, arg2: false, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "PortalOn", value: 2)) {
                    context.State = new StatePortalOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOff : TriggerState {
            internal StatePortalOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 15700, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "PortalOn", value: 0)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}