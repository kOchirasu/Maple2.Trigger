using System;

namespace Maple2.Trigger._63000070_cs {
    public static class _63000070_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestandby(context);

        private class Statestandby : TriggerState {
            internal Statestandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {529}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetInteractObject(arg1: new int[] {32000015}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new Statequestcheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequestcheck : TriggerState {
            internal Statequestcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {2})) {
                    context.State = new Stategotolobby_ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {1})) {
                    context.State = new Statescene1_ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {3})) {
                    context.State = new Stateemptyroom(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateemptyroom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateemptyroom : TriggerState {
            internal Stateemptyroom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[]
                    {101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 201, 211, 221});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {2})) {
                    context.State = new Stategotolobby_ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {1})) {
                    context.State = new Statescene1_ready(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stategotolobby_ready : TriggerState {
            internal Stategotolobby_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[]
                    {101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 201, 211, 221});
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {2})) {
                    context.State = new Statequestcheck(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ready : TriggerState {
            internal Statescene1_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[]
                    {101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 201, 211, 221});
                context.CreateMonster(arg1: new int[] {101, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120},
                    arg2: false);
                context.SetInteractObject(arg1: new int[] {32000015}, arg2: 2);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000357},
                    arg3: new byte[] {1})) {
                    context.State = new Statequestcheck(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene1_set(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_set : TriggerState {
            internal Statescene1_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene1_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_start : TriggerState {
            internal Statescene1_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000, 8001}, arg2: false);
                context.SetSceneSkip(arg1: "sceneskip_1", arg2: "exit");
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween",
                    msg: "$63000070_CS__63000070_MAIN__0$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene1_ladymonologue1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladymonologue1 : TriggerState {
            internal Statescene1_ladymonologue1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000070, arg2: 10);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween",
                    msg: "$63000070_CS__63000070_MAIN__1$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene1_ladymonologue2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladymonologue2 : TriggerState {
            internal Statescene1_ladymonologue2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween",
                    msg: "$63000070_CS__63000070_MAIN__2$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene1_ladyzoomin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladyzoomin : TriggerState {
            internal Statescene1_ladyzoomin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005, 8006}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11004289, msg: "$63000070_CS__63000070_MAIN__3$", duration: 4000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Idle_A", arg3: 4000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene1_ladygoback1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladygoback1 : TriggerState {
            internal Statescene1_ladygoback1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8006, 8007}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "Patrol_lady_backward_01");
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween", align: "right",
                    msg: "$63000070_CS__63000070_MAIN__4$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene1_ladygoback2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladygoback2 : TriggerState {
            internal Statescene1_ladygoback2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8008}, arg2: false);
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween", align: "right",
                    msg: "$63000070_CS__63000070_MAIN__5$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene1_ladygoback3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladygoback3 : TriggerState {
            internal Statescene1_ladygoback3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "Patrol_lady_backward_02");
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween", align: "right",
                    msg: "$63000070_CS__63000070_MAIN__6$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene1_ladygoback4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladygoback4 : TriggerState {
            internal Statescene1_ladygoback4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween", align: "right",
                    msg: "$63000070_CS__63000070_MAIN__7$", duration: 4000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene1_robottroops(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_robottroops : TriggerState {
            internal Statescene1_robottroops(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8011}, arg2: false);
                context.MoveNpc(arg1: 111, arg2: "Patrol_bot_01");
                context.MoveNpc(arg1: 112, arg2: "Patrol_bot_02");
                context.MoveNpc(arg1: 113, arg2: "Patrol_bot_03");
                context.MoveNpc(arg1: 114, arg2: "Patrol_bot_04");
                context.MoveNpc(arg1: 115, arg2: "Patrol_bot_05");
                context.MoveNpc(arg1: 116, arg2: "Patrol_bot_06");
                context.MoveNpc(arg1: 117, arg2: "Patrol_bot_07");
                context.MoveNpc(arg1: 118, arg2: "Patrol_bot_08");
                context.MoveNpc(arg1: 119, arg2: "Patrol_bot_09");
                context.MoveNpc(arg1: 120, arg2: "Patrol_bot_10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene1_ladygoback5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_ladygoback5 : TriggerState {
            internal Statescene1_ladygoback5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "Patrol_lady_backward_03");
                context.AddCinematicTalk(npcID: 11004289, illustID: "Rue_Halloween", align: "center",
                    msg: "$63000070_CS__63000070_MAIN__8$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene1_readytofight(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_readytofight : TriggerState {
            internal Statescene1_readytofight(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene1_setbattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesceneskip_1 : TriggerState {
            internal Statesceneskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 63000070, arg2: 10);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene1_setbattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_setbattle : TriggerState {
            internal Statescene1_setbattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120});
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene1_setbattle1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene1_setbattle1 : TriggerState {
            internal Statescene1_setbattle1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "Patrol_PC_fightposition");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewave_1st_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewave_1st_ready : TriggerState {
            internal Statewave_1st_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewave_1st_go(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewave_1st_go : TriggerState {
            internal Statewave_1st_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new Statewave_2nd_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewave_2nd_ready : TriggerState {
            internal Statewave_2nd_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewave_2nd_go(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewave_2nd_go : TriggerState {
            internal Statewave_2nd_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {211}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {211})) {
                    context.State = new Statewave_3rd_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewave_3rd_ready : TriggerState {
            internal Statewave_3rd_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewave_3rd_go(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewave_3rd_go : TriggerState {
            internal Statewave_3rd_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {221}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {221})) {
                    context.State = new Statescene2_marienneappears_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_marienneappears_ready : TriggerState {
            internal Statescene2_marienneappears_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[]
                    {101, 105, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 1001, 1011, 1021});
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.MoveUser(arg1: 63000070, arg2: 11);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene2_marienneappears_set(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_marienneappears_set : TriggerState {
            internal Statescene2_marienneappears_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8020}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetInteractObject(arg1: new int[] {32000015}, arg2: 1);
                context.SetMesh(arg1: new int[] {529}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSceneSkip(arg1: "sceneskip_2", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene2_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_start : TriggerState {
            internal Statescene2_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8021}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.MoveNpc(arg1: 105, arg2: "Patrol_girl");
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000070_CS__63000070_MAIN__9$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene2_girltalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_girltalk : TriggerState {
            internal Statescene2_girltalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8022}, arg2: false);
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000070_CS__63000070_MAIN__10$", duration: 2000);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene2_casezoomin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_casezoomin : TriggerState {
            internal Statescene2_casezoomin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, align: "right", msg: "$63000070_CS__63000070_MAIN__11$",
                    duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene2_readytosearch(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesceneskip_2 : TriggerState {
            internal Statesceneskip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "Patrol_girl");
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene2_readytosearch(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_readytosearch : TriggerState {
            internal Statescene2_readytosearch(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene2_search_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_search_ready : TriggerState {
            internal Statescene2_search_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene2_search(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene2_search : TriggerState {
            internal Statescene2_search(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {32000015}, arg2: 0)) {
                    context.State = new Statescene3_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_ready : TriggerState {
            internal Statescene3_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "sceneskip_3", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene3_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_start : TriggerState {
            internal Statescene3_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000070_CS__63000070_MAIN__12$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene3_girltalk0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_girltalk0 : TriggerState {
            internal Statescene3_girltalk0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8021}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new Statescene3_girltalk1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_girltalk1 : TriggerState {
            internal Statescene3_girltalk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000070_CS__63000070_MAIN__13$", duration: 5000);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new Statescene3_girltalk2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_girltalk2 : TriggerState {
            internal Statescene3_girltalk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004308, msg: "$63000070_CS__63000070_MAIN__14$", duration: 4500);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 4500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4800)) {
                    context.State = new Statescene3_girlgoout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_girlgoout : TriggerState {
            internal Statescene3_girlgoout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8022}, arg2: false);
                context.MoveNpc(arg1: 105, arg2: "Patrol_girl_out");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene3_girldisappears(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_girldisappears : TriggerState {
            internal Statescene3_girldisappears(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {105});
                context.SetEffect(arg1: new int[] {605}, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene3_readytoend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesceneskip_3 : TriggerState {
            internal Statesceneskip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {105});
                context.SetEffect(arg1: new int[] {605}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene3_readytoend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene3_readytoend : TriggerState {
            internal Statescene3_readytoend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene_fin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_fin : TriggerState {
            internal Statescene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}