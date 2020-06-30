using System;

namespace Maple2.Trigger._02000074_in {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4000}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101, 102});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001592},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001592},
                    arg3: new byte[] {2})) {
                    context.State = new State쪽지스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001592},
                    arg3: new byte[] {1})) {
                    context.State = new State쪽지스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001591},
                    arg3: new byte[] {3})) {
                    context.State = new State쪽지스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001591},
                    arg3: new byte[] {2})) {
                    context.State = new State쪽지스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001589},
                    arg3: new byte[] {2})) {
                    context.State = new State케이틀린스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001589},
                    arg3: new byte[] {1})) {
                    context.State = new State케이틀린스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001588},
                    arg3: new byte[] {3})) {
                    context.State = new State케이틀린스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001588},
                    arg3: new byte[] {2})) {
                    context.State = new State케이틀린스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린스폰 : TriggerState {
            internal State케이틀린스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9000")) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쪽지스폰 : TriggerState {
            internal State쪽지스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetMesh(arg1: new int[] {4000}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9000")) {
                    context.State = new Statestart(context);
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