namespace Maple2.Trigger._02020112_bf {
    public static class _button6 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{931})) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 9906, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ButtonSuccess") == 1) {
                    return new StateEnd(context);
                }

                if (context.UserDetected(boxIds: new []{922})) {
                    return new State감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 9906, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ButtonSuccess") == 1) {
                    return new StateEnd(context);
                }

                if (!context.UserDetected(boxIds: new []{922})) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 9906, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
