namespace Maple2.Trigger._52000014_qd {
    public static class _rockdrop_1300 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1300}, arg2: false);
                context.SetSkill(arg1: new[] {1302}, arg2: false);
                context.SetSkill(arg1: new[] {1304}, arg2: false);
                context.SetEffect(arg1: new[] {1301}, arg2: false);
                context.SetEffect(arg1: new[] {1303}, arg2: false);
                context.SetEffect(arg1: new[] {1305}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State낙하01시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하01시작 : TriggerState {
            internal State낙하01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1301}, arg2: true);
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
                context.SetSkill(arg1: new[] {1300}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State낙하02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하02시작 : TriggerState {
            internal State낙하02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1303}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State낙하02완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하02완료 : TriggerState {
            internal State낙하02완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 2);
                context.SetSkill(arg1: new[] {1302}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State낙하03시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하03시작 : TriggerState {
            internal State낙하03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {1305}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State낙하03완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하03완료 : TriggerState {
            internal State낙하03완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 1);
                context.SetSkill(arg1: new[] {1304}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 2);
                context.SetSkill(arg1: new[] {1300}, arg2: false);
                context.SetSkill(arg1: new[] {1302}, arg2: false);
                context.SetSkill(arg1: new[] {1304}, arg2: false);
                context.SetEffect(arg1: new[] {1301}, arg2: false);
                context.SetEffect(arg1: new[] {1303}, arg2: false);
                context.SetEffect(arg1: new[] {1305}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State낙하01시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}