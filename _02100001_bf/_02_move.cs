using System;

namespace Maple2.Trigger._02100001_bf {
    public static class _02_move {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001241}, arg2: 1);
                context.SetBreakable(arg1: new int[] {4500}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4500}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001241}, arg2: 0)) {
                    context.State = new StateMoveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveStart : TriggerState {
            internal StateMoveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4500}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateMoveStop(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveStop : TriggerState {
            internal StateMoveStop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4500}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001241}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001241}, arg2: 0)) {
                    context.State = new StateMoveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}