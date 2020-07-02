namespace Maple2.Trigger._63000028_cs {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetEffect(arg1: new[] {5000, 5100, 6000, 6001, 6002, 6003, 6004, 6100, 6101, 6102}, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005}, arg2: true);
                context.SetAgent(arg1: new[] {8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114, 8115}, arg2: false);
                context.SetSkill(arg1: new[] {7000}, arg2: false);
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000452}, arg3: new byte[] {1})) {
                    return new StateQuestOnGoing21(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000451}, arg3: new byte[] {3})) {
                    return new StateQuestOnGoing11(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000451}, arg3: new byte[] {2})) {
                    return new StateQuestOnGoing01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000451}, arg3: new byte[] {1})) {
                    return new StatePCWakeUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing11 : TriggerState {
            internal StateQuestOnGoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing21 : TriggerState {
            internal StateQuestOnGoing21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateQuestOnGoing22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing22 : TriggerState {
            internal StateQuestOnGoing22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000028, arg2: 11, arg3: 9900);
                context.CreateMonster(arg1: new[] {104, 203}, arg2: false);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateQuestOnGoing23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing23 : TriggerState {
            internal StateQuestOnGoing23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateShadowWaveAgain02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWakeUp01 : TriggerState {
            internal StatePCWakeUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCWakeUp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWakeUp02 : TriggerState {
            internal StatePCWakeUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetSceneSkip(arg1: "TinChaiTalk02_CSkip", arg2: "nextState");
                context.CreateMonster(arg1: new[] {101, 900, 901, 902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCWakeUp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWakeUp03 : TriggerState {
            internal StatePCWakeUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePCWakeUp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWakeUp04 : TriggerState {
            internal StatePCWakeUp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Bore_C");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000028_CS__BATTLE01__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StatePCWakeUp05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCWakeUp05 : TriggerState {
            internal StatePCWakeUp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000028_CS__BATTLE01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleING01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleING01 : TriggerState {
            internal StateBattleING01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleING02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleING02 : TriggerState {
            internal StateBattleING02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTinChaiTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000028_CS__BATTLE01__2$", arg4: 5);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTinChaiTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02 : TriggerState {
            internal StateTinChaiTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateReadyToBattle01(context);
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02_CSkip : TriggerState {
            internal StateTinChaiTalk02_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateReadyToBattle01(context);
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle01 : TriggerState {
            internal StateReadyToBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005}, arg2: false);
                context.CameraSelect(arg1: 501, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateReadyToBattle02(context);
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle02 : TriggerState {
            internal StateReadyToBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10035010, textId: 10035010);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10035020);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900, 901, 902})) {
                    return new StateBattleEnd01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10035010);
            }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {900, 901, 902});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd02 : TriggerState {
            internal StateBattleEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd03 : TriggerState {
            internal StateBattleEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000028, arg2: 10, arg3: 9900);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleEnd04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd04 : TriggerState {
            internal StateBattleEnd04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "MeetJunta05_Cskip", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleEnd05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd05 : TriggerState {
            internal StateBattleEnd05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000028_CS__BATTLE01__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateShadowWave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave01 : TriggerState {
            internal StateShadowWave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAgent(arg1: new[] {8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowWave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave02 : TriggerState {
            internal StateShadowWave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetEffect(arg1: new[] {5100}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowWave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave03 : TriggerState {
            internal StateShadowWave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {910, 911, 912, 913});
                context.MoveNpc(arg1: 910, arg2: "MS2PatrolData_910");
                context.MoveNpc(arg1: 911, arg2: "MS2PatrolData_911");
                context.MoveNpc(arg1: 912, arg2: "MS2PatrolData_912");
                context.MoveNpc(arg1: 913, arg2: "MS2PatrolData_913");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowWave04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave04 : TriggerState {
            internal StateShadowWave04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {920, 921, 922, 923, 924});
                context.MoveNpc(arg1: 920, arg2: "MS2PatrolData_920");
                context.MoveNpc(arg1: 921, arg2: "MS2PatrolData_921");
                context.MoveNpc(arg1: 922, arg2: "MS2PatrolData_922");
                context.MoveNpc(arg1: 923, arg2: "MS2PatrolData_923");
                context.MoveNpc(arg1: 924, arg2: "MS2PatrolData_924");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowWave05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave05 : TriggerState {
            internal StateShadowWave05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_101");
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowWave06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave06 : TriggerState {
            internal StateShadowWave06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {930, 931, 932, 933, 950, 951, 952, 953});
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_930");
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_931");
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_932");
                context.MoveNpc(arg1: 933, arg2: "MS2PatrolData_933");
                context.MoveNpc(arg1: 950, arg2: "MS2PatrolData_950");
                context.MoveNpc(arg1: 951, arg2: "MS2PatrolData_951");
                context.MoveNpc(arg1: 952, arg2: "MS2PatrolData_952");
                context.MoveNpc(arg1: 953, arg2: "MS2PatrolData_953");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowWave07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWave07 : TriggerState {
            internal StateShadowWave07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000028_CS__BATTLE01__4$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {940, 941, 942, 943, 944, 945, 960, 961, 962, 963, 964, 965});
                context.MoveNpc(arg1: 940, arg2: "MS2PatrolData_940");
                context.MoveNpc(arg1: 941, arg2: "MS2PatrolData_941");
                context.MoveNpc(arg1: 942, arg2: "MS2PatrolData_942");
                context.MoveNpc(arg1: 943, arg2: "MS2PatrolData_943");
                context.MoveNpc(arg1: 944, arg2: "MS2PatrolData_944");
                context.MoveNpc(arg1: 945, arg2: "MS2PatrolData_945");
                context.MoveNpc(arg1: 960, arg2: "MS2PatrolData_960");
                context.MoveNpc(arg1: 961, arg2: "MS2PatrolData_961");
                context.MoveNpc(arg1: 962, arg2: "MS2PatrolData_962");
                context.MoveNpc(arg1: 963, arg2: "MS2PatrolData_963");
                context.MoveNpc(arg1: 964, arg2: "MS2PatrolData_964");
                context.MoveNpc(arg1: 965, arg2: "MS2PatrolData_965");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTinChaiDesperate01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiDesperate01 : TriggerState {
            internal StateTinChaiDesperate01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: true);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_Idle_A", arg3: 12000f);
                context.SetPcEmotionLoop(arg1: "Orb_Attack_Idle_A", arg2: 12000f);
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000028_CS__BATTLE01__5$", arg4: 5);
                context.SetSkip(arg1: "TinChaiDesperate02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTinChaiDesperate02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiDesperate02 : TriggerState {
            internal StateTinChaiDesperate02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJuntaApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaApp01 : TriggerState {
            internal StateJuntaApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJuntaApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaApp02 : TriggerState {
            internal StateJuntaApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 700, arg2: true);
                context.DestroyMonster(arg1: new[] {910, 911, 912, 913, 920, 921, 922, 923, 924, 930, 931, 932, 933, 940, 941, 942, 943, 944, 945, 950, 951, 952, 953, 960, 961, 962, 963, 964, 965});
                context.CreateMonster(arg1: new[] {970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJuntaApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaApp03 : TriggerState {
            internal StateJuntaApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAgent(arg1: new[] {8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJuntaApp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaApp04 : TriggerState {
            internal StateJuntaApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateJuntaTalk01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetSkill(arg1: new[] {7000}, arg2: true);
            }
        }

        private class StateJuntaTalk01 : TriggerState {
            internal StateJuntaTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.SetEffect(arg1: new[] {6100}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000028_CS__BATTLE01__6$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMeetJunta01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta01 : TriggerState {
            internal StateMeetJunta01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998});
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMeetJunta02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateMeetJunta02 : TriggerState {
            internal StateMeetJunta02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: true);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000028_CS__BATTLE01__7$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMeetJunta03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta03 : TriggerState {
            internal StateMeetJunta03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                return new StateMeetJunta04(context);
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta04 : TriggerState {
            internal StateMeetJunta04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000028_CS__BATTLE01__8$", arg4: 7);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateMeetJunta05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta05_Cskip : TriggerState {
            internal StateMeetJunta05_Cskip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: true);
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.DestroyMonster(arg1: new[] {910, 911, 912, 913, 920, 921, 922, 923, 924, 930, 931, 932, 933, 940, 941, 942, 943, 944, 945, 950, 951, 952, 953, 960, 961, 962, 963, 964, 965});
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMeetJunta05_Cskip2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta05_Cskip2 : TriggerState {
            internal StateMeetJunta05_Cskip2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 102, 201});
                context.CreateMonster(arg1: new[] {103, 202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMeetJunta06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateMeetJunta05 : TriggerState {
            internal StateMeetJunta05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {102, 201});
                context.CreateMonster(arg1: new[] {103, 202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMeetJunta06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta06 : TriggerState {
            internal StateMeetJunta06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "complete_airstrikeofjunta");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000451}, arg3: new byte[] {2})) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031010, textId: 10031010);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000451}, arg3: new byte[] {3})) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031010);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000452}, arg3: new byte[] {1})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031020);
            }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowWaveAgain01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWaveAgain01 : TriggerState {
            internal StateShadowWaveAgain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000028, arg2: 12, arg3: 9900);
                context.DestroyMonster(arg1: new[] {103, 202});
                context.CreateMonster(arg1: new[] {104, 203}, arg2: false);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSceneSkip(arg1: "TimeToLeave05", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowWaveAgain02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWaveAgain02 : TriggerState {
            internal StateShadowWaveAgain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAgent(arg1: new[] {8100, 8101, 8102, 8103, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114, 8115}, arg2: true);
                context.CreateMonster(arg1: new[] {910, 911, 912, 913});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowWaveAgain03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWaveAgain03 : TriggerState {
            internal StateShadowWaveAgain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetEffect(arg1: new[] {5100, 6003}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$63000028_CS__BATTLE01__9$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_103");
                context.MoveUserPath(arg1: "MS2PatrolData_1004");
                context.CreateMonster(arg1: new[] {920, 921, 922, 923, 924});
                context.MoveNpc(arg1: 910, arg2: "MS2PatrolData_910");
                context.MoveNpc(arg1: 911, arg2: "MS2PatrolData_911");
                context.MoveNpc(arg1: 912, arg2: "MS2PatrolData_912");
                context.MoveNpc(arg1: 913, arg2: "MS2PatrolData_913");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowWaveAgain04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWaveAgain04 : TriggerState {
            internal StateShadowWaveAgain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 920, arg2: "MS2PatrolData_920");
                context.MoveNpc(arg1: 921, arg2: "MS2PatrolData_921");
                context.MoveNpc(arg1: 922, arg2: "MS2PatrolData_922");
                context.MoveNpc(arg1: 923, arg2: "MS2PatrolData_923");
                context.MoveNpc(arg1: 924, arg2: "MS2PatrolData_924");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateShadowWaveAgain05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWaveAgain05 : TriggerState {
            internal StateShadowWaveAgain05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000028_CS__BATTLE01__10$", arg4: 4);
                context.CreateMonster(arg1: new[] {930, 931, 932, 933, 950, 951, 952, 953});
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_930");
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_931");
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_932");
                context.MoveNpc(arg1: 933, arg2: "MS2PatrolData_933");
                context.MoveNpc(arg1: 950, arg2: "MS2PatrolData_950");
                context.MoveNpc(arg1: 951, arg2: "MS2PatrolData_951");
                context.MoveNpc(arg1: 952, arg2: "MS2PatrolData_952");
                context.MoveNpc(arg1: 953, arg2: "MS2PatrolData_953");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowWaveAgain06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowWaveAgain06 : TriggerState {
            internal StateShadowWaveAgain06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {940, 941, 942, 943, 944, 945, 960, 961, 962, 963, 964, 965});
                context.MoveNpc(arg1: 940, arg2: "MS2PatrolData_940");
                context.MoveNpc(arg1: 941, arg2: "MS2PatrolData_941");
                context.MoveNpc(arg1: 942, arg2: "MS2PatrolData_942");
                context.MoveNpc(arg1: 943, arg2: "MS2PatrolData_943");
                context.MoveNpc(arg1: 944, arg2: "MS2PatrolData_944");
                context.MoveNpc(arg1: 945, arg2: "MS2PatrolData_945");
                context.MoveNpc(arg1: 960, arg2: "MS2PatrolData_960");
                context.MoveNpc(arg1: 961, arg2: "MS2PatrolData_961");
                context.MoveNpc(arg1: 962, arg2: "MS2PatrolData_962");
                context.MoveNpc(arg1: 963, arg2: "MS2PatrolData_963");
                context.MoveNpc(arg1: 964, arg2: "MS2PatrolData_964");
                context.MoveNpc(arg1: 965, arg2: "MS2PatrolData_965");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: true);
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000028_CS__BATTLE01__11$", arg4: 4);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTimeToLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave02 : TriggerState {
            internal StateTimeToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateTimeToLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave03 : TriggerState {
            internal StateTimeToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTimeToLeave04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave04 : TriggerState {
            internal StateTimeToLeave04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1005");
                context.CameraSelect(arg1: 602, arg2: false);
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateTimeToLeave05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave05 : TriggerState {
            internal StateTimeToLeave05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104, 203});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new StatePCTeleport01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 63000029, arg2: 1, arg3: 9900);
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

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}