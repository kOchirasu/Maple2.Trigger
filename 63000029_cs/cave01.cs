namespace Maple2.Trigger._63000029_cs {
    public static class _cave01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5100, 5200, 5201, 5202, 5203, 5300, 5400, 5500, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5600, 5800, 5801, 5820, 5821, 5900, 5901, 5920, 5921, 5922, 5930, 5931, 6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6200, 6201, 6300, 6301, 6400}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4500, arg2: true, arg3: "or_fi_struc_stonegate_A01_off");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 201}, arg2: false);
                context.SetSkill(arg1: new[] {7000, 7001, 7002, 7003, 7100, 7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109}, arg2: false);
                context.SetBreakable(arg1: new[] {4000, 4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000453}, arg3: new byte[] {3})) {
                    return new StateQuestOnGiong11(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000453}, arg3: new byte[] {2})) {
                    return new StateQuestOnGiong01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000453}, arg3: new byte[] {1})) {
                    return new StateLiftRock01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000452}, arg3: new byte[] {3})) {
                    return new StateSecondQuestStart01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000452}, arg3: new byte[] {2})) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong11 : TriggerState {
            internal StateQuestOnGiong11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000029, arg2: 30, arg3: 9900);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {110, 210, 302}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: true, arg3: 9, arg4: 0, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000029, arg2: 20, arg3: 9900);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {102, 202}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: true, arg3: 9, arg4: 0, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000029_CS__CAVE01__0$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_201");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10030100, textId: 10030100);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000452}, arg3: new byte[] {3})) {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000453}, arg3: new byte[] {1})) {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10036010, textId: 10036010);
                context.SetEffect(arg1: new[] {5300, 5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9001}, itemId: 30000441)) {
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
                context.SetEffect(arg1: new[] {5300}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10036011, textId: 10036011);
                context.SetEffect(arg1: new[] {5100, 5200, 5201, 5202, 5203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9002}, itemId: 30000441)) {
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
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5100, 5200, 5201, 5202, 5203}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000029, arg2: 10, arg3: 9900);
                context.CameraSelect(arg1: 500, arg2: true);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {102, 202}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: true, arg3: 9, arg4: 100, arg5: 100);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 500, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$63000029_CS__CAVE01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000029_CS__CAVE01__2$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_201");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
                context.SetEffect(arg1: new[] {6400}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$63000029_CS__CAVE01__3$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000029_CS__CAVE01__4$", arg4: 2, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$63000029_CS__CAVE01__5$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000029_CS__CAVE01__6$", arg4: 3, arg5: 2);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000029, arg2: 10, arg3: 9900);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_201");
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__7$", arg4: 5);
                context.SetSkip(state: new StateLaozTalk04(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateLaozTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalk03 : TriggerState {
            internal StateLaozTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__8$", arg4: 4);
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {301});
                context.CreateMonster(arg1: new[] {302}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 601, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10036020, textId: 10036020);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
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
                context.SetEffect(arg1: new[] {5002, 5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10036030, textId: 10036030);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000453}, arg3: new byte[] {3})) {
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

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5004}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetSceneSkip(state: new StateLaozNKahnTalk18_CSkip(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000029, arg2: 11, arg3: 9900);
                context.CameraSelect(arg1: 610, arg2: true);
                context.DestroyMonster(arg1: new[] {102, 202, 302, 110, 210});
                context.CreateMonster(arg1: new[] {103, 203, 303}, arg2: false);
                context.SetRandomMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: false, arg3: 9, arg4: 100, arg5: 100);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {5400}, arg2: true);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.CreateMonster(arg1: new[] {401}, arg2: false);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_401");
                context.SetEffect(arg1: new[] {5500, 5501, 5502, 5503, 5504, 5505, 5506, 5507}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5901, 6100}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$63000029_CS__CAVE01__9$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {900, 901, 902, 903}, arg2: false);
                context.MoveNpc(arg1: 900, arg2: "MS2PatrolData_900");
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_901");
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_902");
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_903");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {904, 905, 906}, arg2: false);
                context.MoveNpc(arg1: 904, arg2: "MS2PatrolData_904");
                context.MoveNpc(arg1: 905, arg2: "MS2PatrolData_905");
                context.MoveNpc(arg1: 906, arg2: "MS2PatrolData_906");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {907, 908, 909}, arg2: false);
                context.MoveNpc(arg1: 907, arg2: "MS2PatrolData_907");
                context.MoveNpc(arg1: 908, arg2: "MS2PatrolData_908");
                context.MoveNpc(arg1: 909, arg2: "MS2PatrolData_909");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {940, 941, 942, 943}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 611, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_302");
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$63000029_CS__CAVE01__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_202");
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$63000029_CS__CAVE01__11$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_102");
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000029_CS__CAVE01__12$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Attack_Idle_A", arg3: 90000f);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Attack_Idle_A", arg3: 90000f);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__13$", arg4: 9);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Event_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateMeetKahn03(context);
            }

            public override void OnExit() { }
        }

        private class StateMeetKahn03 : TriggerState {
            internal StateMeetKahn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__14$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 620, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateLaozTalkToJuntaNTinChai01(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai01 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__15$", arg4: 8);
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLaozTalkToJuntaNTinChai03(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai03 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000029_CS__CAVE01__16$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLaozTalkToJuntaNTinChai05(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai05 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000029_CS__CAVE01__17$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLaozTalkToJuntaNTinChai07(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozTalkToJuntaNTinChai07 : TriggerState {
            internal StateLaozTalkToJuntaNTinChai07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__18$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 611, arg2: true);
                context.CreateMonster(arg1: new[] {945, 946}, arg2: false);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_402");
                context.MoveNpc(arg1: 900, arg2: "MS2PatrolData_910");
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_911");
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_912");
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_913");
                context.MoveNpc(arg1: 904, arg2: "MS2PatrolData_914");
                context.MoveNpc(arg1: 905, arg2: "MS2PatrolData_915");
                context.MoveNpc(arg1: 906, arg2: "MS2PatrolData_916");
                context.MoveNpc(arg1: 907, arg2: "MS2PatrolData_917");
                context.MoveNpc(arg1: 908, arg2: "MS2PatrolData_918");
                context.MoveNpc(arg1: 909, arg2: "MS2PatrolData_919");
                context.MoveNpc(arg1: 920, arg2: "MS2PatrolData_920");
                context.MoveNpc(arg1: 921, arg2: "MS2PatrolData_921");
                context.MoveNpc(arg1: 922, arg2: "MS2PatrolData_922");
                context.MoveNpc(arg1: 923, arg2: "MS2PatrolData_923");
                context.MoveNpc(arg1: 924, arg2: "MS2PatrolData_924");
                context.MoveNpc(arg1: 925, arg2: "MS2PatrolData_925");
                context.MoveNpc(arg1: 926, arg2: "MS2PatrolData_926");
                context.MoveNpc(arg1: 927, arg2: "MS2PatrolData_927");
                context.MoveNpc(arg1: 928, arg2: "MS2PatrolData_928");
                context.MoveNpc(arg1: 929, arg2: "MS2PatrolData_929");
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_930");
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_931");
                context.MoveNpc(arg1: 940, arg2: "MS2PatrolData_940");
                context.MoveNpc(arg1: 941, arg2: "MS2PatrolData_941");
                context.MoveNpc(arg1: 942, arg2: "MS2PatrolData_942");
                context.MoveNpc(arg1: 943, arg2: "MS2PatrolData_943");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {947, 948, 949}, arg2: false);
                context.MoveNpc(arg1: 945, arg2: "MS2PatrolData_945");
                context.MoveNpc(arg1: 946, arg2: "MS2PatrolData_946");
                context.CreateMonster(arg1: new[] {950, 951, 952, 953, 954, 955, 956, 957, 958, 959}, arg2: false);
                context.MoveNpc(arg1: 950, arg2: "MS2PatrolData_900");
                context.MoveNpc(arg1: 951, arg2: "MS2PatrolData_901");
                context.MoveNpc(arg1: 952, arg2: "MS2PatrolData_902");
                context.MoveNpc(arg1: 953, arg2: "MS2PatrolData_903");
                context.MoveNpc(arg1: 954, arg2: "MS2PatrolData_904");
                context.MoveNpc(arg1: 955, arg2: "MS2PatrolData_905");
                context.MoveNpc(arg1: 956, arg2: "MS2PatrolData_906");
                context.MoveNpc(arg1: 957, arg2: "MS2PatrolData_907");
                context.MoveNpc(arg1: 958, arg2: "MS2PatrolData_908");
                context.MoveNpc(arg1: 959, arg2: "MS2PatrolData_909");
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__19$", arg4: 9);
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
                context.CameraSelect(arg1: 612, arg2: true);
                context.SetSkip(state: new StateLaozNKahnTalk02(context));
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateLaozNKahnTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk03 : TriggerState {
            internal StateLaozNKahnTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Event_A");
                context.SetEffect(arg1: new[] {6102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__20$", arg4: 9);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLaozNKahnTalk05(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk05 : TriggerState {
            internal StateLaozNKahnTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Event_A");
                context.SetEffect(arg1: new[] {6103}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__21$", arg4: 6);
                context.SetSkip(state: new StateLaozNKahnTalk06(context));
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6005}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__22$", arg4: 7);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6006}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__23$", arg4: 7);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Event_A");
                context.SetEffect(arg1: new[] {6104}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__24$", arg4: 7);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6007}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__25$", arg4: 8);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLaozNKahnTalk15(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk15 : TriggerState {
            internal StateLaozNKahnTalk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6105}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__26$", arg4: 7);
                context.CameraSelect(arg1: 621, arg2: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateLaozNKahnTalk17(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozNKahnTalk17 : TriggerState {
            internal StateLaozNKahnTalk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6106}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__27$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Event_A");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {102, 202, 302, 110, 210});
                context.CreateMonster(arg1: new[] {103, 203, 303}, arg2: false);
                context.MoveUser(arg1: 63000029, arg2: 12, arg3: 9900);
                context.RemoveCinematicTalk();
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 630, arg2: true);
                context.MoveUser(arg1: 63000029, arg2: 12, arg3: 9900);
                context.DestroyMonster(arg1: new[] {103, 203, 303, 401});
                context.CreateMonster(arg1: new[] {105, 205, 305, 403}, arg2: false);
                context.DestroyMonster(arg1: new[] {900, 901, 902, 903, 904, 905, 906, 907, 908, 909, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931, 940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959});
                context.CreateMonster(arg1: new[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleReady02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 205, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 305, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 403, arg2: "Attack_Idle_A", arg3: 15000f);
            }
        }

        private class StateBattleReady02 : TriggerState {
            internal StateBattleReady02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 631, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_303");
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$63000029_CS__CAVE01__28$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5921}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 305, arg2: "Attack_01_D");
                context.CameraSelect(arg1: 632, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5005}, arg2: true);
                context.SetSkill(arg1: new[] {7002}, arg2: true);
                context.SetEffect(arg1: new[] {5920}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 305, arg2: "Attack_01_B");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5922}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5901}, arg2: false);
                context.SetEffect(arg1: new[] {5005}, arg2: true);
                context.SetMesh(arg1: new[] {3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335}, arg2: false, arg3: 36, arg4: 0, arg5: 25);
                context.SetRandomMesh(arg1: new[] {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416}, arg2: false, arg3: 17, arg4: 0, arg5: 25);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 633, arg2: true);
                context.SetSceneSkip(state: new StateEarthquake_CSkip(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6008}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__29$", arg4: 8);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLeftBehind03(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind03 : TriggerState {
            internal StateLeftBehind03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6200}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000029_CS__CAVE01__30$", arg4: 6);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLeftBehind05(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind05 : TriggerState {
            internal StateLeftBehind05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6009}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__31$", arg4: 7);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 303, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLeftBehind07(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind07 : TriggerState {
            internal StateLeftBehind07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6300}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000029_CS__CAVE01__32$", arg4: 4);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateLeftBehind09(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind09 : TriggerState {
            internal StateLeftBehind09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 634, arg2: true);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Event_A");
                context.SetEffect(arg1: new[] {6107}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000029_CS__CAVE01__33$", arg4: 6);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLeftBehind11(context);
            }

            public override void OnExit() { }
        }

        private class StateLeftBehind11 : TriggerState {
            internal StateLeftBehind11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 635, arg2: true);
                context.SetEffect(arg1: new[] {6010}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001556, arg3: "$63000029_CS__CAVE01__34$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateLaozVersusKahnAttack01(context);
            }

            public override void OnExit() { }
        }

        private class StateLaozVersusKahnAttack01 : TriggerState {
            internal StateLaozVersusKahnAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_304");
                context.MoveNpc(arg1: 403, arg2: "MS2PatrolData_403");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 651, arg2: true);
                context.SetEffect(arg1: new[] {5820}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 305, arg2: "Bore_B", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 403, arg2: "Attack_02_F", arg3: 15000f);
                context.SetEffect(arg1: new[] {5930}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {5600}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 650, arg2: true);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5800}, arg2: true);
                context.SetMesh(arg1: new[] {3505}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3509}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {3504}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3501}, arg2: false, arg3: 50, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3507}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5931}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5821}, arg2: true);
                context.SetMesh(arg1: new[] {3502}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3508}, arg2: false, arg3: 50, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3506}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {3503}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetEffect(arg1: new[] {5801}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {305, 403});
                context.SetBreakable(arg1: new[] {4000, 4001}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5820, 5821}, arg2: false);
                context.SetSkill(arg1: new[] {7000}, arg2: true);
                context.SetEffect(arg1: new[] {6300}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$63000029_CS__CAVE01__35$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetBreakable(arg1: new[] {4000, 4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetEffect(arg1: new[] {5801}, arg2: true);
                context.SetBreakable(arg1: new[] {4000, 4001}, arg2: true);
                context.SetEffect(arg1: new[] {5820, 5821}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetSkill(arg1: new[] {7000}, arg2: true);
                context.SetEffect(arg1: new[] {6300}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$63000029_CS__CAVE01__35$", arg4: 3, arg5: 0);
                context.DestroyMonster(arg1: new[] {305, 403});
                context.SetBreakable(arg1: new[] {4000, 4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 660, arg2: true);
                context.SetUserValue(triggerId: 2, key: "EarthquakeStart", value: 1);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$63000029_CS__CAVE01__39$", arg4: 4, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$63000029_CS__CAVE01__40$", arg4: 3, arg5: 4);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 640, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_105");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_205");
                context.SetEffect(arg1: new[] {6301}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$63000029_CS__CAVE01__36$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Idle_A");
                context.SetEffect(arg1: new[] {6201}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$63000029_CS__CAVE01__37$", arg4: 4, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Idle_A");
            }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 641, arg2: true);
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_203");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_103");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 641, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10036040, textId: 10036040);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9004})) {
                    return new StateGuideNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5900}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$63000029_CS__CAVE01__38$", arg4: 3);
                context.HideGuideSummary(entityId: 10036040);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 4500, arg2: true, arg3: "or_fi_struc_stonegate_A01_on");
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 1060, textId: 1060);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_204");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_104");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {105});
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {205});
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}