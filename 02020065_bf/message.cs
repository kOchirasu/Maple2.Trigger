namespace Maple2.Trigger._02020065_bf {
    public static class _message {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020065_BF__MESSAGE__0$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    return new State체력공지_1(context);
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    return new State체력공지_1(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력공지_1 : TriggerState {
            internal State체력공지_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 801) <= 0.50f) {
                    context.SetEventUI(arg1: 1, script: "$02020065_BF__MESSAGE__1$", duration: 5000);
                    return new State체력공지_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력공지_2 : TriggerState {
            internal State체력공지_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 801) <= 0.30f) {
                    context.SetEventUI(arg1: 1, script: "$02020065_BF__MESSAGE__2$", duration: 5000);
                    return new State체력공지_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력공지_3 : TriggerState {
            internal State체력공지_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 801) <= 0.10f) {
                    context.SetEventUI(arg1: 1, script: "$02020065_BF__MESSAGE__3$", duration: 5000);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
