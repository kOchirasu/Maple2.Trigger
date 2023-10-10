namespace Maple2.Trigger._63000006_cs {
    public static class _shake03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5070}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5070}, visible: true);
            }

            public override TriggerState? Execute() {
                return new State간격Random(context);
            }

            public override void OnExit() { }
        }

        private class State간격Random : TriggerState {
            internal State간격Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new State4초간격(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State5초간격(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State6초간격(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State7초간격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4초간격 : TriggerState {
            internal State4초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5초간격 : TriggerState {
            internal State5초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6초간격 : TriggerState {
            internal State6초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7초간격 : TriggerState {
            internal State7초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5070}, visible: false);
            }

            public override TriggerState? Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5070}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
