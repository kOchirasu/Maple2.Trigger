using System;

namespace Maple2.Trigger._99999896 {
    public static class _02_coin {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State동전생성01(context);

        private class State동전생성01 : TriggerState {
            internal State동전생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.SetTimer(arg1: "1", arg2: 2);
                    context.CreateItem(arg1: new int[] {4, 5, 6, 7, 8, 9, 10, 11, 12});
                    context.SetEventUI(arg1: 1, arg2: "$99999896__02_COIN__0$", arg3: new int[] {2000});
                    context.State = new State동전생성02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동전생성02 : TriggerState {
            internal State동전생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
                    context.CreateItem(arg1: new int[] {13, 14, 15, 16, 17, 18, 19, 20, 21});
                    context.SetEventUI(arg1: 1, arg2: "$99999896__02_COIN__1$", arg3: new int[] {2000});
                    context.State = new State동전생성03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동전생성03 : TriggerState {
            internal State동전생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
                    context.SetEventUI(arg1: 1, arg2: "$99999896__02_COIN__2$", arg3: new int[] {2000});
                    context.CreateItem(arg1: new int[] {22, 23, 24, 25, 26, 27, 28, 29, 30});
                    context.SetEventUI(arg1: 3, arg2: "$99999896__02_COIN__3$", arg3: new int[] {2000});
                    context.CreateItem(arg1: new int[]
                        {31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48});
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}