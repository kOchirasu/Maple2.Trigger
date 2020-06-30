using System;

namespace Maple2.Trigger._52000028_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.CreateMonster(
                    arg1: new int[]
                        {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014},
                    arg2: false);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {20002250}, arg3: new byte[] {1},
                    arg4: 90)) {
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {20002251}, arg3: new byte[] {1},
                    arg4: 90)) {
                    context.State = new StateNPC이동01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {10002931},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {10002932},
                    arg3: new byte[] {1})) {
                    context.State = new StateNPC이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아시모프이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프이동 : TriggerState {
            internal State아시모프이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new int[] {1001})) {
                    context.State = new State책장변경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State책장변경 : TriggerState {
            internal State책장변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State동영상재상(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동영상재상 : TriggerState {
            internal State동영상재상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Starlight_expedition.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State이슈라대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사01 : TriggerState {
            internal State이슈라대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000028_QD__MAIN__0$", arg4: 5, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State이슈라대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사02 : TriggerState {
            internal State이슈라대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000028_QD__MAIN__1$", arg4: 6, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State아시모프대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프대사01 : TriggerState {
            internal State아시모프대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_B");
                context.SetEffect(arg1: new int[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, arg3: "$52000028_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아시모프대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아시모프대사02 : TriggerState {
            internal State아시모프대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, arg3: "$52000028_QD__MAIN__3$", arg4: 6, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트수락대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "BackstoryOfRune");
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State퀘스트수락대기 : TriggerState {
            internal State퀘스트수락대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {20002251}, arg3: new byte[] {1},
                    arg4: 90)) {
                    context.State = new StateNPC이동01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {10002932},
                    arg3: new byte[] {1})) {
                    context.State = new StateNPC이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPC이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008_A");
                context.MoveNpc(arg1: 1013, arg2: "MS2PatrolData_1013_A");
                context.MoveNpc(arg1: 1014, arg2: "MS2PatrolData_1014_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
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