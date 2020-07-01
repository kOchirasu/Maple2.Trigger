namespace Maple2.Trigger._52010018_qd {
    public static class _main_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1005}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State분기점(context);
            }

            public override void OnExit() { }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002851}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    return new State종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    return new State종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002853}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    return new State종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002853}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    return new State종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002851}, arg3: new byte[] {3})) {
                    return new State분기점2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State분기점2 : TriggerState {
            internal State분기점2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852}, arg3: new byte[] {2})) {
                    return new State종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852}, arg3: new byte[] {3})) {
                    return new State종료(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}