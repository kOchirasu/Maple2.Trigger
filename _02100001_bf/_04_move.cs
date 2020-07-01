namespace Maple2.Trigger._02100001_bf {
    public static class _04_move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001244}, arg2: 1);
                context.SetBreakable(arg1: new[] {4502}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001244}, arg2: 0)) {
                    return new StateMoveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveStart : TriggerState {
            internal StateMoveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateMoveStop(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveStop : TriggerState {
            internal StateMoveStop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4502}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4502}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001244}, arg2: 1);
                context.SetVisibleBreakableObject(arg1: new[] {4502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001244}, arg2: 0)) {
                    return new StateMoveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}