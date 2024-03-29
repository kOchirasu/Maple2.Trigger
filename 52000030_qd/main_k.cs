using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000030_qd {
    public static class _main_k {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101}, jobCode: 10)) {
                    return new StateStartCinematic(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 01)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Nutaman_intro.swf", movieId: 1);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateIshuraScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript01 : TriggerState {
            internal StateIshuraScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000030_QD__MAIN_K__0$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11000076, script: "$52000030_QD__MAIN_K__1$", arg4: 3, arg5: 0);
                context.SetSkip(state: new StateNPC단체이동(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateNPC단체이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC단체이동 : TriggerState {
            internal StateNPC단체이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001");
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005");
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_1006");
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 1008, patrolName: "MS2PatrolData_1008");
                context.MoveNpc(spawnId: 1009, patrolName: "MS2PatrolData_1009");
                context.MoveNpc(spawnId: 1010, patrolName: "MS2PatrolData_1010");
                context.MoveNpc(spawnId: 1011, patrolName: "MS2PatrolData_1011");
                context.MoveNpc(spawnId: 1012, patrolName: "MS2PatrolData_1001");
                context.MoveNpc(spawnId: 1013, patrolName: "MS2PatrolData_1002");
                context.MoveNpc(spawnId: 1014, patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014})) {
                    return new State전투판으로이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014});
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 2001, 2002}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State전투판으로이동 : TriggerState {
            internal State전투판으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enabled: false);
                context.MoveUser(mapId: 52000030, portalId: 100);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    return new State2차전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{2001});
            }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003, 2004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    return new StateIshuraScript02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{2004});
            }
        }

        private class StateIshuraScript02 : TriggerState {
            internal StateIshuraScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000076, script: "$52000030_QD__MAIN_K__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State3차전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2005})) {
                    return new StateIshuraScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript03 : TriggerState {
            internal StateIshuraScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000030_QD__MAIN_K__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.MoveUser(mapId: 52000031, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
