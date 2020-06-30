using System;

namespace Maple2.Trigger._52010054_qd {
    public static class _52010054_qd {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "quit02", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4000, 4001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffect04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect04 : TriggerState {
            internal StateCameraEffect04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcID: 11003793, msg: "$52010054_QD__52010054_QD__0$", duration: 7000,
                    align: "right");
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: 0);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCameraEffect05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect05 : TriggerState {
            internal StateCameraEffect05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003793, msg: "$52010054_QD__52010054_QD__1$", duration: 5000,
                    align: "right");
                context.CameraSelectPath(arg1: new int[] {4004, 4005}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 2001, arg2: "Attack_01_C,Attack_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraEffect06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect06 : TriggerState {
            internal StateCameraEffect06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003793, msg: "$52010054_QD__52010054_QD__2$", duration: 4000,
                    align: "right");
                context.CameraSelectPath(arg1: new int[] {4006, 4007}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_B,Attack_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraEffect07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect07 : TriggerState {
            internal StateCameraEffect07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003793, msg: "$52010054_QD__52010054_QD__3$", duration: 4000,
                    align: "right");
                context.CameraSelectPath(arg1: new int[] {4008, 4009, 4013, 4014}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCameraEffect08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect08 : TriggerState {
            internal StateCameraEffect08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffect09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect09 : TriggerState {
            internal StateCameraEffect09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {2001}, arg2: false);
                context.DestroyMonster(arg1: new int[] {2002}, arg2: false);
                context.DestroyMonster(arg1: new int[] {2003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new StateCameraEffect10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect10 : TriggerState {
            internal StateCameraEffect10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CameraSelectPath(arg1: new int[] {4010, 4011}, arg2: 0);
                context.SetTimeScale(enable: true, startScale: 1.0f, endScale: 0.1f, duration: 12.0f, interpolator: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateCameraEffect11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect11 : TriggerState {
            internal StateCameraEffect11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateCameraEffect12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect12 : TriggerState {
            internal StateCameraEffect12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateCameraEffect13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect13 : TriggerState {
            internal StateCameraEffect13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 2000, arg2: "Attack_01_B,Attack_01_B");
                context.SetTimeScale(enable: true, startScale: 0.5f, endScale: 0.1f, duration: 12.0f, interpolator: 1);
                context.CameraSelectPath(arg1: new int[] {4012, 4015}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statequit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit01 : TriggerState {
            internal Statequit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statequit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit02 : TriggerState {
            internal Statequit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 02000422, arg2: 5);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}