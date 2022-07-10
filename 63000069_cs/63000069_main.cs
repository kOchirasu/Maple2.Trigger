namespace Maple2.Trigger._63000069_cs {
    public static class _63000069_main {
        public class StateStandby : TriggerState {
            internal StateStandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109}, arg2: false);
                context.SetEffect(triggerIds: new []{601, 602}, visible: false);
                context.SetMesh(triggerIds: new []{4001}, visible: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_01_girl");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_02_man");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_03_girlmaid");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_04_boymaid");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_05_blackstaragent");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_06_oldman");
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_07_cat");
                context.MoveNpc(spawnId: 108, patrolName: "MS2PatrolData_08_youngboy");
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
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

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{150});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000356}, questStates: new byte[]{3})) {
                    return new StateFin(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000356}, questStates: new byte[]{2})) {
                    return new StateScene1_ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000356}, questStates: new byte[]{1})) {
                    return new StateSearching_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSearching_check : TriggerState {
            internal StateSearching_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300691, textId: 26300691);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000356}, questStates: new byte[]{2})) {
                    return new StateScene1_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_ready : TriggerState {
            internal StateScene1_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 26300691, textId: 26300691);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_03_girlmaid_out");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene1_set(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_set : TriggerState {
            internal StateScene1_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000069, portalId: 11);
                context.SetMesh(triggerIds: new []{4001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000356}, questStates: new byte[]{2})) {
                    return new StateQuestcheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene1_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_start : TriggerState {
            internal StateScene1_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSceneskip(context), arg2: "exit");
                context.CameraSelectPath(pathIds: new []{8000, 8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene1_girlmonologue0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlmonologue0 : TriggerState {
            internal StateScene1_girlmonologue0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{150}, arg2: false);
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene1_girlmonologue1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlmonologue1 : TriggerState {
            internal StateScene1_girlmonologue1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 150, patrolName: "MS2PatrolData_50_marienne");
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene1_girlmonologue2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlmonologue2 : TriggerState {
            internal StateScene1_girlmonologue2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__1$", duration: 4500);
                context.SetNpcEmotionLoop(spawnId: 150, sequenceName: "Talk_A", duration: 4500f);
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene1_girlmonologue3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlmonologue3 : TriggerState {
            internal StateScene1_girlmonologue3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__2$", duration: 5500);
                context.SetNpcEmotionLoop(spawnId: 150, sequenceName: "Bore_B", duration: 5500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateScene1_girlrealize0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlrealize0 : TriggerState {
            internal StateScene1_girlrealize0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__3$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 150, sequenceName: "Damg_A", duration: 100f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene1_girlrealize1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlrealize1 : TriggerState {
            internal StateScene1_girlrealize1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__4$", duration: 4000);
                context.MoveUser(mapId: 63000069, portalId: 10);
                context.MoveNpc(spawnId: 150, patrolName: "MS2PatrolData_51_marienne1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene1_girlrealize2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlrealize2 : TriggerState {
            internal StateScene1_girlrealize2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__5$", duration: 5000);
                context.SetNpcEmotionLoop(spawnId: 150, sequenceName: "Talk_A", duration: 4500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene1_girlmonologue5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene1_girlmonologue5 : TriggerState {
            internal StateScene1_girlmonologue5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.AddCinematicTalk(npcId: 11004308, script: "$63000069_CS__63000069_MAIN__6$", duration: 3500);
                context.SetEffect(triggerIds: new []{602}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateScene_readytoend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_readytoend : TriggerState {
            internal StateScene_readytoend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetMesh(triggerIds: new []{4001}, visible: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fin_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneskip : TriggerState {
            internal StateSceneskip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{150});
                context.SetMesh(triggerIds: new []{4001}, visible: false);
                context.MoveUser(mapId: 63000069, portalId: 10);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fin_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fin_ready : TriggerState {
            internal StateScene_fin_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.DestroyMonster(spawnIds: new []{150});
                context.SetEffect(triggerIds: new []{602}, visible: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_03_girlmaid");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fin : TriggerState {
            internal StateScene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateFin : TriggerState {
            internal StateFin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
