namespace Maple2.Trigger._61000010_me {
    public static class _winner {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State업적(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업적 : TriggerState {
            internal State업적(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "WinSanghaiRunners");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}