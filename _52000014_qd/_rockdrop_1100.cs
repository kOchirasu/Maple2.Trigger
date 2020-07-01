namespace Maple2.Trigger._52000014_qd {
    public static class _rockdrop_1100 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1100}, arg2: false);
                context.SetEffect(arg1: new[] {1101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State낙하01준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하01준비 : TriggerState {
            internal State낙하01준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State낙하01시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하01시작 : TriggerState {
            internal State낙하01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State낙하01완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하01완료 : TriggerState {
            internal State낙하01완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.SetSkill(arg1: new[] {1100}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetSkill(arg1: new[] {1100}, arg2: false);
                context.SetEffect(arg1: new[] {1101}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State낙하01준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}