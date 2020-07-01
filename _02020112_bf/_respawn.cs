namespace Maple2.Trigger._02020112_bf {
    public static class _respawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LimitSpawnNpcCount(limitCount: 200);
                context.SetUserValue(key: "respawn", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 1) {
                    return new State스폰시작(context);
                }

                if (context.GetUserValue(key: "respawn") == 2) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰시작 : TriggerState {
            internal State스폰시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__RESPAWN__0$", arg3: 5000);
                context.CreateMonster(arg1: new[] {141, 142, 143, 144}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new State종료(context);
                }

                return new State대기(context);
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