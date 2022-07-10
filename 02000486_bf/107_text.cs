namespace Maple2.Trigger._02000486_bf {
    public static class _107_text {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9901})) {
                    return new State알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 900) <= 0.30f || context.GetNpcHpRate(spawnId: 901) <= 0.30f) {
                    return new State텍스트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State텍스트 : TriggerState {
            internal State텍스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000486_BF__107_TEXT__0$", duration: 4000);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
