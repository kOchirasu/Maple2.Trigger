using System;

namespace Maple2.Trigger._02020112_bf {
    public static class _respawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LimitSpawnNpcCount(limitCount: 200);
                context.SetUserValue(key: "respawn", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "respawn", value: 1)) {
                    context.State = new State스폰시작(context);
                    return;
                }

                if (context.UserValue(key: "respawn", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰시작 : TriggerState {
            internal State스폰시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__RESPAWN__0$", arg3: new int[] {5000});
                context.CreateMonster(arg1: new int[] {141, 142, 143, 144}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "respawn", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
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