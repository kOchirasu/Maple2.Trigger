namespace Maple2.Trigger._52000082_qd {
    public static class _main {
        public class StateMapskill : TriggerState {
            internal StateMapskill(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateMapskill_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMapskill_start : TriggerState {
            internal StateMapskill_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 70000114, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMapskill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
