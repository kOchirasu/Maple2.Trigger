using System;

namespace Maple2.Trigger._52000013_qd {
    public static class _patrol {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 6000, arg2: false, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State어린벨라등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라등장 : TriggerState {
            internal State어린벨라등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.CreateMonster(arg1: new int[] {5000}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State어린벨라패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤01 : TriggerState {
            internal State어린벨라패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9001, arg2: new int[] {5000})) {
                    context.State = new State어린벨라대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라대화01 : TriggerState {
            internal State어린벨라대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 5000, arg3: "$52000013_QD__MAIN__1$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State어린벨라패트롤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤02 : TriggerState {
            internal State어린벨라패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new int[] {5000})) {
                    context.State = new State어린벨라대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라대화02 : TriggerState {
            internal State어린벨라대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 5000, arg3: "$52000013_QD__MAIN__2$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State어린벨라패트롤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라패트롤03 : TriggerState {
            internal State어린벨라패트롤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new int[] {5000})) {
                    context.State = new State카메라연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출01 : TriggerState {
            internal State카메라연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "12", arg2: 6);
                context.CameraSelectPath(arg1: new int[] {901}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new int[] {5000})) {
                    context.State = new State카메라연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출02 : TriggerState {
            internal State카메라연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 12);
                context.SetActor(arg1: 6000, arg2: true, arg3: "Idle_A");
                context.CameraSelectPath(arg1: new int[] {902, 903}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State화면끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화면끄기 : TriggerState {
            internal State화면끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 2);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State어린벨라소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어린벨라소멸 : TriggerState {
            internal State어린벨라소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 1);
                context.DestroyMonster(arg1: new int[] {5000});
                context.SetActor(arg1: 6000, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new int[] {6001}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State벨라연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라연출01 : TriggerState {
            internal State벨라연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "16", arg2: 8);
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 6001, arg2: "MS2PatrolData_2001");
                context.CameraSelectPath(arg1: new int[] {904, 905}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "16")) {
                    context.State = new State벨라연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라연출종료 : TriggerState {
            internal State벨라연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "17", arg2: 8);
                context.CameraSelect(arg1: 905, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "17")) {
                    context.State = new State이동딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동딜레이 : TriggerState {
            internal State이동딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10000}, arg2: new int[] {10002611},
                    arg3: new byte[] {3})) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "19", arg2: 10);
                context.MoveUser(arg1: 03009017, arg2: 50);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 10);
                context.DestroyMonster(arg1: new int[] {6001});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}