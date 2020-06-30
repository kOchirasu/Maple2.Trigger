using System;

namespace Maple2.Trigger._61000010_me {
    public static class _ladder01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 701, arg2: false, arg3: false);
                context.SetLadder(arg1: 702, arg2: false, arg3: false);
                context.SetLadder(arg1: 711, arg2: false, arg3: false);
                context.SetLadder(arg1: 712, arg2: false, arg3: false);
                context.SetLadder(arg1: 721, arg2: false, arg3: false);
                context.SetLadder(arg1: 722, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤 : TriggerState {
            internal State랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 34f)) {
                    context.SetLadder(arg1: 701, arg2: true, arg3: true);
                    context.SetLadder(arg1: 702, arg2: true, arg3: true);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.SetLadder(arg1: 711, arg2: true, arg3: true);
                    context.SetLadder(arg1: 712, arg2: true, arg3: true);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.SetLadder(arg1: 721, arg2: true, arg3: true);
                    context.SetLadder(arg1: 722, arg2: true, arg3: true);
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