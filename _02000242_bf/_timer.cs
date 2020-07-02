namespace Maple2.Trigger._02000242_bf {
    public static class _timer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {205})) {
                    return new State초재기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기1 : TriggerState {
            internal State초재기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State초재기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000242_BF__TIMER__0$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State유저이동음성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동음성 : TriggerState {
            internal State유저이동음성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}