using System;

namespace Maple2.Trigger._99999896 {
    public static class _01_intro {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State스타트(context);

        private class State스타트 : TriggerState {
            internal State스타트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {100})) {
                    context.State = new State멘트대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트대기 : TriggerState {
            internal State멘트대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트_1 : TriggerState {
            internal State멘트_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetEventUI(arg1: 1, arg2: "$99999896__01_INTRO__0$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트_2 : TriggerState {
            internal State멘트_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$99999896__01_INTRO__1$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트_3 : TriggerState {
            internal State멘트_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$99999896__01_INTRO__2$", arg3: new int[] {2000});
                context.CreateItem(arg1: new int[] {1, 2, 3});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}