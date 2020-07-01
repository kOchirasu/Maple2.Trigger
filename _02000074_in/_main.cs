namespace Maple2.Trigger._02000074_in {
    public static class _main {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4000}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 102});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001592}, arg3: new byte[] {3})) {
                    return new State종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001592}, arg3: new byte[] {2})) {
                    return new State쪽지스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001592}, arg3: new byte[] {1})) {
                    return new State쪽지스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001591}, arg3: new byte[] {3})) {
                    return new State쪽지스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001591}, arg3: new byte[] {2})) {
                    return new State쪽지스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001589}, arg3: new byte[] {2})) {
                    return new State케이틀린스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001589}, arg3: new byte[] {1})) {
                    return new State케이틀린스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001588}, arg3: new byte[] {3})) {
                    return new State케이틀린스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001588}, arg3: new byte[] {2})) {
                    return new State케이틀린스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린스폰 : TriggerState {
            internal State케이틀린스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9000})) {
                    return new Statestart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쪽지스폰 : TriggerState {
            internal State쪽지스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {4000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9000})) {
                    return new Statestart(context);
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