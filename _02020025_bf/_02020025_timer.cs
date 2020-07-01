namespace Maple2.Trigger._02020025_bf {
    public static class _02020025_timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Timer") == 1) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "BattleTimer", arg2: 300, arg3: true, arg4: false);
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
                if (context.TimeExpired(arg1: "BattleTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "BattleTimer");
                context.SetUserValue(triggerId: 99990002, key: "Timer", value: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}