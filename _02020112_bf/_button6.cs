using System;

namespace Maple2.Trigger._02020112_bf {
    public static class _button6 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "931")) {
                    context.State = new State작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9906, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
            }

            public override void Execute() {
                if (context.UserValue(key: "ButtonSuccess", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "922")) {
                    context.State = new State감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9906, arg2: true, arg3: "Interaction_Lapentafoothold_A01_On");
            }

            public override void Execute() {
                if (context.UserValue(key: "ButtonSuccess", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: "922")) {
                    context.State = new State작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9906, arg2: false, arg3: "Interaction_Lapentafoothold_A01_On");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}