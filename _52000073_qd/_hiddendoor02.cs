using System;

namespace Maple2.Trigger._52000073_qd {
    public static class _hiddendoor02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {2000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001082}, arg2: 1);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001082}, arg2: 0)) {
                    context.State = new StateBookCaseMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBookCaseMove01 : TriggerState {
            internal StateBookCaseMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: true);
                context.SetMesh(arg1: new int[] {2000}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDoorOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen01 : TriggerState {
            internal StateDoorOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Opened");
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDoorOpen02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen02 : TriggerState {
            internal StateDoorOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 57000)) {
                    context.State = new StateDoorClose01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorClose01 : TriggerState {
            internal StateDoorClose01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Closed");
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDoorClose02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorClose02 : TriggerState {
            internal StateDoorClose02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.SetMesh(arg1: new int[] {2000}, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetInteractObject(arg1: new int[] {10001082}, arg2: 1);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001082}, arg2: 0)) {
                    context.State = new StateBookCaseMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}