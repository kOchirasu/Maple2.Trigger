namespace Maple2.Trigger._52000030_qd {
    public static class _main_w {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101}, arg2: 30)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Nutaman_intro.swf", movieId: 1);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000032, arg3: "$52000030_QD__MAIN_W__0$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "NPC 단체 이동");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new StateNPC단체이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC단체이동 : TriggerState {
            internal StateNPC단체이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005");
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008");
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_1009");
                context.MoveNpc(arg1: 1010, arg2: "MS2PatrolData_1010");
                context.MoveNpc(arg1: 1011, arg2: "MS2PatrolData_1011");
                context.MoveNpc(arg1: 1012, arg2: "MS2PatrolData_1001");
                context.MoveNpc(arg1: 1013, arg2: "MS2PatrolData_1002");
                context.MoveNpc(arg1: 1014, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014})) {
                    context.State = new State전투판으로이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014});
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 2001, 2002}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State전투판으로이동 : TriggerState {
            internal State전투판으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.MoveUser(arg1: 52000030, arg2: 100);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.State = new State2차전투(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {2001});
            }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2003, 2004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2003})) {
                    context.State = new State이슈라대사02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {2004});
            }
        }

        private class State이슈라대사02 : TriggerState {
            internal State이슈라대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001578, arg3: "$52000030_QD__MAIN_W__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State3차전투(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2005})) {
                    context.State = new State이슈라대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사03 : TriggerState {
            internal State이슈라대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000032, arg3: "$52000030_QD__MAIN_W__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 52000031, arg2: 0);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}