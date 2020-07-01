namespace Maple2.Trigger._65000002_bd {
    public static class _bush_11 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1001011, arg2: 70000075);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 1001011) == 1) {
                    context.State = new State버프발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프발동 : TriggerState {
            internal State버프발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1001011}, arg2: 70000075, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State버프발동(context);
                    return;
                }

                if (context.GetUserCount(boxId: 1001011) > 1) {
                    context.State = new State대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {1001011})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}