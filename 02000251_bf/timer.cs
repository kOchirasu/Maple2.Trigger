namespace Maple2.Trigger._02000251_bf {
    public static class _timer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{3001, 3002, 3003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{202})) {
                    return new State초재기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기1 : TriggerState {
            internal State초재기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State초재기2(context);
                }

                if (context.GetUserCount(boxId: 202) == 4) {
                    return new State초재기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기2 : TriggerState {
            internal State초재기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000251_BF__TIMER__0$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{3001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000251_BF__TIMER__1$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{3002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State초재기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초재기3 : TriggerState {
            internal State초재기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000251_BF__TIMER__2$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State유저이동음성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동음성 : TriggerState {
            internal State유저이동음성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
