namespace Maple2.Trigger._02010051_bf {
    public static class _soundeffect05 {
        public class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000, 6001, 6002, 6003, 900}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State음성Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State음성Cinematic : TriggerState {
            internal State음성Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
                context.SetEffect(triggerIds: new []{900}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10000})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{900}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
