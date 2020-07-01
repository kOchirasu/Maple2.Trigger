using System;

namespace Maple2.Trigger._80000011_bonus {
    public static class _mainprocess_christmastree {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State이벤트대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이벤트대기중 : TriggerState {
            internal State이벤트대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 201, arg2: false, arg3: false);
                context.SetLadder(arg1: 202, arg2: false, arg3: false);
                context.SetLadder(arg1: 203, arg2: false, arg3: false);
                context.SetLadder(arg1: 204, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State사다리나타남(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리나타남 : TriggerState {
            internal State사다리나타남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 201, arg2: true, arg3: true);
                context.SetLadder(arg1: 202, arg2: true, arg3: true);
                context.SetLadder(arg1: 203, arg2: true, arg3: true);
                context.SetLadder(arg1: 204, arg2: true, arg3: true);
                context.SetTimer(arg1: "2", arg2: 30, arg3: true, arg4: true, arg5: -90);
                context.ShowGuideSummary(entityID: 26300385, textID: 26300385);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 26300385);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}