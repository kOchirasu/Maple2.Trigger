using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _q10003067 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {103}, arg2: new int[] {50001642},
                    arg3: new byte[] {2})) {
                    context.State = new State포털활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털활성화 : TriggerState {
            internal State포털활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "woodsoflife", value: 1)) {
                    // context.State = new State포털비활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드활성화 : TriggerState {
            internal State가이드활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10003067);
            }

            public override void Execute() {
                if (context.WaitTick(arg1: 10000)) {
                    context.State = new State종료(context);
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