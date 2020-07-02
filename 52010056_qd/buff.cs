namespace Maple2.Trigger._52010056_qd {
    public static class _buff {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateReady(context);
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000054}, arg3: new byte[] {3})) {
                    return new StateBuff_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000054}, arg3: new byte[] {2})) {
                    return new StateBuff_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000054}, arg3: new byte[] {1})) {
                    return new StateBuff_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000053}, arg3: new byte[] {3})) {
                    return new StateBuff_A(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000053}, arg3: new byte[] {2})) {
                    return new StateBuff_A(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000053}, arg3: new byte[] {1})) {
                    return new StateBuff_A(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000052}, arg3: new byte[] {3})) {
                    return new StateBuff_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_A : TriggerState {
            internal StateBuff_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 99910300, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910300, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_B : TriggerState {
            internal StateBuff_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 99910330, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910330, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}