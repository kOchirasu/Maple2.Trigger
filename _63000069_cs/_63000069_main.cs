using System;

namespace Maple2.Trigger._63000069_cs {
    public static class _63000069_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestandby(context);

        private class Statestandby : TriggerState {
            internal Statestandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {101, 102, 103, 104, 105, 106, 107, 108, 109}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetMesh(arg1: new int[] {4001}, arg2: false);
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

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new Statequestcheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequestcheck : TriggerState {
            internal Statequestcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {150});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000356},
                    arg3: new byte[] {3})) {
                    context.State = new Statefin(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000356},
                    arg3: new byte[] {2})) {
                    context.State = new Statescene1_ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000356},
                    arg3: new byte[] {1})) {
                    context.State = new Statesearching_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesearching_check : TriggerState {
            internal Statesearching_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26300691, textID: 26300691);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000356},
                    arg3: new byte[] {2})) {
                    context.State = new Statescene1_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ready : TriggerState {
            internal Statescene1_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityID: 26300691, textID: 26300691);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_03_girlmaid_out");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene1_set(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_set : TriggerState {
            internal Statescene1_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000069, arg2: 11);
                context.SetMesh(arg1: new int[] {4001}, arg2: true);
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000356},
                    arg3: new byte[] {2})) {
                    context.State = new Statequestcheck(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene1_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_start : TriggerState {
            internal Statescene1_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "sceneskip", arg2: "exit");
                context.CameraSelectPath(arg1: new int[] {8000, 8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene1_girlmonologue0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlmonologue0 : TriggerState {
            internal Statescene1_girlmonologue0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {150}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene1_girlmonologue1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlmonologue1 : TriggerState {
            internal Statescene1_girlmonologue1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 150, arg2: "MS2PatrolData_50_marienne");
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__0$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene1_girlmonologue2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlmonologue2 : TriggerState {
            internal Statescene1_girlmonologue2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__1$", duration: 4500);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Talk_A", arg3: 4500f);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene1_girlmonologue3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlmonologue3 : TriggerState {
            internal Statescene1_girlmonologue3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__2$", duration: 5500);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Bore_B", arg3: 5500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new Statescene1_girlrealize0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlrealize0 : TriggerState {
            internal Statescene1_girlrealize0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__3$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Damg_A", arg3: 100f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene1_girlrealize1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlrealize1 : TriggerState {
            internal Statescene1_girlrealize1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__4$", duration: 4000);
                context.MoveUser(arg1: 63000069, arg2: 10);
                context.MoveNpc(arg1: 150, arg2: "MS2PatrolData_51_marienne1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene1_girlrealize2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlrealize2 : TriggerState {
            internal Statescene1_girlrealize2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__5$", duration: 5000);
                context.SetNpcEmotionLoop(arg1: 150, arg2: "Talk_A", arg3: 4500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene1_girlmonologue5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_girlmonologue5 : TriggerState {
            internal Statescene1_girlmonologue5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000069_CS__63000069_MAIN__6$", duration: 3500);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Statescene_readytoend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_readytoend : TriggerState {
            internal Statescene_readytoend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetMesh(arg1: new int[] {4001}, arg2: false);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fin_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesceneskip : TriggerState {
            internal Statesceneskip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {150});
                context.SetMesh(arg1: new int[] {4001}, arg2: false);
                context.MoveUser(arg1: 63000069, arg2: 10);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fin_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_fin_ready : TriggerState {
            internal Statescene_fin_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.DestroyMonster(arg1: new int[] {150});
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_03_girlmaid");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_fin : TriggerState {
            internal Statescene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statefin : TriggerState {
            internal Statefin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}