using System;

namespace Maple2.Trigger._52000064_qd {
    public static class _90000650 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기(context);

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003}, arg2: false);
                context.CreateMonster(arg1: new int[] {1101, 1102, 1103}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new State아이템생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이템생성 : TriggerState {
            internal State아이템생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State완료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료대기 : TriggerState {
            internal State완료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {9011, 9012, 9013, 9014, 9015});
                context.SetEventUI(arg1: 7, arg3: new int[] {3000}, arg4: "0");
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ArrivedFlyBalloon");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {90000650},
                    arg3: new byte[] {3})) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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