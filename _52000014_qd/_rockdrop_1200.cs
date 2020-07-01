namespace Maple2.Trigger._52000014_qd {
    public static class _rockdrop_1200 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1200}, arg2: false);
                context.SetEffect(arg1: new[] {1201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State낙하01준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하01준비 : TriggerState {
            internal State낙하01준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State낙하01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하01시작 : TriggerState {
            internal State낙하01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State낙하01완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하01완료 : TriggerState {
            internal State낙하01완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.SetSkill(arg1: new[] {1200}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State초기화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetSkill(arg1: new[] {1200}, arg2: false);
                context.SetEffect(arg1: new[] {1201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State낙하01준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}