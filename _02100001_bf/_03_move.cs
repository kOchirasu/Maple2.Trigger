namespace Maple2.Trigger._02100001_bf {
    public static class _03_move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001242}, arg2: 1);
                context.SetBreakable(arg1: new[] {4501}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4501}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001242}, arg2: 0)) {
                    context.State = new StateMoveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveStart : TriggerState {
            internal StateMoveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4501}, arg2: true);
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
                context.SetBreakable(arg1: new[] {4501}, arg2: false);
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
                context.SetInteractObject(arg1: new[] {10001242}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001242}, arg2: 0)) {
                    context.State = new StateMoveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}