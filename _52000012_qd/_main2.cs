using System;

namespace Maple2.Trigger._52000012_qd {
    public static class _main2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 10002, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {10011}, arg2: true);
                context.SetMesh(arg1: new int[] {10012}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002610},
                    arg3: new byte[] {2})) {
                    context.State = new State문열림1(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002610},
                    arg3: new byte[] {3})) {
                    context.State = new State문열림1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.DestroyMonster(arg1: new int[] {5000});
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
            }
        }

        private class State문열림1 : TriggerState {
            internal State문열림1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "19", arg2: 1);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {10011}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    context.State = new State문열림2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림2 : TriggerState {
            internal State문열림2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 10002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {10012}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {10002611},
                    arg3: new byte[] {2})) {
                    context.State = new State포털생성(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {10002611},
                    arg3: new byte[] {3})) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}