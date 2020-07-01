namespace Maple2.Trigger._02020112_bf {
    public static class _button8 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {931})) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9908, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ButtonSuccess") == 1) {
                    return new State종료(context);
                }

                if (context.UserDetected(arg1: new[] {924})) {
                    return new State감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9908, arg2: true, arg3: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ButtonSuccess") == 1) {
                    return new State종료(context);
                }

                if (!context.UserDetected(arg1: new[] {924})) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9908, arg2: false, arg3: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}