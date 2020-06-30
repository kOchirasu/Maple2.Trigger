using System;

namespace Maple2.Trigger._52000200_qd {
    public static class _52000200 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2001")) {
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
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetQuestAccept(arg1: 10003419);
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_02 : TriggerState {
            internal StateCameraEffect02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000200_QD__52000200__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State여제알현(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여제알현 : TriggerState {
            internal State여제알현(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__1$", illustID: "Ereb_normal",
                    align: "left", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__2$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__3$", illustID: "Ereb_normal",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State여제알현_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여제알현_02 : TriggerState {
            internal State여제알현_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004, 4005}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__4$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__5$", illustID: "Ereb_normal",
                    align: "left", duration: 4500);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__6$", illustID: "Ereb_normal",
                    align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11500)) {
                    context.State = new State여제알현_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여제알현_03 : TriggerState {
            internal State여제알현_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__7$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__8$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__9$", illustID: "Ereb_surprise",
                    align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State여제알현_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여제알현_04 : TriggerState {
            internal State여제알현_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State여제알현_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여제알현_05 : TriggerState {
            internal State여제알현_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004782, msg: "$52000200_QD__52000200__10$", align: "left",
                    illustID: "Ruana_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__11$", align: "left",
                    illustID: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__12$", align: "right",
                    illustID: "Karl_normal", duration: 4500);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__13$", align: "right",
                    illustID: "Karl_normal", duration: 4500);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__14$", align: "left",
                    illustID: "Ereb_surprise", duration: 3000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__15$", align: "right",
                    illustID: "Karl_normal", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new State여제알현_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State여제알현_06 : TriggerState {
            internal State여제알현_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4007, 4008}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__16$", align: "left",
                    illustID: "Ereb_surprise", duration: 4500);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__17$", align: "right",
                    illustID: "Karl_normal", duration: 2800);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__18$", align: "right",
                    illustID: "Karl_normal", duration: 4500);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__19$", align: "left",
                    illustID: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__20$", align: "left",
                    illustID: "Ereb_closeEye", duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000200_QD__52000200__21$", align: "left",
                    illustID: "Ereb_closeEye", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__22$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 27800)) {
                    context.State = new State음모(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State음모 : TriggerState {
            internal State음모(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State음모_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State음모_02 : TriggerState {
            internal State음모_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000200_QD__52000200__23$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State음모_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State음모_03 : TriggerState {
            internal State음모_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11001975, msg: "$52000200_QD__52000200__24$", align: "left",
                    duration: 4500);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__25$", align: "right",
                    illustID: "Karl_normal", duration: 2800);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__26$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__27$", align: "right",
                    illustID: "Karl_normal", duration: 3000);
                context.AddCinematicTalk(npcID: 11000264, msg: "$52000200_QD__52000200__28$", align: "left",
                    illustID: "Radin_normal", duration: 4500);
                context.AddCinematicTalk(npcID: 11000264, msg: "$52000200_QD__52000200__29$", align: "left",
                    illustID: "Radin_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000200_QD__52000200__30$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11000264, msg: "$52000200_QD__52000200__31$", align: "left",
                    illustID: "Radin_normal", duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 29000)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52000190, arg2: 5001);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}