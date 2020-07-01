namespace Maple2.Trigger._52000063_qd {
    public static class _random_skill_c {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607, 608, 609}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "gameStart") == 1) {
                    context.State = new State감지대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감지대기 : TriggerState {
            internal State감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607, 608, 609}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {113})) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607, 608, 609}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 80f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000008, arg3: 1, arg4: false, arg5: false);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000009, arg3: 1, arg4: false, arg5: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}