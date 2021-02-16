using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010052_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {7001, 7002, 81004}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 102, 103, 107, 108, 109, 110, 111, 112, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 421, 422, 423, 431, 432, 433, 434, 435, 436, 437, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
                context.SetMesh(arg1: new[] {75011, 75012, 75013}, arg2: true, arg3: 1000, arg4: 500, arg5: 8f);
                context.SetMesh(arg1: new[] {75001, 75002, 75003}, arg2: false, arg3: 1000, arg4: 500, arg5: 8f);
                context.CreateMonster(arg1: new[] {991, 992, 993, 994}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {80010, 80011}, arg2: true);
                context.SetMesh(arg1: new[] {22201, 22202, 22203, 22204, 22205, 22206, 22207, 22208, 22209, 22210, 22211, 22212, 22213, 22214, 22215, 22216, 22217, 22218, 22219, 22220, 22221, 22222, 22223, 22224, 22225, 22226, 22227, 22228, 22229, 22230, 22231, 22232, 22233, 22234, 22235, 22236, 22237, 22238, 22239, 22240, 22241, 22242, 22243, 22244, 22245, 22246, 22247, 22248, 22249, 22250, 22251, 22252, 22253, 22254, 22255, 22256, 22257, 22258, 22259, 22260, 22261, 22262, 22263, 22264, 22265, 22266, 22267, 22268, 22269, 22270, 22271, 22272, 22273, 22274, 22275, 22276, 22277, 22278, 22279, 22280, 22281, 22282, 22283, 22284, 22285, 22286, 22287, 22288, 22289, 22290, 22291, 22292, 22293, 22294, 22295, 22296, 22297, 22298, 22299}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__MAIN__6$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 80001, arg2: true);
                context.SetConversation(arg1: 2, arg2: 21800073, arg3: "$02010052_BF__MAIN__1$", arg4: 3);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_1001");
                context.SetSkip(state: new StateEvent_01_02(context));
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_01_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_01_02 : TriggerState {
            internal StateEvent_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 21800073, arg3: "$02010052_BF__MAIN__2$", arg4: 3);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_1002");
                context.SetSkip(state: new StateEvent_01_03(context));
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_01_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
                context.CameraSelect(arg1: 80001, arg2: false);
            }
        }

        private class StateEvent_01_03 : TriggerState {
            internal StateEvent_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetEffect(arg1: new[] {7901}, arg2: true);
                context.DestroyMonster(arg1: new[] {991});
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 992, arg3: "$02010052_BF__MAIN__3$", arg4: 3);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_02 : TriggerState {
            internal StateEvent_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetConversation(arg1: 1, arg2: 992, arg3: "$02010052_BF__MAIN__4$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_1003");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_03 : TriggerState {
            internal StateEvent_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {992});
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 80002, arg2: true);
                context.SetConversation(arg1: 2, arg2: 21800073, arg3: "$02010052_BF__MAIN__5$", arg4: 3);
                context.MoveNpc(arg1: 993, arg2: "MS2PatrolData_1004");
                context.SetSkip(state: new StateEvent_03_02(context));
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_03_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
                context.CameraSelect(arg1: 80002, arg2: false);
            }
        }

        private class StateEvent_03_02 : TriggerState {
            internal StateEvent_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.DestroyMonster(arg1: new[] {993});
                context.CreateMonster(arg1: new[] {9999}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}