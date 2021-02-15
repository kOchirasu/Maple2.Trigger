namespace Maple2.Trigger._99999896 {
    public static class _01_intro {
        public class State스타트 : TriggerState {
            internal State스타트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateMassiveEventWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class StateMassiveEventWait : TriggerState {
            internal StateMassiveEventWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMassiveEvent_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class StateMassiveEvent_1 : TriggerState {
            internal StateMassiveEvent_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetEventUI(arg1: 1, arg2: "$99999896__01_INTRO__0$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMassiveEvent_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class StateMassiveEvent_2 : TriggerState {
            internal StateMassiveEvent_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$99999896__01_INTRO__1$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMassiveEvent_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class StateMassiveEvent_3 : TriggerState {
            internal StateMassiveEvent_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$99999896__01_INTRO__2$", arg3: 2000);
                context.CreateItem(arg1: new[] {1, 2, 3});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}