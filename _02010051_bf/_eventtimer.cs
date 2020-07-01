namespace Maple2.Trigger._02010051_bf {
    public static class _eventtimer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new State시간체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시간체크 : TriggerState {
            internal State시간체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "timercheck") == 1) {
                    return new State업적이벤트(context);
                }

                if (context.WaitTick(waitTick: 240000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업적이벤트 : TriggerState {
            internal State업적이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9003, arg2: "trigger", arg3: "CaboTimeEvent");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State업적이벤트(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}