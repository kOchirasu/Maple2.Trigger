namespace Maple2.Trigger._52000049_qd {
    public static class _main_01 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{8099}, enabled: false);
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306}, arg2: false);
                context.SetMesh(triggerIds: new []{2116, 2201, 2202, 2203, 2204, 2205, 2206}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{2})) {
                    return new StateStart_23(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{3})) {
                    return new StateStart_23(context);
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
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
                context.CameraSelectPath(pathIds: new []{8001, 8002, 8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7012}, visible: true);
                context.SetMesh(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115}, visible: false, arg3: 0, arg4: 100, arg5: 8f);
                context.SetMesh(triggerIds: new []{2116}, visible: true, arg3: 0, arg4: 100, arg5: 3f);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2002");
                context.SetConversation(type: 2, spawnId: 11001761, script: "$52000049_QD__MAIN_01__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7012}, visible: false);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000049_QD__MAIN_01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001761, script: "$52000049_QD__MAIN_01__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001761, script: "$52000049_QD__MAIN_01__3$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Event_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
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
                    context.DestroyMonster(spawnIds: new []{301, 302, 303, 304, 305, 306});
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001, 7002, 7003, 7004, 7005, 7006}, visible: true);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2003");
                context.CameraSelectPath(pathIds: new []{8005, 8006, 8007}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001761, script: "$52000049_QD__MAIN_01__4$", arg4: 4);
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000049_QD__MAIN_01__5$", arg4: 3, arg5: 0);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Failure_A", "Emotion_Failure_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000049_QD__MAIN_01__6$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Failure_Idle_A", duration: 6000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001761, script: "$52000049_QD__MAIN_01__7$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Event_A");
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_12 : TriggerState {
            internal StateStart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2004");
                context.CameraSelectPath(pathIds: new []{8009}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001761, script: "$52000049_QD__MAIN_01__8$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Attack_01_D");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_13 : TriggerState {
            internal StateStart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7010}, visible: true);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2011");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2012");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_2013");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_2014");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_2015");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_2016");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_14 : TriggerState {
            internal StateStart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7011}, visible: true);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Failure_A", "Emotion_Failure_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_15 : TriggerState {
            internal StateStart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Emotion_Failure_Idle_A", duration: 18000f);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_17 : TriggerState {
            internal StateStart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{501}, arg2: false);
                context.CameraSelectPath(pathIds: new []{8010, 8011, 8012}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.SetSkill(triggerIds: new []{8099}, enabled: true);
                    context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2021");
                    context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2022");
                    context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_2023");
                    context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_2024");
                    context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_2025");
                    context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_2026");
                    context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_B");
                    context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_B");
                    context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Bore_B");
                    context.SetNpcEmotionSequence(spawnId: 204, sequenceName: "Bore_B");
                    context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Bore_B");
                    context.SetNpcEmotionSequence(spawnId: 206, sequenceName: "Bore_B");
                    return new StateStart_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_18 : TriggerState {
            internal StateStart_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(triggerIds: new []{7010}, visible: false);
                    context.DestroyMonster(spawnIds: new []{201, 202, 203, 204, 205, 206});
                    return new StateStart_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_19 : TriggerState {
            internal StateStart_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_2030");
                context.SetConversation(type: 1, spawnId: 501, script: "$52000049_QD__MAIN_01__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(type: 1, spawnId: 101, script: "$52000049_QD__MAIN_01__10$", arg4: 3, arg5: 0);
                    context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2099");
                    return new StateStart_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_20 : TriggerState {
            internal StateStart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAchievement(triggerId: 701, type: "trigger", code: "HeroJunta");
                    context.SetMesh(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115}, visible: true, arg3: 0, arg4: 100, arg5: 8f);
                    context.DestroyMonster(spawnIds: new []{101});
                    context.CameraSelectPath(pathIds: new []{8013}, returnView: true);
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    return new StateStart_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_21 : TriggerState {
            internal StateStart_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{501});
                    context.CreateMonster(spawnIds: new []{502}, arg2: false);
                    return new StateStart_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_22 : TriggerState {
            internal StateStart_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{1})) {
                    context.MoveUser(mapId: 52000050, portalId: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_23 : TriggerState {
            internal StateStart_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{502}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_22(context);
                }

                return null;
            }

            public override void OnExit() { }
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
