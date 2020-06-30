using System;

namespace Maple2.Trigger._02020027_bf {
    public static class _stun_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "1001")) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "summon_3_2", value: 1)) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State버프_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_2 : TriggerState {
            internal State버프_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02020027_BF__stun_1__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02020027_BF__stun_1__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State버프_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_4 : TriggerState {
            internal State버프_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02020027_BF__stun_1__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 304, arg3: "$02020027_BF__stun_1__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State버프_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_5 : TriggerState {
            internal State버프_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02020027_BF__stun_1__4$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 306, arg3: "$02020027_BF__stun_1__5$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State버프_제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_제거 : TriggerState {
            internal State버프_제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {201}, arg2: 62000002, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (true) { }
            }

            public override void OnExit() { }
        }
    }
}