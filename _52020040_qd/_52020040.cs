using System;
using System.Numerics;

namespace Maple2.Trigger._52020040_qd {
    public static class _52020040 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2001")) {
                    context.State = new Statewait_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_02 : TriggerState {
            internal Statewait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_03 : TriggerState {
            internal Statewait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, agr2: false);
                context.CreateMonster(arg1: new int[] {102}, agr2: false);
                context.CreateMonster(arg1: new int[] {103}, agr2: false);
                context.CreateMonster(arg1: new int[] {104}, agr2: false);
                context.CreateMonster(arg1: new int[] {105}, agr2: false);
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52020040, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State크리티아스로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크리티아스로 : TriggerState {
            internal State크리티아스로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State크리티아스로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_02 : TriggerState {
            internal State크리티아스로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003, 4004, 4005}, arg2: 0);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_B", arg3: 99999999999f);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "left",
                    msg: "$52020040_QD__52020040__0$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_smile", align: "right",
                    msg: "$52020040_QD__52020040__1$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "left",
                    msg: "$52020040_QD__52020040__2$", duration: 3000);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State크리티아스로_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_02_01 : TriggerState {
            internal State크리티아스로_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
                context.ShowCaption(type: "HorizonCaption", title: "$52020040_QD__52020040__3$", align: "bottomLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State크리티아스로_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_03 : TriggerState {
            internal State크리티아스로_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004436, illustID: "Schatten_smile", align: "left",
                    msg: "$52020040_QD__52020040__4$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004438, illustID: "Mason_closeEye", align: "right",
                    msg: "$52020040_QD__52020040__5$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004435, illustID: "Conder_smile", align: "left",
                    msg: "$52020040_QD__52020040__6$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State크리티아스로_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_04 : TriggerState {
            internal State크리티아스로_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(arg1: new Vector3(41f, 21f, 18f), arg2: new Vector3(130f, 130f, 130f));
                context.AddCinematicTalk(npcID: 11004435, illustID: "Conder_normal", align: "left",
                    msg: "$52020040_QD__52020040__7$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State경보(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State경보_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보_01 : TriggerState {
            internal State경보_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__8$", duration: 2500);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__9$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "right",
                    msg: "$52020040_QD__52020040__10$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__11$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "right",
                    msg: "$52020040_QD__52020040__12$", duration: 2400);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__13$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_mad", align: "right",
                    msg: "$52020040_QD__52020040__14$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__15$", duration: 2400);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 21300)) {
                    context.State = new State경보_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보_02 : TriggerState {
            internal State경보_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009, 4010}, arg2: 0);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.AddCinematicTalk(npcID: 11004440, msg: "$52020040_QD__52020040__16$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004440, msg: "$52020040_QD__52020040__17$", duration: 5000);
                context.AddCinematicTalk(npcID: 11004440, msg: "$52020040_QD__52020040__18$", duration: 2600);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10200)) {
                    context.State = new State경보끝_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보끝_01 : TriggerState {
            internal State경보끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetAmbientLight(arg1: new Vector3(131f, 160f, 209f));
                context.SetDirectionalLight(arg1: new Vector3(134f, 160f, 143f), arg2: new Vector3(130f, 130f, 130f));
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.AddCinematicTalk(npcID: 11004435, illustID: "Conder_normal", align: "right",
                    msg: "$52020040_QD__52020040__19$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State경보끝_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보끝_02_01 : TriggerState {
            internal State경보끝_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State경보끝_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보끝_02_02 : TriggerState {
            internal State경보끝_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State경보끝_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보끝_02 : TriggerState {
            internal State경보끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__20$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__21$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__22$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "right",
                    msg: "$52020040_QD__52020040__23$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "right",
                    msg: "$52020040_QD__52020040__24$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_surprise", align: "left",
                    msg: "$52020040_QD__52020040__25$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004435, illustID: "Conder_normal", align: "right",
                    msg: "$52020040_QD__52020040__26$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004436, illustID: "Schatten_surprise", align: "left",
                    msg: "$52020040_QD__52020040__27$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004435, illustID: "Conder_normal", align: "right",
                    msg: "$52020040_QD__52020040__28$", duration: 2500);
                context.AddCinematicTalk(npcID: 11004438, illustID: "Mason_normal", align: "left",
                    msg: "$52020040_QD__52020040__29$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "right",
                    msg: "$52020040_QD__52020040__30$", duration: 2500);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "right",
                    msg: "$52020040_QD__52020040__31$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004438, illustID: "Mason_normal", align: "left",
                    msg: "$52020040_QD__52020040__32$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$52020040_QD__52020040__33$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 37800)) {
                    context.State = new State경보끝_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보끝_03 : TriggerState {
            internal State경보끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011, 4013}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004438, illustID: "Mason_normal", msg: "$52020040_QD__52020040__34$",
                    align: "left", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$52020040_QD__52020040__35$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$52020040_QD__52020040__36$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004436, illustID: "Schatten_surprise", align: "left",
                    msg: "$52020040_QD__52020040__37$", duration: 3500);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_normal", align: "right",
                    msg: "$52020040_QD__52020040__38$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$52020040_QD__52020040__39$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_closeEye", align: "left",
                    msg: "$52020040_QD__52020040__40$", duration: 2800);
                context.AddCinematicTalk(npcID: 11004437, illustID: "Neirin_normal", align: "right",
                    msg: "$52020040_QD__52020040__41$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_closeEye", align: "left",
                    msg: "$52020040_QD__52020040__42$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004434, illustID: "Bliche_normal", align: "left",
                    msg: "$52020040_QD__52020040__43$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$52020040_QD__52020040__44$", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 33200)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_02 : TriggerState {
            internal State이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020029, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}