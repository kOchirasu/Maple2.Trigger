using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010052_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{7001, 7002, 81004}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 102, 103, 107, 108, 109, 110, 111, 112, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 421, 422, 423, 431, 432, 433, 434, 435, 436, 437, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613}, arg2: false);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
                context.SetMesh(triggerIds: new []{75011, 75012, 75013}, visible: true, arg3: 1000, arg4: 500, arg5: 8f);
                context.SetMesh(triggerIds: new []{75001, 75002, 75003}, visible: false, arg3: 1000, arg4: 500, arg5: 8f);
                context.CreateMonster(spawnIds: new []{991, 992, 993, 994}, arg2: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{80010, 80011}, returnView: true);
                context.SetMesh(triggerIds: new []{22201, 22202, 22203, 22204, 22205, 22206, 22207, 22208, 22209, 22210, 22211, 22212, 22213, 22214, 22215, 22216, 22217, 22218, 22219, 22220, 22221, 22222, 22223, 22224, 22225, 22226, 22227, 22228, 22229, 22230, 22231, 22232, 22233, 22234, 22235, 22236, 22237, 22238, 22239, 22240, 22241, 22242, 22243, 22244, 22245, 22246, 22247, 22248, 22249, 22250, 22251, 22252, 22253, 22254, 22255, 22256, 22257, 22258, 22259, 22260, 22261, 22262, 22263, 22264, 22265, 22266, 22267, 22268, 22269, 22270, 22271, 22272, 22273, 22274, 22275, 22276, 22277, 22278, 22279, 22280, 22281, 22282, 22283, 22284, 22285, 22286, 22287, 22288, 22289, 22290, 22291, 22292, 22293, 22294, 22295, 22296, 22297, 22298, 22299}, visible: false, arg3: 800, arg4: 100, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02010052_BF__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 80001, enabled: true);
                context.SetConversation(type: 2, spawnId: 21800073, script: "$02010052_BF__MAIN__1$", arg4: 3);
                context.MoveNpc(spawnId: 991, patrolName: "MS2PatrolData_1001");
                context.SetSkip(state: new StateEvent_01_02(context));
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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
                context.SetConversation(type: 2, spawnId: 21800073, script: "$02010052_BF__MAIN__2$", arg4: 3);
                context.MoveNpc(spawnId: 991, patrolName: "MS2PatrolData_1002");
                context.SetSkip(state: new StateEvent_01_03(context));
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_01_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.CameraSelect(triggerId: 80001, enabled: false);
            }
        }

        private class StateEvent_01_03 : TriggerState {
            internal StateEvent_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetEffect(triggerIds: new []{7901}, visible: true);
                context.DestroyMonster(spawnIds: new []{991});
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 992, script: "$02010052_BF__MAIN__3$", arg4: 3);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_02 : TriggerState {
            internal StateEvent_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetConversation(type: 1, spawnId: 992, script: "$02010052_BF__MAIN__4$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 992, patrolName: "MS2PatrolData_1003");
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_03 : TriggerState {
            internal StateEvent_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{992});
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 80002, enabled: true);
                context.SetConversation(type: 2, spawnId: 21800073, script: "$02010052_BF__MAIN__5$", arg4: 3);
                context.MoveNpc(spawnId: 993, patrolName: "MS2PatrolData_1004");
                context.SetSkip(state: new StateEvent_03_02(context));
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_03_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.CameraSelect(triggerId: 80002, enabled: false);
            }
        }

        private class StateEvent_03_02 : TriggerState {
            internal StateEvent_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.DestroyMonster(spawnIds: new []{993});
                context.CreateMonster(spawnIds: new []{9999}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
