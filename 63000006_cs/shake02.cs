namespace Maple2.Trigger._63000006_cs {
    public static class _shake02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State다리흔들기Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리흔들기Prepare : TriggerState {
            internal State다리흔들기Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{910, 911, 912, 913}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateActivateSkill01(context);
            }

            public override void OnExit() { }
        }

        private class StateActivateSkill01 : TriggerState {
            internal StateActivateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 42);
                context.SetSkill(triggerIds: new []{910, 911, 912, 913}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State다리흔들기Prepare(context);
                }

                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{910, 911, 912, 913}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
