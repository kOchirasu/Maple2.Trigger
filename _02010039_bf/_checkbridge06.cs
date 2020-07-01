namespace Maple2.Trigger._02010039_bf {
    public static class _checkbridge06 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {5002}, arg2: new[] {40002110}, arg3: new byte[] {1})) {
                    return new State업적발생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업적발생 : TriggerState {
            internal State업적발생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 5002, arg2: "trigger", arg3: "checkBridge");
            }

            public override TriggerState Execute() {
                return new State초기화준비(context);
            }

            public override void OnExit() { }
        }

        private class State초기화준비 : TriggerState {
            internal State초기화준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}