using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000070_cs {
    public static class _63000070_main {
        public class StateStandby : TriggerState {
            internal StateStandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{529}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605}, visible: false);
                context.SetInteractObject(interactIds: new []{32000015}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestcheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestcheck : TriggerState {
            internal StateQuestcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{2})) {
                    return new StateGotolobby_ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{1})) {
                    return new StateScene1_ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{3})) {
                    return new StateEmptyroom(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEmptyroom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEmptyroom : TriggerState {
            internal StateEmptyroom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 201, 211, 221});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{2})) {
                    return new StateGotolobby_ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{1})) {
                    return new StateScene1_ready(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGotolobby_ready : TriggerState {
            internal StateGotolobby_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 201, 211, 221});
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{2})) {
                    return new StateQuestcheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ready : TriggerState {
            internal StateScene1_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 201, 211, 221});
                context.CreateMonster(spawnIds: new []{101, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120}, arg2: false);
                context.SetInteractObject(interactIds: new []{32000015}, state: 2);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000357}, questStates: new byte[]{1})) {
                    return new StateQuestcheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene1_set(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_set : TriggerState {
            internal StateScene1_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene1_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_start : TriggerState {
            internal StateScene1_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000, 8001}, returnView: false);
                context.SetSceneSkip(state: new StateSceneskip_1(context), arg2: "exit");
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", script: "$63000070_CS__63000070_MAIN__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene1_ladymonologue1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladymonologue1 : TriggerState {
            internal StateScene1_ladymonologue1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000070, portalId: 10);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", script: "$63000070_CS__63000070_MAIN__1$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene1_ladymonologue2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladymonologue2 : TriggerState {
            internal StateScene1_ladymonologue2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", script: "$63000070_CS__63000070_MAIN__2$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene1_ladyzoomin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladyzoomin : TriggerState {
            internal StateScene1_ladyzoomin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005, 8006}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11004289, script: "$63000070_CS__63000070_MAIN__3$", duration: 4000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Idle_A", duration: 4000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene1_ladygoback1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladygoback1 : TriggerState {
            internal StateScene1_ladygoback1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006, 8007}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "Patrol_lady_backward_01");
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", align: Align.Right, script: "$63000070_CS__63000070_MAIN__4$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene1_ladygoback2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladygoback2 : TriggerState {
            internal StateScene1_ladygoback2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", align: Align.Right, script: "$63000070_CS__63000070_MAIN__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene1_ladygoback3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladygoback3 : TriggerState {
            internal StateScene1_ladygoback3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "Patrol_lady_backward_02");
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", align: Align.Right, script: "$63000070_CS__63000070_MAIN__6$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene1_ladygoback4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladygoback4 : TriggerState {
            internal StateScene1_ladygoback4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", align: Align.Right, script: "$63000070_CS__63000070_MAIN__7$", duration: 4000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene1_robottroops(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_robottroops : TriggerState {
            internal StateScene1_robottroops(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8011}, returnView: false);
                context.MoveNpc(spawnId: 111, patrolName: "Patrol_bot_01");
                context.MoveNpc(spawnId: 112, patrolName: "Patrol_bot_02");
                context.MoveNpc(spawnId: 113, patrolName: "Patrol_bot_03");
                context.MoveNpc(spawnId: 114, patrolName: "Patrol_bot_04");
                context.MoveNpc(spawnId: 115, patrolName: "Patrol_bot_05");
                context.MoveNpc(spawnId: 116, patrolName: "Patrol_bot_06");
                context.MoveNpc(spawnId: 117, patrolName: "Patrol_bot_07");
                context.MoveNpc(spawnId: 118, patrolName: "Patrol_bot_08");
                context.MoveNpc(spawnId: 119, patrolName: "Patrol_bot_09");
                context.MoveNpc(spawnId: 120, patrolName: "Patrol_bot_10");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene1_ladygoback5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ladygoback5 : TriggerState {
            internal StateScene1_ladygoback5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "Patrol_lady_backward_03");
                context.AddCinematicTalk(npcId: 11004289, illustId: "Rue_Halloween", align: Align.Center, script: "$63000070_CS__63000070_MAIN__8$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene1_readytofight(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_readytofight : TriggerState {
            internal StateScene1_readytofight(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene1_setbattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneskip_1 : TriggerState {
            internal StateSceneskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 63000070, portalId: 10);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene1_setbattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_setbattle : TriggerState {
            internal StateScene1_setbattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120});
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene1_setbattle1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_setbattle1 : TriggerState {
            internal StateScene1_setbattle1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "Patrol_PC_fightposition");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWave_1st_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWave_1st_ready : TriggerState {
            internal StateWave_1st_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWave_1st_go(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWave_1st_go : TriggerState {
            internal StateWave_1st_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new StateWave_2nd_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWave_2nd_ready : TriggerState {
            internal StateWave_2nd_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWave_2nd_go(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWave_2nd_go : TriggerState {
            internal StateWave_2nd_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{211}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{211})) {
                    return new StateWave_3rd_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWave_3rd_ready : TriggerState {
            internal StateWave_3rd_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWave_3rd_go(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWave_3rd_go : TriggerState {
            internal StateWave_3rd_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{221}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{221})) {
                    return new StateScene2_marienneappears_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_marienneappears_ready : TriggerState {
            internal StateScene2_marienneappears_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 1001, 1011, 1021});
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
                context.MoveUser(mapId: 63000070, portalId: 11);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene2_marienneappears_set(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_marienneappears_set : TriggerState {
            internal StateScene2_marienneappears_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8020}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetInteractObject(interactIds: new []{32000015}, state: 1);
                context.SetMesh(triggerIds: new []{529}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSceneSkip(state: new StateSceneskip_2(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene2_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_start : TriggerState {
            internal StateScene2_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8021}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.MoveNpc(spawnId: 105, patrolName: "Patrol_girl");
                context.AddCinematicTalk(npcId: 11004308, script: "$63000070_CS__63000070_MAIN__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene2_girltalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_girltalk : TriggerState {
            internal StateScene2_girltalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.AddCinematicTalk(npcId: 11004308, script: "$63000070_CS__63000070_MAIN__10$", duration: 2000);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene2_casezoomin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_casezoomin : TriggerState {
            internal StateScene2_casezoomin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, align: Align.Right, script: "$63000070_CS__63000070_MAIN__11$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene2_readytosearch(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneskip_2 : TriggerState {
            internal StateSceneskip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "Patrol_girl");
                context.SetEffect(triggerIds: new []{604}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene2_readytosearch(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_readytosearch : TriggerState {
            internal StateScene2_readytosearch(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene2_search_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_search_ready : TriggerState {
            internal StateScene2_search_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene2_search(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene2_search : TriggerState {
            internal StateScene2_search(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{32000015}, arg2: 0)) {
                    return new StateScene3_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_ready : TriggerState {
            internal StateScene3_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new StateSceneskip_3(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene3_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_start : TriggerState {
            internal StateScene3_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, script: "$63000070_CS__63000070_MAIN__12$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene3_girltalk0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_girltalk0 : TriggerState {
            internal StateScene3_girltalk0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8021}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateScene3_girltalk1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_girltalk1 : TriggerState {
            internal StateScene3_girltalk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, script: "$63000070_CS__63000070_MAIN__13$", duration: 5000);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Talk_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateScene3_girltalk2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_girltalk2 : TriggerState {
            internal StateScene3_girltalk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, script: "$63000070_CS__63000070_MAIN__14$", duration: 4500);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Talk_A", duration: 4500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4800)) {
                    return new StateScene3_girlgoout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_girlgoout : TriggerState {
            internal StateScene3_girlgoout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.MoveNpc(spawnId: 105, patrolName: "Patrol_girl_out");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene3_girldisappears(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_girldisappears : TriggerState {
            internal StateScene3_girldisappears(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene3_readytoend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneskip_3 : TriggerState {
            internal StateSceneskip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene3_readytoend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene3_readytoend : TriggerState {
            internal StateScene3_readytoend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{605}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene_fin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fin : TriggerState {
            internal StateScene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
