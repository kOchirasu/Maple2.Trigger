namespace Maple2.Trigger._02000328_bf {
    public static class _buff {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999998})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{999998}, skillId: 70000111, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
