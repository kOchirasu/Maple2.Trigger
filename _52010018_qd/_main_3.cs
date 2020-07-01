namespace Maple2.Trigger._52010018_qd {
    public static class _main_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State분기점(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002851},
                    arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852},
                    arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002853},
                    arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002853},
                    arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002851},
                    arg3: new byte[] {3})) {
                    context.State = new State분기점2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State분기점2 : TriggerState {
            internal State분기점2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852},
                    arg3: new byte[] {2})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852},
                    arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1005});
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}