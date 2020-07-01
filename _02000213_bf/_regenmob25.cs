namespace Maple2.Trigger._02000213_bf {
    public static class _regenmob25 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State소환몹등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환몹등장 : TriggerState {
            internal State소환몹등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000261}, arg2: 1)) {
                    context.CreateMonster(arg1: new[] {1025}, arg2: false);
                    context.State = new State소멸체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸체크 : TriggerState {
            internal State소멸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000261}, arg2: 0)) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000261}, arg2: 2)) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1025})) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State소환몹등장(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1025});
                context.SetTimer(arg1: "1", arg2: 1200);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }
    }
}