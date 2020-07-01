namespace Maple2.Trigger._63000006_cs {
    public static class _shake03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State간격랜덤(context);
            }

            public override void OnExit() { }
        }

        private class State간격랜덤 : TriggerState {
            internal State간격랜덤(ITriggerContext context) : base(context) { }

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
                    return new State초기화(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State종료(context);
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
                    return new State초기화(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State종료(context);
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
                    return new State초기화(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State종료(context);
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
                    return new State초기화(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5070}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State시작(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

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