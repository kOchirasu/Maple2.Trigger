using System;

namespace Maple2.Trigger._52000147_qd {
    public static class _52000147_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetMesh(arg1: new int[] {4001, 4002}, arg2: true);
                context.SetMeshAnimation(arg1: new int[] {4001, 4002}, arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new int[] {4003, 4004, 4005, 4006}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
                    context.State = new State잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기 : TriggerState {
            internal State잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State뚜벅뚜벅_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뚜벅뚜벅_01 : TriggerState {
            internal State뚜벅뚜벅_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State뚜벅뚜벅_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뚜벅뚜벅_02 : TriggerState {
            internal State뚜벅뚜벅_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000147_QD__52000147_MAIN__0$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State목격_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_01 : TriggerState {
            internal State목격_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State목격_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State목격_02 : TriggerState {
            internal State목격_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State목격_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_03 : TriggerState {
            internal State목격_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State목격_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_04 : TriggerState {
            internal State목격_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State목격_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_05 : TriggerState {
            internal State목격_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State목격_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_06 : TriggerState {
            internal State목격_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State목격_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_07 : TriggerState {
            internal State목격_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4001, 4002}, arg2: false);
                context.SetMeshAnimation(arg1: new int[] {4001, 4002}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State목격_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목격_08 : TriggerState {
            internal State목격_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "삼자대화_01");
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__1$", duration: 4000,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State삼자대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_01 : TriggerState {
            internal State삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State삼자대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_02 : TriggerState {
            internal State삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State삼자대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_03 : TriggerState {
            internal State삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State삼자대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_04 : TriggerState {
            internal State삼자대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State삼자대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_05 : TriggerState {
            internal State삼자대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "하스터와전투_01", arg2: "nextState");
                context.AddCinematicTalk(npcID: 0, msg: "$52000147_QD__52000147_MAIN__2$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State삼자대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_06 : TriggerState {
            internal State삼자대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State삼자대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_07 : TriggerState {
            internal State삼자대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State삼자대화_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_08 : TriggerState {
            internal State삼자대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__3$", duration: 3000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_09 : TriggerState {
            internal State삼자대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State삼자대화_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_10 : TriggerState {
            internal State삼자대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__4$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_11 : TriggerState {
            internal State삼자대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__5$", duration: 2500,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_12 : TriggerState {
            internal State삼자대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__6$", duration: 4000,
                    illustID: "DarkLord_normal", align: "right");
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__7$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State삼자대화_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_13 : TriggerState {
            internal State삼자대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000147_QD__52000147_MAIN__8$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State삼자대화_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_14 : TriggerState {
            internal State삼자대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__9$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_15 : TriggerState {
            internal State삼자대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__10$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__11$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State삼자대화_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_16 : TriggerState {
            internal State삼자대화_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__12$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_17 : TriggerState {
            internal State삼자대화_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__13$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_18 : TriggerState {
            internal State삼자대화_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000147_QD__52000147_MAIN__14$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State삼자대화_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_19 : TriggerState {
            internal State삼자대화_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State삼자대화_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_20 : TriggerState {
            internal State삼자대화_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__15$", duration: 2500,
                    align: "left");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_Idle_A", arg3: 4000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State하스터와전투_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_01 : TriggerState {
            internal State하스터와전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State하스터와전투_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_02 : TriggerState {
            internal State하스터와전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State하스터와전투_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_03 : TriggerState {
            internal State하스터와전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 25201471, textID: 25201471);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State하스터와전투_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_04 : TriggerState {
            internal State하스터와전투_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityID: 25201471);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State하스터와전투_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_05 : TriggerState {
            internal State하스터와전투_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__16$", duration: 2500,
                    align: "left");
                context.MoveUser(arg1: 52000147, arg2: 99);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State하스터와전투_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_06 : TriggerState {
            internal State하스터와전투_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_B", arg2: 60000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State하스터와전투_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터와전투_07 : TriggerState {
            internal State하스터와전투_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투후대화_02");
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__17$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State전투후대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전투후대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_03 : TriggerState {
            internal State전투후대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투후대화_03_01");
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__18$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State전투후대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_03_01 : TriggerState {
            internal State전투후대화_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State전투후대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_04 : TriggerState {
            internal State전투후대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투후대화_05");
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__19$", duration: 3000,
                    illustID: "DarkLord_normal", align: "right");
                context.AddCinematicTalk(npcID: 11003382, msg: "$52000147_QD__52000147_MAIN__20$", duration: 2500,
                    illustID: "DarkLord_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State전투후대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_05 : TriggerState {
            internal State전투후대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_06 : TriggerState {
            internal State전투후대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투후대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_07 : TriggerState {
            internal State전투후대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State전투후대화_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_08 : TriggerState {
            internal State전투후대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_09 : TriggerState {
            internal State전투후대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_10 : TriggerState {
            internal State전투후대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투후대화_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_11 : TriggerState {
            internal State전투후대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투후대화_12");
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000147_QD__52000147_MAIN__21$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State전투후대화_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_12 : TriggerState {
            internal State전투후대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_13 : TriggerState {
            internal State전투후대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {104});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_14 : TriggerState {
            internal State전투후대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전투후대화_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_15 : TriggerState {
            internal State전투후대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000147_QD__52000147_MAIN__22$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000148, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}