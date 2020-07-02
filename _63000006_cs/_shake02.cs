namespace Maple2.Trigger._63000006_cs {
    public static class _shake02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State다리흔들기준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리흔들기준비 : TriggerState {
            internal State다리흔들기준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {910, 911, 912, 913}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateActivateSkill01(context);
            }

            public override void OnExit() { }
        }

        private class StateActivateSkill01 : TriggerState {
            internal StateActivateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 42);
                context.SetSkill(arg1: new[] {910, 911, 912, 913}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State다리흔들기준비(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {910, 911, 912, 913}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}