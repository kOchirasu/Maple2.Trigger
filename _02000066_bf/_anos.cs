using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _anos {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {103})) {
                    context.State = new StateNPC생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC생성 : TriggerState {
            internal StateNPC생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {98}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State말풍선랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선랜덤 : TriggerState {
            internal State말풍선랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__0$", arg4: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__1$", arg4: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사03 : TriggerState {
            internal StateNPC대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__2$", arg4: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사04 : TriggerState {
            internal StateNPC대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 98, arg3: "$02000066_BF__ANOS__3$", arg4: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}