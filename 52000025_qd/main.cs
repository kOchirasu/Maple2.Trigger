namespace Maple2.Trigger._52000025_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002235}, questStates: new byte[]{1}, jobCode: 90)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002235}, questStates: new byte[]{2}, jobCode: 90)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002235}, questStates: new byte[]{3}, jobCode: 90)) {
                    return new StateStart_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_B : TriggerState {
            internal StateStart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202, 299}, arg2: false);
                context.DestroyMonster(spawnIds: new []{203, 204, 205});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 203, 204, 101, 102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetConversation(type: 1, spawnId: 201, script: "$52000025_QD__MAIN__0$", arg4: 2, arg5: 1);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 112, 113, 114, 115, 116}, arg2: false);
                context.SetConversation(type: 1, spawnId: 201, script: "$52000025_QD__MAIN__1$", arg4: 2, arg5: 5);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114, 115, 116})) {
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
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000025_QD__MAIN__2$", arg4: 4);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2000");
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000025_QD__MAIN__3$", arg4: 6);
                context.SetEffect(triggerIds: new []{7004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{203, 204, 205});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000025, portalId: 99);
            }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2001");
                context.MoveUserPath(patrolName: "MS2PatrolData_2002");
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001575, script: "$52000025_QD__MAIN__4$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000025_QD__MAIN__5$", arg4: 5);
                context.SetEffect(triggerIds: new []{7002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001575, script: "$52000025_QD__MAIN__6$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001575, script: "$52000025_QD__MAIN__7$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_11(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 8001, enabled: false);
            }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{299}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "SweepthePriates");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
