namespace Maple2.Trigger._52000115_qd {
    public static class _52000115 {
        public class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateWait01(context);
            }

            public override void OnExit() { }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {9001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {3000}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CameraSelectPath(arg1: new[] {2000, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new StateCamera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera01 : TriggerState {
            internal StateCamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2002, 2003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera02 : TriggerState {
            internal StateCamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2004, 2005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera03 : TriggerState {
            internal StateCamera03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2006, 2007}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_BlackMage");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCamera05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera05 : TriggerState {
            internal StateCamera05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2008, 2009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera06 : TriggerState {
            internal StateCamera06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2010, 2011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera07 : TriggerState {
            internal StateCamera07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2012, 2013}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera08 : TriggerState {
            internal StateCamera08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2014, 2015}, arg2: false);
                context.DestroyMonster(arg1: new[] {200});
                context.CreateMonster(arg1: new[] {203}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCamera08b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera08b : TriggerState {
            internal StateCamera08b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2016, 2017}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateCamera09_b(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera09_b : TriggerState {
            internal StateCamera09_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateCamera09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera09 : TriggerState {
            internal StateCamera09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2018}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateCamera10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera10 : TriggerState {
            internal StateCamera10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2020, 2019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCamera10_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera10_b : TriggerState {
            internal StateCamera10_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    return new StateCamera11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera11 : TriggerState {
            internal StateCamera11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_blackfast.xml");
                context.SetEffect(arg1: new[] {9001}, arg2: true);
                context.CameraSelectPath(arg1: new[] {2022, 2023}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateCamera12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera12 : TriggerState {
            internal StateCamera12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "SW_BG_Iceage_C.dds");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera13 : TriggerState {
            internal StateCamera13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.CameraSelectPath(arg1: new[] {2024, 2025}, arg2: false);
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025}, arg2: false, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(arg1: new[] {4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052}, arg2: false, arg3: 0, arg4: 800, arg5: 1000f);
                context.SetBreakable(arg1: new[] {3000}, arg2: true);
                context.CreateMonster(arg1: new[] {204}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCamera14b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera14b : TriggerState {
            internal StateCamera14b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025}, arg2: true, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(arg1: new[] {4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052}, arg2: true, arg3: 0, arg4: 800, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateCamera14c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera14c : TriggerState {
            internal StateCamera14c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025}, arg2: false, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(arg1: new[] {4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052}, arg2: false, arg3: 0, arg4: 800, arg5: 1000f);
                context.CameraSelectPath(arg1: new[] {2026, 2027}, arg2: false);
                context.DestroyMonster(arg1: new[] {204});
                context.CreateMonster(arg1: new[] {205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCamera15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera15 : TriggerState {
            internal StateCamera15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025}, arg2: true, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(arg1: new[] {4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052}, arg2: true, arg3: 0, arg4: 800, arg5: 1000f);
                context.CameraSelectPath(arg1: new[] {2028, 2029, 2030, 2031}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateCamera16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera16 : TriggerState {
            internal StateCamera16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025}, arg2: false, arg3: 0, arg4: 500, arg5: 1000f);
                context.SetMesh(arg1: new[] {4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052}, arg2: false, arg3: 0, arg4: 800, arg5: 1000f);
                context.CameraSelectPath(arg1: new[] {2032, 2033}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCamera17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera17 : TriggerState {
            internal StateCamera17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera18 : TriggerState {
            internal StateCamera18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001811, msg: "$52000115_QD__52000115__0$", duration: 6000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCamera19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera19 : TriggerState {
            internal StateCamera19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 10)) {
                    return new State기본종료(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 20)) {
                    return new State버서커리스항구01(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 30)) {
                    return new State트라이아도서관01(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 40)) {
                    context.MoveUser(arg1: 52000139, arg2: 1);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 50)) {
                    return new State기본종료(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 60)) {
                    return new State기본종료(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 70)) {
                    return new State기본종료(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 80)) {
                    return new State기본종료(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 90)) {
                    return new State기본종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트라이아도서관01 : TriggerState {
            internal State트라이아도서관01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000115_QD__52000115__1$", desc: "$52000115_QD__52000115__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트라이아도서관02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트라이아도서관02 : TriggerState {
            internal State트라이아도서관02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000031, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State버서커리스항구01 : TriggerState {
            internal State버서커리스항구01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000115_QD__52000115__3$", desc: "$52000115_QD__52000115__4$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버서커리스항구02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버서커리스항구02 : TriggerState {
            internal State버서커리스항구02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State기본종료 : TriggerState {
            internal State기본종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}