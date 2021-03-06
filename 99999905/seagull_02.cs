namespace Maple2.Trigger._99999905 {
    public static class _seagull_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10502})) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");
                    // return new StateEnd(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}