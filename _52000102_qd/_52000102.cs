using System;

namespace Maple2.Trigger._52000102_qd {
    public static class _52000102 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new State입장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장01 : TriggerState {
            internal State입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walk01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State입장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장02 : TriggerState {
            internal State입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4010, 4011}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State입장03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장03 : TriggerState {
            internal State입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State입장04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장04 : TriggerState {
            internal State입장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000102, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {20002292},
                    arg3: new byte[] {3})) {
                    context.State = new StatePC화남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남01 : TriggerState {
            internal StatePC화남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "PC화남12", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000102, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePC화남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남02 : TriggerState {
            internal StatePC화남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_Trun");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcID: 11003148, illustID: "Anos_normal", msg: "$52000102_QD__52000102__0$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new int[] {4000, 4001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePC화남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남03 : TriggerState {
            internal StatePC화남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003148, illustID: "Anos_normal", msg: "$52000102_QD__52000102__1$",
                    duration: 2000, align: "right");
                context.SetSound(arg1: 9005, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC화남04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남04 : TriggerState {
            internal StatePC화남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "$52000102_QD__52000102__2$", duration: 2000, align: "right");
                context.FaceEmotion(spawnPointID: 0, emotionName: "PC_OutOfMind_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC화남04B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남04B : TriggerState {
            internal StatePC화남04B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Dead_A");
                context.FaceEmotion(spawnPointID: 0, emotionName: "PC_OutOfMind_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC화남05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남05 : TriggerState {
            internal StatePC화남05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "$52000102_QD__52000102__3$", duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePC화남06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남06 : TriggerState {
            internal StatePC화남06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "$52000102_QD__52000102__4$", duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePC화남08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남08 : TriggerState {
            internal StatePC화남08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003149, illustID: "Asimov_normal", msg: "$52000102_QD__52000102__5$",
                    duration: 3000, align: "right");
                context.FaceEmotion(spawnPointID: 0, emotionName: "ChaosMod_Start");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC화남09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남09 : TriggerState {
            internal StatePC화남09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006, 4007}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "$52000102_QD__52000102__6$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC화남10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남10 : TriggerState {
            internal StatePC화남10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StatePC화남11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남11 : TriggerState {
            internal StatePC화남11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.ShowCaption(type: "VerticalCaption", title: "$52000102_QD__52000102__7$",
                    desc: "$52000102_QD__52000102__8$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 10000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePC화남11_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남11_1 : TriggerState {
            internal StatePC화남11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC화남12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC화남12 : TriggerState {
            internal StatePC화남12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000115, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}