namespace Maple2.Trigger._65010007_bd {
    public static class _bush_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1001001, arg2: 70000075);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 1001001) == 1) {
                    return new State버프발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버프발동 : TriggerState {
            internal State버프발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1001001}, arg2: 70000075, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State버프발동(context);
                }

                if (context.GetUserCount(boxId: 1001001) > 1) {
                    return new State대기(context);
                }

                if (!context.UserDetected(arg1: new[] {1001001})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}