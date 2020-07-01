namespace Maple2.Trigger._63000006_cs {
    public static class _shake02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State다리흔들기준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리흔들기준비 : TriggerState {
            internal State다리흔들기준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {910, 911, 912, 913}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬발동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬발동01 : TriggerState {
            internal State스킬발동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 42);
                context.SetSkill(arg1: new[] {910, 911, 912, 913}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State다리흔들기준비(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {910, 911, 912, 913}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}