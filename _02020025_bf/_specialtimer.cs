namespace Maple2.Trigger._02020025_bf {
    public static class _specialtimer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SpecialTimer") == 1) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "SpecialTimer", arg2: 180, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크 : TriggerState {
            internal State타이머체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "SpecialTimer")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "SpecialTimer", value: 0);
                context.ResetTimer(arg1: "SpecialTimer");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}