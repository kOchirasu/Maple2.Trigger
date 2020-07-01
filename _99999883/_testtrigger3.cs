using System;

namespace Maple2.Trigger._99999883 {
    public static class _testtrigger3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001010}, arg2: 0);
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9900})) {
                    context.State = new StateEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001010}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001010}, arg2: 0)) {
                    context.State = new StateTakeOffFlyingCloud01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud01 : TriggerState {
            internal StateTakeOffFlyingCloud01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetInteractObject(arg1: new int[] {10001010}, arg2: 2);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: true);
                context.SetBreakable(arg1: new int[] {4000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTakeOffFlyingCloud02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud02 : TriggerState {
            internal StateTakeOffFlyingCloud02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999883, arg2: 100, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTakeOffFlyingCloud03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud03 : TriggerState {
            internal StateTakeOffFlyingCloud03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateTakeOffFlyingCloud04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud04 : TriggerState {
            internal StateTakeOffFlyingCloud04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 99999883, arg2: 101, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}