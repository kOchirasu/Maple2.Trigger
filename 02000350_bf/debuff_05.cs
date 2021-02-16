namespace Maple2.Trigger._02000350_bf {
    public static class _debuff_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

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
                context.SetTimer(id: "3600", arg2: 3600);
                context.AddBuff(arg1: new[] {106}, arg2: 70000071, arg3: 5, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3600")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}