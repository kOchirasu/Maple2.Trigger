using System;

namespace Maple2.Trigger._99999878 {
    public static class _01_actertest {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1000, arg2: true, arg3: "Closed");
                context.SetBreakable(arg1: new int[] {2000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {2000}, arg2: true);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateOpenDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOpenDelay : TriggerState {
            internal StateOpenDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOpen : TriggerState {
            internal StateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1000, arg2: true, arg3: "Opened");
                context.SetBreakable(arg1: new int[] {2000}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {2000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateOffDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOffDelay : TriggerState {
            internal StateOffDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOff : TriggerState {
            internal StateOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1000, arg2: false, arg3: "Opened");
                context.SetBreakable(arg1: new int[] {2000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}