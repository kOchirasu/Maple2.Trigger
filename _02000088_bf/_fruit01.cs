namespace Maple2.Trigger._02000088_bf {
    public static class _fruit01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000138}, arg2: 1);
                context.SetEffect(arg1: new[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000138}, arg2: 0)) {
                    context.State = new State몬스터리젠(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터리젠 : TriggerState {
            internal State몬스터리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {201}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 90);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State트리거초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.DestroyMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}