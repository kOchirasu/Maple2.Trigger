namespace Maple2.Trigger._02000251_bf {
    public static class _timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3001, 3002, 3003}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {202})) {
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

                if (context.GetUserCount(boxId: 202) == 4) {
                    context.State = new State초재기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000251_BF__TIMER__0$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {3001}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000251_BF__TIMER__1$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {3002}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State초재기3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초재기3 : TriggerState {
            internal State초재기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000251_BF__TIMER__2$", arg3: 5000, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
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

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}