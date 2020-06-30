using System;

namespace Maple2.Trigger._52010065_qd {
    public static class _52010065_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StatePC체크(context);

        private class StatePC체크 : TriggerState {
            internal StatePC체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.VisibleMyPc(isVisible: false);
                    context.State = new State준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비_01 : TriggerState {
            internal State준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(isVisible: true);
                context.SetProductionUI(arg1: 1);
                context.SetVisibleUI(
                    uiName:
                    "UpperHudDialog,MessengerBrowser,ExpBar,GroupMessengerBrowser,QuestGuideDialog,MinimapDialog,AdPushDialog,SnowmanEventDialog",
                    visible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비_02 : TriggerState {
            internal State준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser", visible: false);
                context.AddBuff(arg1: new int[] {701}, arg2: 99910320, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {701}, arg2: 99910320, arg3: 1, arg4: false, arg5: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016,
                        4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {91000076},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트완료_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {91000076},
                    arg3: new byte[] {2})) {
                    context.State = new State검마등장_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {91000076},
                    arg3: new byte[] {1})) {
                    context.State = new State검마등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마등장_01 : TriggerState {
            internal State검마등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State검마등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마등장_02 : TriggerState {
            internal State검마등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State검마등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마등장_03 : TriggerState {
            internal State검마등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벨라등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라등장_01 : TriggerState {
            internal State벨라등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State저멀리발록_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State저멀리발록_01 : TriggerState {
            internal State저멀리발록_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State저멀리발록_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State저멀리발록_02 : TriggerState {
            internal State저멀리발록_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
                context.SetSceneSkip(arg1: "스킵1_01", arg2: "nextState");
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State발록검마인사_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발록검마인사_01 : TriggerState {
            internal State발록검마인사_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003819, msg: "$52010065_QD__52010065_main__0$", duration: 3000,
                    illustID: "balrog_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State발록검마인사_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발록검마인사_02 : TriggerState {
            internal State발록검마인사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001811, msg: "$52010065_QD__52010065_main__1$", duration: 3000,
                    illustID: "BlackWizard_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State발록검마인사_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발록검마인사_03 : TriggerState {
            internal State발록검마인사_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003819, msg: "$52010065_QD__52010065_main__2$", duration: 3000,
                    illustID: "balrog_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State다리끊기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_01 : TriggerState {
            internal State다리끊기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다리끊기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_02 : TriggerState {
            internal State다리끊기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4003, 4006, 4010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_03 : TriggerState {
            internal State다리끊기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4004, 4005, 4014}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_04 : TriggerState {
            internal State다리끊기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4007, 4013, 4018}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_05 : TriggerState {
            internal State다리끊기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4009, 4015, 4022}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_06 : TriggerState {
            internal State다리끊기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4008, 4012, 4017}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_07 : TriggerState {
            internal State다리끊기_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4011, 4016, 4023}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_08 : TriggerState {
            internal State다리끊기_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4019, 4021, 4024}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    context.State = new State다리끊기_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리끊기_09 : TriggerState {
            internal State다리끊기_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4020, 4025}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State비웃는검마_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비웃는검마_01 : TriggerState {
            internal State비웃는검마_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State비웃는검마_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비웃는검마_02 : TriggerState {
            internal State비웃는검마_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001811, msg: "$52010065_QD__52010065_main__3$", duration: 3000,
                    illustID: "BlackWizard_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State비웃는검마_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비웃는검마_03 : TriggerState {
            internal State비웃는검마_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003820, msg: "$52010065_QD__52010065_main__4$", duration: 3000,
                    illustID: "Bella_normal", align: "left");
                context.AddCinematicTalk(npcID: 11001811, msg: "$52010065_QD__52010065_main__5$", duration: 3000,
                    illustID: "BlackWizard_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State용암건너기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵1_01 : TriggerState {
            internal State스킵1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018,
                        4019, 4020, 4021, 4022, 4023, 4024, 4025
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State용암건너기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State용암건너기_01 : TriggerState {
            internal State용암건너기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 1.0f);
                context.SetMesh(arg1: new int[] {4026}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State용암건너기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State용암건너기_02 : TriggerState {
            internal State용암건너기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25210651, textID: 25210651);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702")) {
                    context.State = new State용암건너기완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State용암건너기완료_01 : TriggerState {
            internal State용암건너기완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State용암건너기완료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State용암건너기완료_02 : TriggerState {
            internal State용암건너기완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010065, arg2: 11);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State퀘스트완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료_01 : TriggerState {
            internal State퀘스트완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityID: 25210651);
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {91000076},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트완료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료_02 : TriggerState {
            internal State퀘스트완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State검마퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마퇴장_01 : TriggerState {
            internal State검마퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8006}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.DestroyMonster(arg1: new int[] {103});
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.DestroyMonster(arg1: new int[] {104});
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State검마퇴장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마퇴장_02 : TriggerState {
            internal State검마퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State검마퇴장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마퇴장_03 : TriggerState {
            internal State검마퇴장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State검마퇴장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마퇴장_04 : TriggerState {
            internal State검마퇴장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8006, 8007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State검마퇴장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마퇴장_05 : TriggerState {
            internal State검마퇴장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8007, 8008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State검마퇴장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마퇴장_06 : TriggerState {
            internal State검마퇴장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001811, msg: "$52010065_QD__52010065_main__6$", duration: 3000,
                    align: "right");
                context.AddCinematicTalk(npcID: 11001811, msg: "$52010065_QD__52010065_main__7$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010061, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}