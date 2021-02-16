namespace Maple2.Trigger._80000008_bonus {
    public static class _exp_ball {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {402})) {
                    context.CreateItem(arg1: new[] {9001, 9002, 9003, 9004, 9005});
                    return new State5초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5초 : TriggerState {
            internal State5초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new[] {9001});
                    return new State10초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10초 : TriggerState {
            internal State10초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new[] {9001});
                    return new State15초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15초 : TriggerState {
            internal State15초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new[] {9001});
                    return new State20초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20초 : TriggerState {
            internal State20초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new[] {9001});
                    return new State25초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25초 : TriggerState {
            internal State25초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.CreateItem(arg1: new[] {9001});
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}