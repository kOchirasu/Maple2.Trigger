using System;

namespace Maple2.Trigger._02000246_bf {
    public static class _timer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {2001}, arg2: false);
                context.SetEffect(arg1: new int[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "205")) {
                    context.State = new State초재기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초재기1 : TriggerState {
            internal State초재기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State초재기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000246_BF__TIMER__0$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000141, arg2: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State유저이동음성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동음성 : TriggerState {
            internal State유저이동음성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}