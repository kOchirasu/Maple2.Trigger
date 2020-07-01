namespace Maple2.Trigger._99999922 {
    public static class _event4 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2000});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {999910})) {
                    return new State진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행1 : TriggerState {
            internal State진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "300", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2000})) {
                    return new State진행2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행2 : TriggerState {
            internal State진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {999910}, arg2: 49179111, arg3: 1, arg5: true);
                context.SetTimer(arg1: "300", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State시작10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작10 : TriggerState {
            internal State시작10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "400", arg2: 60);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}