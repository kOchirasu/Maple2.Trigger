namespace Maple2.Trigger._63000006_cs {
    public static class _shake03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State간격Random(context);
            }

            public override void OnExit() { }
        }

        private class State간격Random : TriggerState {
            internal State간격Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new State4초간격(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State5초간격(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State6초간격(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State7초간격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4초간격 : TriggerState {
            internal State4초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5초간격 : TriggerState {
            internal State5초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6초간격 : TriggerState {
            internal State6초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7초간격 : TriggerState {
            internal State7초간격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateReset(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}