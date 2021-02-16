namespace Maple2.Trigger._52000116_qd {
    public static class _idle {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNelftalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNelftalk : TriggerState {
            internal StateNelftalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000116_QD__IdLE__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNelfmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNelfmove : TriggerState {
            internal StateNelfmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}