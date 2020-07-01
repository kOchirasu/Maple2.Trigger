namespace Maple2.Trigger._52000116_qd {
    public static class _idle {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statenelftalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenelftalk : TriggerState {
            internal Statenelftalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000116_QD__IdLE__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statenelfmove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenelfmove : TriggerState {
            internal Statenelfmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}