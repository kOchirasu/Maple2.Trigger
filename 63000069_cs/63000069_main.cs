namespace Maple2.Trigger._63000069_cs {
    public static class _63000069_main {
        public class StateStandby : TriggerState {
            internal StateStandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_01_girl");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_02_man");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_03_girlmaid");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_04_boymaid");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_05_blackstaragent");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_06_oldman");
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_07_cat");
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_08_youngboy");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuestcheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestcheck : TriggerState {
            internal StateQuestcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {150});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000356}, arg3: new byte[] {3})) {
                    return new StateFin(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000356}, arg3: new byte[] {2})) {
                    return new StateScene1_ready(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000356}, arg3: new byte[] {1})) {
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

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000356}, arg3: new byte[] {2})) {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_03_girlmaid_out");
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000069, arg2: 11);
                context.SetMesh(arg1: new[] {4001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000356}, arg3: new byte[] {2})) {
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
                context.SetSceneSkip(arg1: "sceneskip", arg2: "exit");
                context.CameraSelectPath(arg1: new[] {8000, 8001}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {150}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 150, arg2: "MS2PatrolData_50_marienne");
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__0$", duration: 3000);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__1$", duration: 4500);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Talk_A", arg3: 4500f);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__2$", duration: 5500);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Bore_B", arg3: 5500f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__3$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Damg_A", arg3: 100f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__4$", duration: 4000);
                context.MoveUser(arg1: 63000069, arg2: 10);
                context.MoveNpc(arg1: 150, arg2: "MS2PatrolData_51_marienne1");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__5$", duration: 5000);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Talk_A", arg3: 4500f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.AddCinematicTalk(npcId: 11004308, msg: "$63000069_CS__63000069_MAIN__6$", duration: 3500);
                context.SetEffect(arg1: new[] {602}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {150});
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.MoveUser(arg1: 63000069, arg2: 10);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {150});
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_03_girlmaid");
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateFin : TriggerState {
            internal StateFin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}