using System;

namespace Maple2.Trigger._52000115_qd {
    public static class _52000115 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSTART(context);

        private class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031,
                        4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047,
                        4048, 4049, 4050, 4051, 4052
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new int[] {3000}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기02 : TriggerState {
            internal State대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {2000, 2001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new Statecamera01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera01 : TriggerState {
            internal Statecamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2002, 2003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statecamera02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera02 : TriggerState {
            internal Statecamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2004, 2005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statecamera03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera03 : TriggerState {
            internal Statecamera03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2006, 2007}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_BlackMage");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new Statecamera05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera05 : TriggerState {
            internal Statecamera05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2008, 2009}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statecamera06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera06 : TriggerState {
            internal Statecamera06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2010, 2011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statecamera08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera07 : TriggerState {
            internal Statecamera07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2012, 2013}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statecamera08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera08 : TriggerState {
            internal Statecamera08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2014, 2015}, arg2: false);
                context.DestroyMonster(arg1: new int[] {200});
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new Statecamera08b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera08b : TriggerState {
            internal Statecamera08b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2016, 2017}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statecamera09_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera09_b : TriggerState {
            internal Statecamera09_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new Statecamera09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera09 : TriggerState {
            internal Statecamera09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2018}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Statecamera10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera10 : TriggerState {
            internal Statecamera10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2020, 2019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new Statecamera10_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera10_b : TriggerState {
            internal Statecamera10_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    context.State = new Statecamera11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera11 : TriggerState {
            internal Statecamera11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_blackfast.xml");
                context.SetEffect(arg1: new int[] {9001}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {2022, 2023}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new Statecamera12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera12 : TriggerState {
            internal Statecamera12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "SW_BG_Iceage_C.dds");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statecamera13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera13 : TriggerState {
            internal Statecamera13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.CameraSelectPath(arg1: new int[] {2024, 2025}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025
                    }, arg2: false, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(
                    arg1: new int[] {
                        4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041,
                        4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052
                    }, arg2: false, arg3: 0, arg4: 800, arg5: 1000f);
                context.SetBreakable(arg1: new int[] {3000}, arg2: true);
                context.CreateMonster(arg1: new int[] {204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new Statecamera14b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera14b : TriggerState {
            internal Statecamera14b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025
                    }, arg2: true, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(
                    arg1: new int[] {
                        4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041,
                        4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052
                    }, arg2: true, arg3: 0, arg4: 800, arg5: 1000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new Statecamera14c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera14c : TriggerState {
            internal Statecamera14c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025
                    }, arg2: false, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(
                    arg1: new int[] {
                        4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041,
                        4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052
                    }, arg2: false, arg3: 0, arg4: 800, arg5: 1000f);
                context.CameraSelectPath(arg1: new int[] {2026, 2027}, arg2: false);
                context.DestroyMonster(arg1: new int[] {204});
                context.CreateMonster(arg1: new int[] {205}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Statecamera15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera15 : TriggerState {
            internal Statecamera15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025
                    }, arg2: true, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(
                    arg1: new int[] {
                        4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041,
                        4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052
                    }, arg2: true, arg3: 0, arg4: 800, arg5: 1000f);
                context.CameraSelectPath(arg1: new int[] {2028, 2029, 2030, 2031}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new Statecamera16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera16 : TriggerState {
            internal Statecamera16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025
                    }, arg2: false, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(
                    arg1: new int[] {
                        4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041,
                        4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052
                    }, arg2: false, arg3: 0, arg4: 800, arg5: 1000f);
                context.CameraSelectPath(arg1: new int[] {2032, 2033}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Statecamera17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera17 : TriggerState {
            internal Statecamera17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statecamera18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera18 : TriggerState {
            internal Statecamera18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001811, msg: "$52000115_QD__52000115__0$", duration: 6000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Statecamera19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera19 : TriggerState {
            internal Statecamera19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 10)) {
                    context.State = new State기본종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 20)) {
                    context.State = new State버서커리스항구01(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 30)) {
                    context.State = new State트라이아도서관01(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 40)) {
                    context.MoveUser(arg1: 52000139, arg2: 1);
                }

                if (context.UserDetected(arg1: "199", arg2: 50)) {
                    context.State = new State기본종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 60)) {
                    context.State = new State기본종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 70)) {
                    context.State = new State기본종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 80)) {
                    context.State = new State기본종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 90)) {
                    context.State = new State기본종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트라이아도서관01 : TriggerState {
            internal State트라이아도서관01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000115_QD__52000115__1$",
                    desc: "$52000115_QD__52000115__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 10000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트라이아도서관02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트라이아도서관02 : TriggerState {
            internal State트라이아도서관02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000031, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State버서커리스항구01 : TriggerState {
            internal State버서커리스항구01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000115_QD__52000115__3$",
                    desc: "$52000115_QD__52000115__4$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 10000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State버서커리스항구02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버서커리스항구02 : TriggerState {
            internal State버서커리스항구02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State기본종료 : TriggerState {
            internal State기본종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}