namespace Maple2.Trigger._63000029_cs {
    public static class _cave01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5100, 5200, 5201, 5202, 5203, 5300, 5400, 5500, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5600, 5800, 5801, 5820, 5821, 5900, 5901, 5920, 5921, 5922, 5930, 5931, 6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6200, 6201, 6300, 6301, 6400}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "or_fi_struc_stonegate_A01_off");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: false);
                context.SetSkill(triggerIds: new []{7000, 7001, 7002, 7003, 7100, 7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109}, arg2: false);
                context.SetBreakable(triggerIds: new []{4000, 4001}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000453}, questStates: new byte[]{3})) {
                    return new StateQuestOnGiong11(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000453}, questStates: new byte[]{2})) {
                    return new StateQuestOnGiong01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000453}, questStates: new byte[]{1})) {
                    return new StateLiftRock01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000452}, questStates: new byte[]{3})) {
                    return new StateSecondQuestStart01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000452}, questStates: new byte[]{2})) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong11 : TriggerState {
            internal StateQuestOnGiong11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateQuestOnGiong12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong12 : TriggerState {
            internal StateQuestOnGiong12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000029, portalId: 30, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{110, 210, 302}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, visible: true, meshCount: 9, arg4: 0, delay: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateQuestOnGiong13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong13 : TriggerState {
            internal StateQuestOnGiong13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong01 : TriggerState {
            internal StateQuestOnGiong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateQuestOnGiong02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong02 : TriggerState {
            internal StateQuestOnGiong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000029, portalId: 20, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{102, 202}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, visible: true, meshCount: 9, arg4: 0, delay: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateQuestOnGiong03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong03 : TriggerState {
            internal StateQuestOnGiong03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetConversation(type: 1, spawnId: 102, script: "$63000029_CS__CAVE01__0$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestOnGiong04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong04 : TriggerState {
            internal StateQuestOnGiong04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_101");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLaozApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10030100, textId: 10030100);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000452}, questStates: new byte[]{3})) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10030100);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000453}, questStates: new byte[]{1})) {
                    return new StateLiftRock01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031020);
            }
        }

        private class StateLiftRock01 : TriggerState {
            internal StateLiftRock01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10036010, textId: 10036010);
                context.SetEffect(triggerIds: new []{5300, 5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.DetectLiftableObject(boxIds: new []{9001}, itemId: 30000441)) {
                    return new StateLiftRock02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10036010);
            }
        }

        private class StateLiftRock02 : TriggerState {
            internal StateLiftRock02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10036011, textId: 10036011);
                context.SetEffect(triggerIds: new []{5100, 5200, 5201, 5202, 5203}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9002}, itemId: 30000441)) {
                    return new StateLiftRock03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10036011);
            }
        }

        private class StateLiftRock03 : TriggerState {
            internal StateLiftRock03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetEffect(triggerIds: new []{5001, 5100, 5200, 5201, 5202, 5203}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEnteranceBlock01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnteranceBlock01 : TriggerState {
            internal StateEnteranceBlock01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEnteranceBlock02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnteranceBlock02 : TriggerState {
            internal StateEnteranceBlock02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000029, portalId: 10, boxId: 9900);
                context.CameraSelect(triggerId: 500, enable: true);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{102, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEnteranceBlock03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnteranceBlock03 : TriggerState {
            internal StateEnteranceBlock03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateLaozApp05_CSkip(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, visible: true, meshCount: 9, arg4: 100, delay: 100);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTimeToMoveIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToMoveIn01 : TriggerState {
            internal StateTimeToMoveIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTimeToMoveIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToMoveIn02 : TriggerState {
            internal StateTimeToMoveIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$63000029_CS__CAVE01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTimeToMoveIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToMoveIn03 : TriggerState {
            internal StateTimeToMoveIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$63000029_CS__CAVE01__2$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_101");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLaozApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozApp01 : TriggerState {
            internal StateLaozApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{301}, arg2: false);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_301");
                context.SetEffect(triggerIds: new []{6400}, visible: true);
                context.SetConversation(type: 1, spawnId: 202, script: "$63000029_CS__CAVE01__3$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 102, script: "$63000029_CS__CAVE01__4$", arg4: 2, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLaozApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozApp02 : TriggerState {
            internal StateLaozApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateLaozApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozApp03 : TriggerState {
            internal StateLaozApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateLaozApp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozApp04 : TriggerState {
            internal StateLaozApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$63000029_CS__CAVE01__5$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 102, script: "$63000029_CS__CAVE01__6$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLaozApp05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozApp05_CSkip : TriggerState {
            internal StateLaozApp05_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000029, portalId: 10, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_101");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_201");
                context.CreateMonster(spawnIds: new []{301}, arg2: false);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLaozTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozApp05 : TriggerState {
            internal StateLaozApp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLaozTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalk01 : TriggerState {
            internal StateLaozTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__7$", arg4: 5);
                context.SetSkip(state: new StateLaozTalk04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLaozTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalk02 : TriggerState {
            internal StateLaozTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalk03 : TriggerState {
            internal StateLaozTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__8$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLaozTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalk04 : TriggerState {
            internal StateLaozTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(spawnIds: new []{301});
                context.CreateMonster(spawnIds: new []{302}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 601, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMeetLaoz01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetLaoz01 : TriggerState {
            internal StateMeetLaoz01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10036020, textId: 10036020);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new StateSecondQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10036020);
            }
        }

        private class StateSecondQuestEnd01 : TriggerState {
            internal StateSecondQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002, 5000}, visible: true);
                context.ShowGuideSummary(entityId: 10036030, textId: 10036030);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000453}, questStates: new byte[]{3})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10036030);
            }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "SafetyStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnteranceBlockExplosion01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnteranceBlockExplosion01 : TriggerState {
            internal StateEnteranceBlockExplosion01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSceneSkip(state: new StateLaozNKahnTalk18_CSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEnteranceBlockExplosion02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnteranceBlockExplosion02 : TriggerState {
            internal StateEnteranceBlockExplosion02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000029, portalId: 11, boxId: 9900);
                context.CameraSelect(triggerId: 610, enable: true);
                context.DestroyMonster(spawnIds: new []{102, 202, 302, 110, 210});
                context.CreateMonster(spawnIds: new []{103, 203, 303}, arg2: false);
                context.SetRandomMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, visible: false, meshCount: 9, arg4: 100, delay: 100);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEnteranceBlockExplosion03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnteranceBlockExplosion03 : TriggerState {
            internal StateEnteranceBlockExplosion03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5400}, visible: true);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{7001}, arg2: true);
                context.CreateMonster(spawnIds: new []{401}, arg2: false);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_401");
                context.SetEffect(triggerIds: new []{5500, 5501, 5502, 5503, 5504, 5505, 5506, 5507}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKahnWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn01 : TriggerState {
            internal StateKahnWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5901, 6100}, visible: true);
                context.SetConversation(type: 1, spawnId: 401, script: "$63000029_CS__CAVE01__9$", arg4: 3, arg5: 0);
                context.CreateMonster(spawnIds: new []{900, 901, 902, 903}, arg2: false);
                context.MoveNpc(spawnId: 900, patrolName: "MS2PatrolData_900");
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_901");
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_902");
                context.MoveNpc(spawnId: 903, patrolName: "MS2PatrolData_903");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateKahnWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn02 : TriggerState {
            internal StateKahnWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{904, 905, 906}, arg2: false);
                context.MoveNpc(spawnId: 904, patrolName: "MS2PatrolData_904");
                context.MoveNpc(spawnId: 905, patrolName: "MS2PatrolData_905");
                context.MoveNpc(spawnId: 906, patrolName: "MS2PatrolData_906");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateKahnWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn03 : TriggerState {
            internal StateKahnWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{907, 908, 909}, arg2: false);
                context.MoveNpc(spawnId: 907, patrolName: "MS2PatrolData_907");
                context.MoveNpc(spawnId: 908, patrolName: "MS2PatrolData_908");
                context.MoveNpc(spawnId: 909, patrolName: "MS2PatrolData_909");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateKahnWalkIn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn04 : TriggerState {
            internal StateKahnWalkIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{940, 941, 942, 943}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKahnWalkIn05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn05 : TriggerState {
            internal StateKahnWalkIn05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKahnWalkIn06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn06 : TriggerState {
            internal StateKahnWalkIn06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 611, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKahnWalkIn07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnWalkIn07 : TriggerState {
            internal StateKahnWalkIn07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_302");
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetConversation(type: 1, spawnId: 303, script: "$63000029_CS__CAVE01__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToFight01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToFight01 : TriggerState {
            internal StateReadyToFight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_202");
                context.SetConversation(type: 1, spawnId: 203, script: "$63000029_CS__CAVE01__11$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReadyToFight02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToFight02 : TriggerState {
            internal StateReadyToFight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_102");
                context.SetConversation(type: 1, spawnId: 103, script: "$63000029_CS__CAVE01__12$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReadyToFight03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToFight03 : TriggerState {
            internal StateReadyToFight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Attack_Idle_A", duration: 90000f);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Attack_Idle_A", duration: 90000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMeetKahn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetKahn01 : TriggerState {
            internal StateMeetKahn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6101}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__13$", arg4: 9);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Event_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateMeetKahn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetKahn02 : TriggerState {
            internal StateMeetKahn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateMeetKahn03(context);
            }

            public override void OnExit() { }
        }

        private class StateMeetKahn03 : TriggerState {
            internal StateMeetKahn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__14$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMeetKahn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetKahn04 : TriggerState {
            internal StateMeetKahn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 620, enable: true);
            }

            public override TriggerState? Execute() {
                return new StateLaozTalkToJuntaNTinChai01(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai01 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__15$", arg4: 8);
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateLaozTalkToJuntaNTinChai02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai02 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozTalkToJuntaNTinChai03(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai03 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000029_CS__CAVE01__16$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLaozTalkToJuntaNTinChai04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai04 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozTalkToJuntaNTinChai05(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai05 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000029_CS__CAVE01__17$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLaozTalkToJuntaNTinChai06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai06 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozTalkToJuntaNTinChai07(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai07 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__18$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLaozTalkToJuntaNTinChai08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai08 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 611, enable: true);
                context.CreateMonster(spawnIds: new []{945, 946}, arg2: false);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_402");
                context.MoveNpc(spawnId: 900, patrolName: "MS2PatrolData_910");
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_911");
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_912");
                context.MoveNpc(spawnId: 903, patrolName: "MS2PatrolData_913");
                context.MoveNpc(spawnId: 904, patrolName: "MS2PatrolData_914");
                context.MoveNpc(spawnId: 905, patrolName: "MS2PatrolData_915");
                context.MoveNpc(spawnId: 906, patrolName: "MS2PatrolData_916");
                context.MoveNpc(spawnId: 907, patrolName: "MS2PatrolData_917");
                context.MoveNpc(spawnId: 908, patrolName: "MS2PatrolData_918");
                context.MoveNpc(spawnId: 909, patrolName: "MS2PatrolData_919");
                context.MoveNpc(spawnId: 920, patrolName: "MS2PatrolData_920");
                context.MoveNpc(spawnId: 921, patrolName: "MS2PatrolData_921");
                context.MoveNpc(spawnId: 922, patrolName: "MS2PatrolData_922");
                context.MoveNpc(spawnId: 923, patrolName: "MS2PatrolData_923");
                context.MoveNpc(spawnId: 924, patrolName: "MS2PatrolData_924");
                context.MoveNpc(spawnId: 925, patrolName: "MS2PatrolData_925");
                context.MoveNpc(spawnId: 926, patrolName: "MS2PatrolData_926");
                context.MoveNpc(spawnId: 927, patrolName: "MS2PatrolData_927");
                context.MoveNpc(spawnId: 928, patrolName: "MS2PatrolData_928");
                context.MoveNpc(spawnId: 929, patrolName: "MS2PatrolData_929");
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_930");
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_931");
                context.MoveNpc(spawnId: 940, patrolName: "MS2PatrolData_940");
                context.MoveNpc(spawnId: 941, patrolName: "MS2PatrolData_941");
                context.MoveNpc(spawnId: 942, patrolName: "MS2PatrolData_942");
                context.MoveNpc(spawnId: 943, patrolName: "MS2PatrolData_943");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLaozNKahnTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk01 : TriggerState {
            internal StateLaozNKahnTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{947, 948, 949}, arg2: false);
                context.MoveNpc(spawnId: 945, patrolName: "MS2PatrolData_945");
                context.MoveNpc(spawnId: 946, patrolName: "MS2PatrolData_946");
                context.CreateMonster(spawnIds: new []{950, 951, 952, 953, 954, 955, 956, 957, 958, 959}, arg2: false);
                context.MoveNpc(spawnId: 950, patrolName: "MS2PatrolData_900");
                context.MoveNpc(spawnId: 951, patrolName: "MS2PatrolData_901");
                context.MoveNpc(spawnId: 952, patrolName: "MS2PatrolData_902");
                context.MoveNpc(spawnId: 953, patrolName: "MS2PatrolData_903");
                context.MoveNpc(spawnId: 954, patrolName: "MS2PatrolData_904");
                context.MoveNpc(spawnId: 955, patrolName: "MS2PatrolData_905");
                context.MoveNpc(spawnId: 956, patrolName: "MS2PatrolData_906");
                context.MoveNpc(spawnId: 957, patrolName: "MS2PatrolData_907");
                context.MoveNpc(spawnId: 958, patrolName: "MS2PatrolData_908");
                context.MoveNpc(spawnId: 959, patrolName: "MS2PatrolData_909");
                context.SetEffect(triggerIds: new []{6004}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__19$", arg4: 9);
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
                context.CameraSelect(triggerId: 612, enable: true);
                context.SetSkip(state: new StateLaozNKahnTalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateLaozNKahnTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk02 : TriggerState {
            internal StateLaozNKahnTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateLaozNKahnTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk03 : TriggerState {
            internal StateLaozNKahnTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Event_A");
                context.SetEffect(triggerIds: new []{6102}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__20$", arg4: 9);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateLaozNKahnTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk04 : TriggerState {
            internal StateLaozNKahnTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozNKahnTalk05(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk05 : TriggerState {
            internal StateLaozNKahnTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Event_A");
                context.SetEffect(triggerIds: new []{6103}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__21$", arg4: 6);
                context.SetSkip(state: new StateLaozNKahnTalk06(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLaozNKahnTalk06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk06 : TriggerState {
            internal StateLaozNKahnTalk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateLaozNKahnTalk07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk07 : TriggerState {
            internal StateLaozNKahnTalk07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6005}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__22$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLaozNKahnTalk08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk08 : TriggerState {
            internal StateLaozNKahnTalk08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateLaozNKahnTalk09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk09 : TriggerState {
            internal StateLaozNKahnTalk09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6006}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__23$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLaozNKahnTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk10 : TriggerState {
            internal StateLaozNKahnTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateLaozNKahnTalk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk11 : TriggerState {
            internal StateLaozNKahnTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Event_A");
                context.SetEffect(triggerIds: new []{6104}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__24$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLaozNKahnTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk12 : TriggerState {
            internal StateLaozNKahnTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateLaozNKahnTalk13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk13 : TriggerState {
            internal StateLaozNKahnTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6007}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__25$", arg4: 8);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateLaozNKahnTalk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk14 : TriggerState {
            internal StateLaozNKahnTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozNKahnTalk15(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk15 : TriggerState {
            internal StateLaozNKahnTalk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6105}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__26$", arg4: 7);
                context.CameraSelect(triggerId: 621, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateLaozNKahnTalk16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk16 : TriggerState {
            internal StateLaozNKahnTalk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                return new StateLaozNKahnTalk17(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk17 : TriggerState {
            internal StateLaozNKahnTalk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6106}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__27$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Event_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLaozNKahnTalk18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk18_CSkip : TriggerState {
            internal StateLaozNKahnTalk18_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102, 202, 302, 110, 210});
                context.CreateMonster(spawnIds: new []{103, 203, 303}, arg2: false);
                context.MoveUser(mapId: 63000029, portalId: 12, boxId: 9900);
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk18 : TriggerState {
            internal StateLaozNKahnTalk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateBattleReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleReady01 : TriggerState {
            internal StateBattleReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 630, enable: true);
                context.MoveUser(mapId: 63000029, portalId: 12, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{103, 203, 303, 401});
                context.CreateMonster(spawnIds: new []{105, 205, 305, 403}, arg2: false);
                context.DestroyMonster(spawnIds: new []{900, 901, 902, 903, 904, 905, 906, 907, 908, 909, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931, 940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959});
                context.CreateMonster(spawnIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleReady02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 205, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 305, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 403, sequenceName: "Attack_Idle_A", duration: 15000f);
            }
        }

        private class StateBattleReady02 : TriggerState {
            internal StateBattleReady02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 631, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLaozKillAll01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozKillAll01 : TriggerState {
            internal StateLaozKillAll01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 305, patrolName: "MS2PatrolData_303");
                context.SetConversation(type: 1, spawnId: 305, script: "$63000029_CS__CAVE01__28$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLaozKillAll02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozKillAll02 : TriggerState {
            internal StateLaozKillAll02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5921}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 305, sequenceName: "Attack_01_D");
                context.CameraSelect(triggerId: 632, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateLaozKillAll03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozKillAll03 : TriggerState {
            internal StateLaozKillAll03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.SetSkill(triggerIds: new []{7002}, arg2: true);
                context.SetEffect(triggerIds: new []{5920}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateLaozSplitGround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozSplitGround01 : TriggerState {
            internal StateLaozSplitGround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 305, sequenceName: "Attack_01_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLaozSplitGround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozSplitGround02 : TriggerState {
            internal StateLaozSplitGround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5922}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLaozSplitGround03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozSplitGround03 : TriggerState {
            internal StateLaozSplitGround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5901}, visible: false);
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.SetMesh(triggerIds: new []{3002, 3003, 3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335}, visible: false, meshCount: 36, arg4: 0, delay: 25);
                context.SetRandomMesh(triggerIds: new []{3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, visible: false, meshCount: 17, arg4: 0, delay: 25);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLaozSplitGround04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozSplitGround04 : TriggerState {
            internal StateLaozSplitGround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLeftBehind00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind00 : TriggerState {
            internal StateLeftBehind00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 633, enable: true);
                context.SetSceneSkip(state: new StateEarthquake_CSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLeftBehind01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind01 : TriggerState {
            internal StateLeftBehind01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6008}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__29$", arg4: 8);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateLeftBehind02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind02 : TriggerState {
            internal StateLeftBehind02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLeftBehind03(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind03 : TriggerState {
            internal StateLeftBehind03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6200}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000029_CS__CAVE01__30$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLeftBehind04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind04 : TriggerState {
            internal StateLeftBehind04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLeftBehind05(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind05 : TriggerState {
            internal StateLeftBehind05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6009}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__31$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLeftBehind06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind06 : TriggerState {
            internal StateLeftBehind06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 303, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLeftBehind07(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind07 : TriggerState {
            internal StateLeftBehind07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6300}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000029_CS__CAVE01__32$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLeftBehind08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind08 : TriggerState {
            internal StateLeftBehind08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLeftBehind09(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind09 : TriggerState {
            internal StateLeftBehind09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 634, enable: true);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Event_A");
                context.SetEffect(triggerIds: new []{6107}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$63000029_CS__CAVE01__33$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLeftBehind10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind10 : TriggerState {
            internal StateLeftBehind10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLeftBehind11(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind11 : TriggerState {
            internal StateLeftBehind11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 635, enable: true);
                context.SetEffect(triggerIds: new []{6010}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001556, script: "$63000029_CS__CAVE01__34$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLeftBehind12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind12 : TriggerState {
            internal StateLeftBehind12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLaozVersusKahnAttack01(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozVersusKahnAttack01 : TriggerState {
            internal StateLaozVersusKahnAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 305, patrolName: "MS2PatrolData_304");
                context.MoveNpc(spawnId: 403, patrolName: "MS2PatrolData_403");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new StateLaozVersusKahnAttack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozVersusKahnAttack02 : TriggerState {
            internal StateLaozVersusKahnAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateLaozVersusKahnAttack03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozVersusKahnAttack03 : TriggerState {
            internal StateLaozVersusKahnAttack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 651, enable: true);
                context.SetEffect(triggerIds: new []{5820}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 305, sequenceName: "Bore_B", duration: 15000f);
                context.SetNpcEmotionLoop(spawnId: 403, sequenceName: "Attack_02_F", duration: 15000f);
                context.SetEffect(triggerIds: new []{5930}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateLaozVersusKahnCrash01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozVersusKahnCrash01 : TriggerState {
            internal StateLaozVersusKahnCrash01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5600}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLaozVersusKahnCrash02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozVersusKahnCrash02 : TriggerState {
            internal StateLaozVersusKahnCrash02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 650, enable: true);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapaseStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseStart01 : TriggerState {
            internal StateCollapaseStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5800}, visible: true);
                context.SetMesh(triggerIds: new []{3505}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3509}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapaseStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseStart02 : TriggerState {
            internal StateCollapaseStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3504}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3501}, visible: false, arg3: 50, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3507}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5931}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapaseStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseStart03 : TriggerState {
            internal StateCollapaseStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5821}, visible: true);
                context.SetMesh(triggerIds: new []{3502}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3508}, visible: false, arg3: 50, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3506}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapaseStart04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseStart04 : TriggerState {
            internal StateCollapaseStart04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3503}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapaseAbove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseAbove01 : TriggerState {
            internal StateCollapaseAbove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7003}, arg2: true);
                context.SetEffect(triggerIds: new []{5801}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCollapaseGround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseGround01 : TriggerState {
            internal StateCollapaseGround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{305, 403});
                context.SetBreakable(triggerIds: new []{4000, 4001}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateCollapaseGround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseGround02 : TriggerState {
            internal StateCollapaseGround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(triggerIds: new []{5820, 5821}, visible: false);
                context.SetSkill(triggerIds: new []{7000}, arg2: true);
                context.SetEffect(triggerIds: new []{6300}, visible: true);
                context.SetConversation(type: 1, spawnId: 105, script: "$63000029_CS__CAVE01__35$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCollapaseGround03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapaseGround03 : TriggerState {
            internal StateCollapaseGround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000, 4001}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEarthquake01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake_CSkip : TriggerState {
            internal StateEarthquake_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7003}, arg2: true);
                context.SetEffect(triggerIds: new []{5801}, visible: true);
                context.SetBreakable(triggerIds: new []{4000, 4001}, enabled: true);
                context.SetEffect(triggerIds: new []{5820, 5821}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEarthquake_CSkip2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake_CSkip2 : TriggerState {
            internal StateEarthquake_CSkip2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7000}, arg2: true);
                context.SetEffect(triggerIds: new []{6300}, visible: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001}, arg2: true);
                context.SetConversation(type: 1, spawnId: 105, script: "$63000029_CS__CAVE01__35$", arg4: 3, arg5: 0);
                context.DestroyMonster(spawnIds: new []{305, 403});
                context.SetBreakable(triggerIds: new []{4000, 4001}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEarthquake01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake01 : TriggerState {
            internal StateEarthquake01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 660, enable: true);
                context.SetUserValue(triggerId: 2, key: "EarthquakeStart", value: 1);
                context.SetConversation(type: 1, spawnId: 105, script: "$63000029_CS__CAVE01__39$", arg4: 4, arg5: 2);
                context.SetConversation(type: 1, spawnId: 205, script: "$63000029_CS__CAVE01__40$", arg4: 3, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEarthquake02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake02 : TriggerState {
            internal StateEarthquake02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 640, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEarthquake03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake03 : TriggerState {
            internal StateEarthquake03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_105");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEarthquake04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake04 : TriggerState {
            internal StateEarthquake04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_205");
                context.SetEffect(triggerIds: new []{6301}, visible: true);
                context.SetConversation(type: 1, spawnId: 105, script: "$63000029_CS__CAVE01__36$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEarthquake05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEarthquake05 : TriggerState {
            internal StateEarthquake05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Idle_A");
                context.SetEffect(triggerIds: new []{6201}, visible: true);
                context.SetConversation(type: 1, spawnId: 205, script: "$63000029_CS__CAVE01__37$", arg4: 4, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Idle_A");
            }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 641, enable: true);
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_203");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTimeToLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave02 : TriggerState {
            internal StateTimeToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_103");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTimeToLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave03 : TriggerState {
            internal StateTimeToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 641, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGuideNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10036040, textId: 10036040);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9004})) {
                    return new StateGuideNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5900}, visible: true);
                context.SetConversation(type: 1, spawnId: 205, script: "$63000029_CS__CAVE01__38$", arg4: 3);
                context.HideGuideSummary(entityId: 10036040);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateOpenTheStoneGate01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpenTheStoneGate01 : TriggerState {
            internal StateOpenTheStoneGate01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "or_fi_struc_stonegate_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateOpenTheStoneGate02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpenTheStoneGate02 : TriggerState {
            internal StateOpenTheStoneGate02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 1060, textId: 1060);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMoveToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap02 : TriggerState {
            internal StateMoveToNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_104");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateMoveToNextMap03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap03 : TriggerState {
            internal StateMoveToNextMap03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateMoveToNextMap04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap04 : TriggerState {
            internal StateMoveToNextMap04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{205});
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 1060);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
