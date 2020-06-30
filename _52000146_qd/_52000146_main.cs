using System;

namespace Maple2.Trigger._52000146_qd {
    public static class _52000146_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
                context.SetEffect(arg1: new int[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
                    context.State = new State잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기 : TriggerState {
            internal State잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State한번더대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State한번더대기 : TriggerState {
            internal State한번더대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라이동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동_01 : TriggerState {
            internal State카메라이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카메라이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동_02 : TriggerState {
            internal State카메라이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000146_QD__52000146_MAIN__0$",
                    desc: "$52000146_QD__52000146_MAIN__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 4000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카메라리셋_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_01 : TriggerState {
            internal State카메라리셋_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라리셋_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_02 : TriggerState {
            internal State카메라리셋_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라리셋_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_03 : TriggerState {
            internal State카메라리셋_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State걸으며대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_01 : TriggerState {
            internal State걸으며대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State걸으며대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_02 : TriggerState {
            internal State걸으며대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__2$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__3$", duration: 4000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State걸으며대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_03 : TriggerState {
            internal State걸으며대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__4$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State걸으며대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_04 : TriggerState {
            internal State걸으며대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__5$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State걸으며대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_05 : TriggerState {
            internal State걸으며대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__6$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State걸으며대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_06 : TriggerState {
            internal State걸으며대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__7$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State멈춰서대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State멈춰서대화_01 : TriggerState {
            internal State멈춰서대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투_01", arg2: "nextState");
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__8$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State멈춰서대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State멈춰서대화_02 : TriggerState {
            internal State멈춰서대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__9$", duration: 4000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_01 : TriggerState {
            internal State전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {102, 103, 104, 105, 106});
                context.CreateMonster(arg1: new int[] {107, 108, 109, 110, 111}, arg2: true);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.ShowGuideSummary(entityID: 25201461, textID: 25201461);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {107, 108, 109, 110, 111})) {
                    context.State = new State전투_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_02 : TriggerState {
            internal State전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {107, 108, 109, 110, 111}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {107, 108, 109, 110, 111})) {
                    context.State = new State전투종료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료_01 : TriggerState {
            internal State전투종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityID: 25201461);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투종료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료_02 : TriggerState {
            internal State전투종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000146, arg2: 99);
                context.DestroyMonster(arg1: new int[] {112});
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투종료_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료_03 : TriggerState {
            internal State전투종료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투후대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "스킵도착_01", arg2: "nextState");
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__10$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__11$", duration: 3000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_03 : TriggerState {
            internal State전투후대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__12$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_04 : TriggerState {
            internal State전투후대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__13$", duration: 3500,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_05 : TriggerState {
            internal State전투후대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__14$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_06 : TriggerState {
            internal State전투후대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003189, msg: "$52000146_QD__52000146_MAIN__15$", duration: 4000,
                    illustID: "Hastur_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_07 : TriggerState {
            internal State전투후대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_08(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {113});
            }
        }

        private class State전투후대화_08 : TriggerState {
            internal State전투후대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__16$", duration: 5000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투후대화_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵도착_01 : TriggerState {
            internal State스킵도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[] {113});
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State스킵도착_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵도착_02 : TriggerState {
            internal State스킵도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투후대화_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_09 : TriggerState {
            internal State전투후대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000146_QD__52000146_MAIN__17$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투후대화_10(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State전투후대화_10 : TriggerState {
            internal State전투후대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투후대화_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_11 : TriggerState {
            internal State전투후대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "하스터찾기_01", arg2: "nextState");
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__18$", duration: 4000,
                    align: "right");
                context.AddCinematicTalk(npcID: 0, msg: "$52000146_QD__52000146_MAIN__19$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new State하스터찾기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터찾기_01 : TriggerState {
            internal State하스터찾기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 25201462, textID: 25201462);
                context.SetEffect(arg1: new int[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702")) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25201462);
                context.MoveUser(arg1: 52000147, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}