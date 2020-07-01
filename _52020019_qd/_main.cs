namespace Maple2.Trigger._52020019_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetSound(arg1: 7001, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200010},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.MoveUser(arg1: 52020019, arg2: 6001);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCamera_Work_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCamera_Work_01 : TriggerState {
            internal StateCamera_Work_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4002, 4003}, arg2: false);
                context.SetSceneSkip(arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateShowCaption(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption : TriggerState {
            internal StateShowCaption(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$map:52020019$",
                    desc: "$npcName:11003614$의 두 번째 시험장.", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 2000, scale: 1.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCamera_Work_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCamera_Work_02 : TriggerState {
            internal StateCamera_Work_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_01 : TriggerState {
            internal StateEventScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, msg: "자, 시작하세요.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_02 : TriggerState {
            internal StateEventScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_03 : TriggerState {
            internal StateEventScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003598, msg: "오호.... 제법 기합을 넣을 줄 아시는군요.", duration: 2500,
                    illustId: "Michael_normal", align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_04 : TriggerState {
            internal StateEventScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003598, msg: "그럼 시작하기전에....", duration: 2500,
                    illustId: "Michael_normal", align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_05 : TriggerState {
            internal StateEventScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003598, msg: "정식으로 제 소개를 하죠.", duration: 2500,
                    illustId: "Michael_normal", align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_06 : TriggerState {
            internal StateEventScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003598, msg: "제 이름은 $npcName:11003598$.", duration: 2500,
                    illustId: "Michael_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_07 : TriggerState {
            internal StateEventScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, msg: "크리티아스 제 3기사. 몽환의 $npcName:11003598$입니다.",
                    duration: 3000, illustId: "Michael_normal", align: "Center");
                context.ShowCaption(type: "NameCaption", title: "$npcName:11003598$", desc: "몽환의 기사",
                    align: "centerLeft", offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 3000, scale: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateEventScene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_08 : TriggerState {
            internal StateEventScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEventScene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_09 : TriggerState {
            internal StateEventScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Bore_A");
                context.AddBalloonTalk(spawnPointId: 0, msg: "!!!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_10 : TriggerState {
            internal StateEventScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Emotion_B");
                context.AddCinematicTalk(npcId: 11003598, msg: "자, 그럼 당신의 실력을 확인해보도록 하죠.", duration: 3000,
                    illustId: "Michael_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateWhite(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWhite : TriggerState {
            internal StateWhite(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBattle_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_Ready : TriggerState {
            internal StateBattle_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateBattle_Stop(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_Stop : TriggerState {
            internal StateBattle_Stop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "그만!", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBattle_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_End : TriggerState {
            internal StateBattle_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {201});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEventScene_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_11 : TriggerState {
            internal StateEventScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, msg: "그만 하세요.", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_12 : TriggerState {
            internal StateEventScene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, msg: "이런, 이제 막 재미있어지려는 참이었는데 아쉽군요.", duration: 2500,
                    illustId: "Michael_normal", align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_13 : TriggerState {
            internal StateEventScene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, msg: "뭐, 다음 기회라는 것도 있으니 이번엔 여기까지만 하겠습니다.", duration: 2500,
                    illustId: "Michael_normal", align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_14 : TriggerState {
            internal StateEventScene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, msg: ".......", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_15 : TriggerState {
            internal StateEventScene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, msg: "돌아가죠. $npcName:11003598$.", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_16 : TriggerState {
            internal StateEventScene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, msg: "네. 분부대로.", duration: 2500, illustId: "Michael_normal",
                    align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuestComplete(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete : TriggerState {
            internal StateQuestComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg2: "trigger", arg3: "ForgottenrRoad");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWarp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020006, arg2: 6002);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200010},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestComplete(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}