using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000068_cs {
    public static class _63000068_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000358}, questStates: new byte[]{3})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000358}, questStates: new byte[]{2})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000358}, questStates: new byte[]{1})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000357}, questStates: new byte[]{3})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000357}, questStates: new byte[]{2})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000357}, questStates: new byte[]{1})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000356}, questStates: new byte[]{3})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000356}, questStates: new byte[]{2})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000356}, questStates: new byte[]{1})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000355}, questStates: new byte[]{3})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000355}, questStates: new byte[]{2})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000355}, questStates: new byte[]{1})) {
                    return new StateMonsterSpawn_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000354}, questStates: new byte[]{3})) {
                    return new StateMonsterSpawn_03(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000354}, questStates: new byte[]{2})) {
                    return new StateMonsterSpawn_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000354}, questStates: new byte[]{1})) {
                    return new StateWait_01(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateMonsterSpawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_01 : TriggerState {
            internal State마리엔Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State마리엔Spawn_10(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_02 : TriggerState {
            internal State마리엔Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__0$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_03 : TriggerState {
            internal State마리엔Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__1$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_04 : TriggerState {
            internal State마리엔Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__2$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_05 : TriggerState {
            internal State마리엔Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State마리엔Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_06 : TriggerState {
            internal State마리엔Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_07 : TriggerState {
            internal State마리엔Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__3$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔Spawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_08 : TriggerState {
            internal State마리엔Spawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Spawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_09 : TriggerState {
            internal State마리엔Spawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_10 : TriggerState {
            internal State마리엔Spawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMonsterSpawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_01 : TriggerState {
            internal StateMonsterSpawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_02 : TriggerState {
            internal StateMonsterSpawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재입장시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_03 : TriggerState {
            internal StateMonsterSpawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest마리엔Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_04 : TriggerState {
            internal StateMonsterSpawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_01 : TriggerState {
            internal State마리엔Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_02 : TriggerState {
            internal State마리엔Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__5$", duration: 2000, align: Align.Right);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Exit_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_03 : TriggerState {
            internal State마리엔Exit_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔Exit_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_04 : TriggerState {
            internal State마리엔Exit_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 26300681, textId: 26300681);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{705}, questIds: new []{30000354}, questStates: new byte[]{2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재입장시 : TriggerState {
            internal State재입장시(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{705}, questIds: new []{30000354}, questStates: new byte[]{2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300681);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State암전_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔재Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_01 : TriggerState {
            internal State마리엔재Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State재SpawnCinematic완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔재Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_02 : TriggerState {
            internal State마리엔재Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔재Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_03 : TriggerState {
            internal State마리엔재Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔재Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_04 : TriggerState {
            internal State마리엔재Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__6$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마리엔재Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_05 : TriggerState {
            internal State마리엔재Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__7$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔재Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_06 : TriggerState {
            internal State마리엔재Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__8$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔재Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재Spawn_07 : TriggerState {
            internal State마리엔재Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000068_CS__63000068_MAIN__9$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State재SpawnCinematic완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재SpawnCinematic완료 : TriggerState {
            internal State재SpawnCinematic완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest마리엔Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest마리엔Spawn : TriggerState {
            internal StateQuest마리엔Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{705}, questIds: new []{30000355}, questStates: new byte[]{1})) {
                    return new StateQuest마리엔Exit_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{705}, questIds: new []{30000355}, questStates: new byte[]{2})) {
                    return new StateQuest마리엔Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest마리엔Exit_01 : TriggerState {
            internal StateQuest마리엔Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateQuest마리엔Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest마리엔Exit_02 : TriggerState {
            internal StateQuest마리엔Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{203});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
