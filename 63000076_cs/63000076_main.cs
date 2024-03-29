using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(spawnIds: new []{105, 106, 107, 118, 119}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002, 4003, 4004}, visible: true);
                context.SetMesh(triggerIds: new []{4005, 4006, 4007, 4008}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000375}, questStates: new byte[]{2})) {
                    return new State보Boss발소리_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000375}, questStates: new byte[]{1})) {
                    return new StateWait_01(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State요정잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_01 : TriggerState {
            internal State요정잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State요정잡담종료_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State요정잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_02 : TriggerState {
            internal State요정잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 103, msg: "$63000076_CS__63000076_MAIN__0$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_03 : TriggerState {
            internal State요정잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$63000076_CS__63000076_MAIN__1$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_04 : TriggerState {
            internal State요정잡담_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State요정잡담_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_05 : TriggerState {
            internal State요정잡담_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 105, msg: "$63000076_CS__63000076_MAIN__2$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_06 : TriggerState {
            internal State요정잡담_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 107, msg: "$63000076_CS__63000076_MAIN__3$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_07 : TriggerState {
            internal State요정잡담_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002, 8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State요정잡담_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_08 : TriggerState {
            internal State요정잡담_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 112, msg: "$63000076_CS__63000076_MAIN__4$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_09 : TriggerState {
            internal State요정잡담_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 113, msg: "$63000076_CS__63000076_MAIN__5$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_10 : TriggerState {
            internal State요정잡담_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 114, msg: "$63000076_CS__63000076_MAIN__6$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State요정잡담종료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담종료_01 : TriggerState {
            internal State요정잡담종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State요정잡담종료_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
            }
        }

        private class State요정잡담종료_02 : TriggerState {
            internal State요정잡담종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702, 703, 704, 705, 706, 707, 708}, questIds: new []{30000375}, questStates: new byte[]{2})) {
                    return new State보Boss발소리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_01 : TriggerState {
            internal State보Boss발소리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss발소리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_02 : TriggerState {
            internal State보Boss발소리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201, 202, 203, 204, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217});
                context.MoveUser(mapId: 63000076, portalId: 1);
                context.SetSceneSkip(state: new StateStopCinematic_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss발소리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_03 : TriggerState {
            internal State보Boss발소리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, script: "$63000076_CS__63000076_MAIN__7$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보Boss발소리_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_04 : TriggerState {
            internal State보Boss발소리_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, script: "$63000076_CS__63000076_MAIN__8$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보BossSpawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_01 : TriggerState {
            internal State보BossSpawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.CreateMonster(spawnIds: new []{141, 142}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002, 4003, 4004}, visible: false);
                context.SetMesh(triggerIds: new []{4005, 4006, 4007, 4008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보BossSpawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_02 : TriggerState {
            internal State보BossSpawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossSpawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_03 : TriggerState {
            internal State보BossSpawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 106, msg: "$63000076_CS__63000076_MAIN__9$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State보BossSpawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_04 : TriggerState {
            internal State보BossSpawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 111, msg: "$63000076_CS__63000076_MAIN__10$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보BossSpawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_05 : TriggerState {
            internal State보BossSpawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, script: "$63000076_CS__63000076_MAIN__11$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State보BossSpawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_06 : TriggerState {
            internal State보BossSpawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004, 8006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보BossSpawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_07 : TriggerState {
            internal State보BossSpawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 142, msg: "$63000076_CS__63000076_MAIN__12$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보BossSpawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_08 : TriggerState {
            internal State보BossSpawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000076_CS__63000076_MAIN__13$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State보BossSpawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_09 : TriggerState {
            internal State보BossSpawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossSpawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_10 : TriggerState {
            internal State보BossSpawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000076_CS__63000076_MAIN__14$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State사라진케이크_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class State사라진케이크_01 : TriggerState {
            internal State사라진케이크_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State사라진케이크_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사라진케이크_02 : TriggerState {
            internal State사라진케이크_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, script: "$63000076_CS__63000076_MAIN__15$", duration: 2500, align: Align.Right);
                context.SetMesh(triggerIds: new []{4005, 4006, 4007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State사라진케이크_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사라진케이크_03 : TriggerState {
            internal State사라진케이크_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, script: "$63000076_CS__63000076_MAIN__16$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State사라진케이크_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119});
            }
        }

        private class State사라진케이크_04 : TriggerState {
            internal State사라진케이크_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000076_CS__63000076_MAIN__17$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State사라진케이크_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class State사라진케이크_05 : TriggerState {
            internal State사라진케이크_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_01 : TriggerState {
            internal State미아Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_02 : TriggerState {
            internal State미아Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, script: "$63000076_CS__63000076_MAIN__18$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_03 : TriggerState {
            internal State미아Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, script: "$63000076_CS__63000076_MAIN__19$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_04 : TriggerState {
            internal State미아Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, script: "$63000076_CS__63000076_MAIN__20$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_05 : TriggerState {
            internal State미아Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 141, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_06 : TriggerState {
            internal State미아Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_07 : TriggerState {
            internal State미아Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{141});
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
                context.MoveUser(mapId: 63000076, portalId: 2);
                context.MoveNpc(spawnId: 142, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Spawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_08 : TriggerState {
            internal State미아Spawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미아Spawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_09 : TriggerState {
            internal State미아Spawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, script: "$63000076_CS__63000076_MAIN__21$", duration: 3000, illustId: "Mia_annoyed", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Spawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_10 : TriggerState {
            internal State미아Spawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000076_CS__63000076_MAIN__22$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Spawn_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_11 : TriggerState {
            internal State미아Spawn_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, script: "$63000076_CS__63000076_MAIN__23$", duration: 2500, illustId: "Mia_annoyed", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Spawn_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_12 : TriggerState {
            internal State미아Spawn_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000076_CS__63000076_MAIN__24$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State미아Spawn_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_13 : TriggerState {
            internal State미아Spawn_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, script: "$63000076_CS__63000076_MAIN__25$", duration: 3000, illustId: "Mia_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Spawn_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_14 : TriggerState {
            internal State미아Spawn_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000076_CS__63000076_MAIN__26$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Spawn_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_15 : TriggerState {
            internal State미아Spawn_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, script: "$63000076_CS__63000076_MAIN__27$", duration: 3000, illustId: "Mia_annoyed", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Spawn_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_16 : TriggerState {
            internal State미아Spawn_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미아Spawn_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_17 : TriggerState {
            internal State미아Spawn_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(spawnIds: new []{142});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Spawn_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Spawn_18 : TriggerState {
            internal State미아Spawn_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic_01 : TriggerState {
            internal StateStopCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic_02 : TriggerState {
            internal StateStopCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007}, visible: false);
                context.SetMesh(triggerIds: new []{4008}, visible: true);
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 141, 142});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic_03 : TriggerState {
            internal StateStopCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
