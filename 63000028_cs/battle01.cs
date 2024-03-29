using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000028_cs {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.Guide);
                context.SetEffect(triggerIds: new []{5000, 5100, 6000, 6001, 6002, 6003, 6004, 6100, 6101, 6102}, visible: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005}, visible: true);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114, 8115}, visible: false);
                context.SetSkill(triggerIds: new []{7000}, enabled: false);
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000452}, questStates: new byte[]{1})) {
                    return new StateQuestOnGoing21(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000451}, questStates: new byte[]{3})) {
                    return new StateQuestOnGoing11(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000451}, questStates: new byte[]{2})) {
                    return new StateQuestOnGoing01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000451}, questStates: new byte[]{1})) {
                    return new StatePCWakeUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{103, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 63000028, portalId: 11, boxId: 9900);
                context.CreateMonster(spawnIds: new []{104, 203}, arg2: false);
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 500, enabled: true);
                context.SetSceneSkip(state: new StateTinChaiTalk02_CSkip(context), arg2: "nextState");
                context.CreateMonster(spawnIds: new []{101, 900, 901, 902}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionSequence(sequenceNames: new []{"Bore_C"});
                context.SetConversation(type: 1, spawnId: 0, script: "$63000028_CS__BATTLE01__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$63000028_CS__BATTLE01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 501, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000028_CS__BATTLE01__2$", arg4: 5);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateReadyToBattle01(context);
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02_CSkip : TriggerState {
            internal StateTinChaiTalk02_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateReadyToBattle01(context);
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle01 : TriggerState {
            internal StateReadyToBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005}, visible: false);
                context.CameraSelect(triggerId: 501, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateReadyToBattle02(context);
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle02 : TriggerState {
            internal StateReadyToBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10035010, textId: 10035010);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900, 901, 902})) {
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
                context.DestroyMonster(spawnIds: new []{900, 901, 902});
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 63000028, portalId: 10, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetSceneSkip(state: new StateMeetJunta05_Cskip(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 102, script: "$63000028_CS__BATTLE01__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 600, enabled: true);
                context.SetEffect(triggerIds: new []{5100}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{910, 911, 912, 913});
                context.MoveNpc(spawnId: 910, patrolName: "MS2PatrolData_910");
                context.MoveNpc(spawnId: 911, patrolName: "MS2PatrolData_911");
                context.MoveNpc(spawnId: 912, patrolName: "MS2PatrolData_912");
                context.MoveNpc(spawnId: 913, patrolName: "MS2PatrolData_913");
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{920, 921, 922, 923, 924});
                context.MoveNpc(spawnId: 920, patrolName: "MS2PatrolData_920");
                context.MoveNpc(spawnId: 921, patrolName: "MS2PatrolData_921");
                context.MoveNpc(spawnId: 922, patrolName: "MS2PatrolData_922");
                context.MoveNpc(spawnId: 923, patrolName: "MS2PatrolData_923");
                context.MoveNpc(spawnId: 924, patrolName: "MS2PatrolData_924");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 601, enabled: true);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_101");
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{930, 931, 932, 933, 950, 951, 952, 953});
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_930");
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_931");
                context.MoveNpc(spawnId: 932, patrolName: "MS2PatrolData_932");
                context.MoveNpc(spawnId: 933, patrolName: "MS2PatrolData_933");
                context.MoveNpc(spawnId: 950, patrolName: "MS2PatrolData_950");
                context.MoveNpc(spawnId: 951, patrolName: "MS2PatrolData_951");
                context.MoveNpc(spawnId: 952, patrolName: "MS2PatrolData_952");
                context.MoveNpc(spawnId: 953, patrolName: "MS2PatrolData_953");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 102, script: "$63000028_CS__BATTLE01__4$", arg4: 3, arg5: 0);
                context.CreateMonster(spawnIds: new []{940, 941, 942, 943, 944, 945, 960, 961, 962, 963, 964, 965});
                context.MoveNpc(spawnId: 940, patrolName: "MS2PatrolData_940");
                context.MoveNpc(spawnId: 941, patrolName: "MS2PatrolData_941");
                context.MoveNpc(spawnId: 942, patrolName: "MS2PatrolData_942");
                context.MoveNpc(spawnId: 943, patrolName: "MS2PatrolData_943");
                context.MoveNpc(spawnId: 944, patrolName: "MS2PatrolData_944");
                context.MoveNpc(spawnId: 945, patrolName: "MS2PatrolData_945");
                context.MoveNpc(spawnId: 960, patrolName: "MS2PatrolData_960");
                context.MoveNpc(spawnId: 961, patrolName: "MS2PatrolData_961");
                context.MoveNpc(spawnId: 962, patrolName: "MS2PatrolData_962");
                context.MoveNpc(spawnId: 963, patrolName: "MS2PatrolData_963");
                context.MoveNpc(spawnId: 964, patrolName: "MS2PatrolData_964");
                context.MoveNpc(spawnId: 965, patrolName: "MS2PatrolData_965");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 602, enabled: true);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Attack_Idle_A", duration: 12000f);
                context.SetPcEmotionLoop(sequenceName: "Orb_Attack_Idle_A", duration: 12000f);
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000028_CS__BATTLE01__5$", arg4: 5);
                context.SetSkip(state: new StateTinChaiDesperate02(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 700, enabled: true);
                context.DestroyMonster(spawnIds: new []{910, 911, 912, 913, 920, 921, 922, 923, 924, 930, 931, 932, 933, 940, 941, 942, 943, 944, 945, 950, 951, 952, 953, 960, 961, 962, 963, 964, 965});
                context.CreateMonster(spawnIds: new []{970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateJuntaTalk01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetSkill(triggerIds: new []{7000}, enabled: true);
            }
        }

        private class StateJuntaTalk01 : TriggerState {
            internal StateJuntaTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5100}, visible: false);
                context.SetEffect(triggerIds: new []{6100}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000028_CS__BATTLE01__6$", arg4: 4);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998});
                context.MoveUserPath(patrolName: "MS2PatrolData_1003");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_102");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 701, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000028_CS__BATTLE01__7$", arg4: 5);
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                return new StateMeetJunta04(context);
            }

            public override void OnExit() { }
        }

        private class StateMeetJunta04 : TriggerState {
            internal StateMeetJunta04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6101}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000028_CS__BATTLE01__8$", arg4: 7);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 701, enabled: true);
                context.SetEffect(triggerIds: new []{5100}, visible: false);
                context.DestroyMonster(spawnIds: new []{910, 911, 912, 913, 920, 921, 922, 923, 924, 930, 931, 932, 933, 940, 941, 942, 943, 944, 945, 950, 951, 952, 953, 960, 961, 962, 963, 964, 965});
                context.MoveUserPath(patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 102, 201});
                context.CreateMonster(spawnIds: new []{103, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{102, 201});
                context.CreateMonster(spawnIds: new []{103, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 701, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "complete_airstrikeofjunta");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000451}, questStates: new byte[]{2})) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10031010, textId: 10031010);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000451}, questStates: new byte[]{3})) {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000452}, questStates: new byte[]{1})) {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 63000028, portalId: 12, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{103, 202});
                context.CreateMonster(spawnIds: new []{104, 203}, arg2: false);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.SetSceneSkip(state: new StateTimeToLeave05(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114, 8115}, visible: true);
                context.CreateMonster(spawnIds: new []{910, 911, 912, 913});
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 601, enabled: true);
                context.SetEffect(triggerIds: new []{5100, 6003}, visible: true);
                context.SetConversation(type: 1, spawnId: 104, script: "$63000028_CS__BATTLE01__9$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_103");
                context.MoveUserPath(patrolName: "MS2PatrolData_1004");
                context.CreateMonster(spawnIds: new []{920, 921, 922, 923, 924});
                context.MoveNpc(spawnId: 910, patrolName: "MS2PatrolData_910");
                context.MoveNpc(spawnId: 911, patrolName: "MS2PatrolData_911");
                context.MoveNpc(spawnId: 912, patrolName: "MS2PatrolData_912");
                context.MoveNpc(spawnId: 913, patrolName: "MS2PatrolData_913");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 920, patrolName: "MS2PatrolData_920");
                context.MoveNpc(spawnId: 921, patrolName: "MS2PatrolData_921");
                context.MoveNpc(spawnId: 922, patrolName: "MS2PatrolData_922");
                context.MoveNpc(spawnId: 923, patrolName: "MS2PatrolData_923");
                context.MoveNpc(spawnId: 924, patrolName: "MS2PatrolData_924");
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6102}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000028_CS__BATTLE01__10$", arg4: 4);
                context.CreateMonster(spawnIds: new []{930, 931, 932, 933, 950, 951, 952, 953});
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_930");
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_931");
                context.MoveNpc(spawnId: 932, patrolName: "MS2PatrolData_932");
                context.MoveNpc(spawnId: 933, patrolName: "MS2PatrolData_933");
                context.MoveNpc(spawnId: 950, patrolName: "MS2PatrolData_950");
                context.MoveNpc(spawnId: 951, patrolName: "MS2PatrolData_951");
                context.MoveNpc(spawnId: 952, patrolName: "MS2PatrolData_952");
                context.MoveNpc(spawnId: 953, patrolName: "MS2PatrolData_953");
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{940, 941, 942, 943, 944, 945, 960, 961, 962, 963, 964, 965});
                context.MoveNpc(spawnId: 940, patrolName: "MS2PatrolData_940");
                context.MoveNpc(spawnId: 941, patrolName: "MS2PatrolData_941");
                context.MoveNpc(spawnId: 942, patrolName: "MS2PatrolData_942");
                context.MoveNpc(spawnId: 943, patrolName: "MS2PatrolData_943");
                context.MoveNpc(spawnId: 944, patrolName: "MS2PatrolData_944");
                context.MoveNpc(spawnId: 945, patrolName: "MS2PatrolData_945");
                context.MoveNpc(spawnId: 960, patrolName: "MS2PatrolData_960");
                context.MoveNpc(spawnId: 961, patrolName: "MS2PatrolData_961");
                context.MoveNpc(spawnId: 962, patrolName: "MS2PatrolData_962");
                context.MoveNpc(spawnId: 963, patrolName: "MS2PatrolData_963");
                context.MoveNpc(spawnId: 964, patrolName: "MS2PatrolData_964");
                context.MoveNpc(spawnId: 965, patrolName: "MS2PatrolData_965");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 602, enabled: true);
                context.SetEffect(triggerIds: new []{6004}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000028_CS__BATTLE01__11$", arg4: 4);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_104");
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_1005");
                context.CameraSelect(triggerId: 602, enabled: false);
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{104, 203});
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 63000029, portalId: 1, boxId: 9900);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
