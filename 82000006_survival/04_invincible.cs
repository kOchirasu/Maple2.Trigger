namespace Maple2.Trigger._82000006_survival {
    public static class _04_invincible {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateMakeInvincible(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMakeInvincible : TriggerState {
            internal StateMakeInvincible(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9000}, skillId: 71000049, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMakeInvincible(context);
                }

                if (context.GetUserValue(key: "InvincibleOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
