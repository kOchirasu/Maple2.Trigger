using System;

namespace Maple2.Trigger._52100208_qd {
    public static class _52100208 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003300},
                    arg3: new byte[] {2})) {
                    context.State = new Statewait_01_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_02 : TriggerState {
            internal Statewait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52100208, arg2: 5001);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.DestroyMonster(arg1: new int[] {201, 202, 203, 204, 205, 206, 207, 208, 209});
                context.CreateMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {203});
                context.CreateMonster(arg1: new int[] {204});
                context.CreateMonster(arg1: new int[] {205});
                context.CreateMonster(arg1: new int[] {206});
                context.CreateMonster(arg1: new int[] {207});
                context.CreateMonster(arg1: new int[] {208});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면 : TriggerState {
            internal State투르카대면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대면_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_02 : TriggerState {
            internal State투르카대면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11004678, illustID: "Neirin_surprise", align: "left",
                    msg: "$52100208_QD__52100208__0$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004675, illustID: "Bliche_mad", align: "right",
                    msg: "$52100208_QD__52100208__1$", duration: 4500);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new StatePC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcID: 0, msg: "$52100208_QD__52100208__2$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State투르카대면_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_02_01 : TriggerState {
            internal State투르카대면_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__3$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State투르카대면_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_03 : TriggerState {
            internal State투르카대면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "$52100208_QD__52100208__4$", duration: 2500);
                context.AddCinematicTalk(npcID: 0, msg: "$52100208_QD__52100208__5$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State투르카대면_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_04 : TriggerState {
            internal State투르카대면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004, 4005, 4006}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State투르카대면_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_05 : TriggerState {
            internal State투르카대면_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {209}, agr2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State투르카대면_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_06 : TriggerState {
            internal State투르카대면_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52100208_QD__52100208__6$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State투르카대면_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_07 : TriggerState {
            internal State투르카대면_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
                context.MoveNpc(arg1: 209, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__7$", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State투르카대면_07_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_07_01 : TriggerState {
            internal State투르카대면_07_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4020}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 208, arg2: "Attack_Idle_A", arg3: 100000000f);
                context.AddCinematicTalk(npcID: 11004682, illustID: "ArcaneBlader_unfair", align: "right",
                    msg: "$52100208_QD__52100208__8$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004680, illustID: "Eone_serious", align: "right",
                    msg: "$52100208_QD__52100208__9$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State투르카대면_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_08 : TriggerState {
            internal State투르카대면_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008, 4009}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__10$", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State투르카대면_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_09 : TriggerState {
            internal State투르카대면_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 209, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__11$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State투르카대면_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_10 : TriggerState {
            internal State투르카대면_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11004675, illustID: "Bliche_mad", align: "right",
                    msg: "$52100208_QD__52100208__12$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004588, illustID: "Conder_normal", align: "left",
                    msg: "$52100208_QD__52100208__13$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State투르카대면_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_11 : TriggerState {
            internal State투르카대면_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011, 4012}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__14$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State투르카대면_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_12 : TriggerState {
            internal State투르카대면_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 209, arg2: "Bore_B");
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__15$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State투르카대면_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13 : TriggerState {
            internal State투르카대면_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014, 4015}, arg2: 0);
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
                context.AddCinematicTalk(npcID: 0, msg: "$52100208_QD__52100208__16$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State투르카대면_13_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_02 : TriggerState {
            internal State투르카대면_13_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4016}, arg2: 0);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_3003");
                context.AddCinematicTalk(npcID: 11004588, illustID: "Conder_normal", align: "right",
                    msg: "$52100208_QD__52100208__17$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004588, illustID: "Conder_normal", align: "right",
                    msg: "$52100208_QD__52100208__18$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State투르카대면_13_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_03 : TriggerState {
            internal State투르카대면_13_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__19$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State투르카대면_13_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_04 : TriggerState {
            internal State투르카대면_13_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 209, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대면_13_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_05 : TriggerState {
            internal State투르카대면_13_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.SetEffect(arg1: new int[] {6003}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Stun_A", arg3: 99999999f);
                context.AddCinematicTalk(npcID: 11004588, illustID: "0", msg: "$52100208_QD__52100208__20$",
                    duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State투르카대면_13_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_06 : TriggerState {
            internal State투르카대면_13_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_3004");
                context.AddCinematicTalk(npcID: 11004678, illustID: "Neirin_surprise", align: "left",
                    msg: "$52100208_QD__52100208__21$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004677, illustID: "Schatten_surprise", align: "right",
                    msg: "$52100208_QD__52100208__22$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State투르카대면_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_14 : TriggerState {
            internal State투르카대면_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004683, msg: "$52100208_QD__52100208__23$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State투르카대면_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_15 : TriggerState {
            internal State투르카대면_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6002}, arg2: true);
                context.DestroyMonster(arg1: new int[] {209}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State투르카대면_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대면_16 : TriggerState {
            internal State투르카대면_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52100208_QD__52100208__24$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004679, illustID: "Mason_closeEye", align: "right",
                    msg: "$52100208_QD__52100208__25$", duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State정리_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State정리_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State정리_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_03 : TriggerState {
            internal State정리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020071, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}