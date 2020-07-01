namespace Maple2.Trigger._52100105_qd {
    public static class _52100105_01 {
        public class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50101020},
                    arg3: new byte[] {2})) {
                    context.State = new Statewait_03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {50101030},
                    arg3: new byte[] {3})) {
                    context.State = new State장치가동_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_03 : TriggerState {
            internal Statewait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카_클라디아(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아 : TriggerState {
            internal State투르카_클라디아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State투르카_클라디아_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_02 : TriggerState {
            internal State투르카_클라디아_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카_클라디아_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_03 : TriggerState {
            internal State투르카_클라디아_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: "right",
                    msg: "$52100105_QD__52100105_01__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: "right",
                    msg: "$52100105_QD__52100105_01__1$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: "right",
                    msg: "$52100105_QD__52100105_01__2$", duration: 4000);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State투르카_클라디아_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_04 : TriggerState {
            internal State투르카_클라디아_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", align: "left",
                    msg: "$52100105_QD__52100105_01__3$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", align: "left",
                    msg: "$52100105_QD__52100105_01__4$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: "right",
                    msg: "$52100105_QD__52100105_01__5$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State투르카_클라디아_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_05 : TriggerState {
            internal State투르카_클라디아_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: "left",
                    msg: "$52100105_QD__52100105_01__6$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State장치가동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_01 : TriggerState {
            internal State장치가동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcRotation(arg1: 102, arg2: 270);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: "left",
                    msg: "$52100105_QD__52100105_01__7$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State장치가동_01_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_01_02 : TriggerState {
            internal State장치가동_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State장치가동_01_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_01_03 : TriggerState {
            internal State장치가동_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State장치가동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_02 : TriggerState {
            internal State장치가동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State장치가동_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_02_01 : TriggerState {
            internal State장치가동_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 102, arg2: 360);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Quest_Attack_A", arg3: 5000f);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", align: "right",
                    msg: "$52100105_QD__52100105_01__8$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State장치가동_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_03 : TriggerState {
            internal State장치가동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4002, 4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Quest_Effect_A", arg3: 12000f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State장치가동_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State장치가동_04 : TriggerState {
            internal State장치가동_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.DestroyMonster(arg1: new[] {102});
                context.DestroyMonster(arg1: new[] {103});
                context.DestroyMonster(arg1: new[] {104});
                context.DestroyMonster(arg1: new[] {105});
                context.DestroyMonster(arg1: new[] {106});
                context.DestroyMonster(arg1: new[] {107});
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52100110, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}