namespace Maple2.Trigger._02100000_bf {
    public static class _debuff {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBuff_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_2 : TriggerState {
            internal StateBuff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBuff_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_3 : TriggerState {
            internal StateBuff_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBuff_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_4 : TriggerState {
            internal StateBuff_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBuff_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_5 : TriggerState {
            internal StateBuff_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000131, arg3: 1, arg4: false, arg5: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}