namespace Maple2.Trigger._02000331_bf {
    public static class _switch09 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7773}, arg2: false);
                context.SetBreakable(arg1: new[] {5001, 5002, 5011, 5012, 5021, 5022, 5031, 5032}, arg2: false);
                context.SetMesh(arg1: new[] {40000, 40001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000795}, arg2: 0)) {
                    return new StateSetup내리기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup내리기 : TriggerState {
            internal StateSetup내리기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {5001, 5002, 5011, 5012, 5021, 5022, 5031, 5032}, arg2: true);
                context.SetEffect(arg1: new[] {7773}, arg2: true);
                context.SetMesh(arg1: new[] {40000, 40001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {5001, 5002, 5011, 5012, 5021, 5022, 5031, 5032}, arg2: false);
                context.SetEffect(arg1: new[] {7773}, arg2: false);
                context.SetMesh(arg1: new[] {40000, 40001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}