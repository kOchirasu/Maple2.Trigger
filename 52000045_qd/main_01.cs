namespace Maple2.Trigger._52000045_qd {
    public static class _main_01 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 110)) {
                    context.SetEffect(triggerIds: new []{7001}, visible: true);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.AddBuff(boxIds: new []{701}, skillId: 70000105, level: 1);
                context.SetConversation(type: 2, spawnId: 11001560, script: "$52000045_QD__MAIN_01__0$", arg4: 5);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 304, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 305, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 306, patrolName: "MS2PatrolData_2001");
                context.CameraSelectPath(pathIds: new []{8001, 8002, 8003}, returnView: false);
            }

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
                context.SetConversation(type: 2, spawnId: 11001560, script: "$52000045_QD__MAIN_01__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.CreateMonster(spawnIds: new []{101}, arg2: false);
                    context.RemoveBuff(boxId: 701, skillId: 70000105);
                    context.CameraSelectPath(pathIds: new []{8004}, returnView: true);
                    context.DestroyMonster(spawnIds: new []{101, 401, 402, 403, 404, 405});
                    context.SetActor(triggerId: 5001, visible: false, initialSequence: "Idle_A");
                    context.SetActor(triggerId: 5002, visible: false, initialSequence: "Idle_A");
                    context.SetActor(triggerId: 5003, visible: false, initialSequence: "Idle_A");
                    context.SetCinematicUI(type: 4);
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEffect(triggerIds: new []{7001}, visible: false);
                    context.AddBuff(boxIds: new []{701}, skillId: 70000094, level: 1);
                    context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 4000f);
                    context.SetCinematicUI(type: 1);
                    context.SetCinematicUI(type: 3);
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Failure_Idle_A"});
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(triggerIds: new []{7002}, visible: true);
                    context.MoveUserPath(patrolName: "MS2PatrolData_2002");
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.CreateMonster(spawnIds: new []{901}, arg2: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 901, script: "$52000045_QD__MAIN_01__2$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_A_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_A_10 : TriggerState {
            internal StateStart_A_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 901, script: "$52000045_QD__MAIN_01__11$", arg4: 3);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_01__12$", arg4: 3, arg5: 0);
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_01__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetEffect(triggerIds: new []{7003}, visible: true);
                    context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_2005");
                    return new StateStart_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{801, 802, 803, 804, 805, 806}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_12 : TriggerState {
            internal StateStart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_13 : TriggerState {
            internal StateStart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7004}, visible: true);
                context.CameraSelectPath(pathIds: new []{8004}, returnView: true);
                context.CreateMonster(spawnIds: new []{809}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 901, sequenceName: "Down_Idle_A", duration: 300000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.ShowGuideSummary(entityId: 25200473, textId: 25200473);
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    return new StateStart_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_14 : TriggerState {
            internal StateStart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{801, 802, 803, 804, 805, 806, 809})) {
                    context.HideGuideSummary(entityId: 25200473);
                    return new StateStart_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_15 : TriggerState {
            internal StateStart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_16 : TriggerState {
            internal StateStart_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{7701, 7702}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                    return new StateStart_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_17 : TriggerState {
            internal StateStart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 7702, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000045_QD__MAIN_01__4$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_18 : TriggerState {
            internal StateStart_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 7701, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000045_QD__MAIN_01__5$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_2006");
                    context.MoveNpc(spawnId: 7701, patrolName: "MS2PatrolData_7003");
                    context.MoveNpc(spawnId: 7702, patrolName: "MS2PatrolData_7004");
                    return new StateStart_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_19 : TriggerState {
            internal StateStart_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                    return new StateStart_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_20 : TriggerState {
            internal StateStart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 7701, script: "$52000045_QD__MAIN_01__6$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 7702, script: "$52000045_QD__MAIN_01__7$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_21 : TriggerState {
            internal StateStart_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_01__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_01__9$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_01__10$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStart_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_22 : TriggerState {
            internal StateStart_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAchievement(triggerId: 701, type: "trigger", code: "MeetAgainStriker");
                    context.MoveUser(mapId: 02000138, portalId: 103);
                    return new StateStart_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
