namespace Maple2.Trigger._99999907 {
    public static class _12000015 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000015}, arg2: 2);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State반응대기(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000015}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000015}, arg2: 0)) {
                    context.State = new State랜덤버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤버프 : TriggerState {
            internal State랜덤버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000008, arg3: 1, arg4: false, arg5: false);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000008, arg3: 1, arg4: false, arg5: false);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 40f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000008, arg3: 1, arg4: false, arg5: false);
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