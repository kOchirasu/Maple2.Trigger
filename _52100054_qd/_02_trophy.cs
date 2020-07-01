namespace Maple2.Trigger._52100054_qd {
    public static class _02_trophy {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new State룸체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State트로피지급(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트로피지급 : TriggerState {
            internal State트로피지급(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Find02000398");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}