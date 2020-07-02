namespace Maple2.Trigger._51000003_dg {
    public static class _buff {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Tutorial") == 1) {
                    return new StateTutorial_buff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTutorial_buff : TriggerState {
            internal StateTutorial_buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Tutorial") == 0) {
                    return new StateIdle(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000085, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Tutorial") == 0) {
                    return new StateIdle(context);
                }

                return new StateTutorial_buff(context);
            }

            public override void OnExit() { }
        }
    }
}