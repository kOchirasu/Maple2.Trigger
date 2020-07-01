using System;

namespace Maple2.Trigger._52000085_qd {
    public static class _50001538 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State퀘스트체크(context);

        private class State퀘스트체크 : TriggerState {
            internal State퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50100280},
                    arg3: new byte[] {1})) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50100280},
                    arg3: new byte[] {2})) {
                    context.State = new State던전종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50100280},
                    arg3: new byte[] {3})) {
                    context.State = new State던전종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003}, arg2: false);
                context.SetPortal(arg1: 91, arg2: false, arg3: false, arg4: false);
                context.RemoveBuff(arg1: 199, arg2: 70000115);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 2000, enable: false);
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 999999999999f);
                context.SetSkip(arg1: "연출종료");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 300, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트루카대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사01 : TriggerState {
            internal State트루카대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__0$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사02 : TriggerState {
            internal State트루카대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__1$",
                    align: "left", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State에르다대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사01 : TriggerState {
            internal State에르다대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__2$", align: "right", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에르다대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사02 : TriggerState {
            internal State에르다대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003A");
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__3$", align: "right", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사03 : TriggerState {
            internal State트루카대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__4$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사04 : TriggerState {
            internal State트루카대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__5$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에르다대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사03 : TriggerState {
            internal State에르다대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__6$", align: "right", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트루카대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사05 : TriggerState {
            internal State트루카대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__7$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사06 : TriggerState {
            internal State트루카대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__8$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사07 : TriggerState {
            internal State트루카대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__9$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에르다대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사04 : TriggerState {
            internal State에르다대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__10$", align: "right", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State설눈이이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이이동01 : TriggerState {
            internal State설눈이이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State설눈이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사01 : TriggerState {
            internal State설눈이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__11$", align: "right", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State트루카대사08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사08 : TriggerState {
            internal State트루카대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003B");
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__12$",
                    align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트루카대사09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사09 : TriggerState {
            internal State트루카대사09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__13$",
                    align: "left", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State홀슈타트등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장 : TriggerState {
            internal State홀슈타트등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State홀슈타트대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트대사01 : TriggerState {
            internal State홀슈타트대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 307, arg2: true);
                context.AddCinematicTalk(npcID: 11004022, illustID: "11004022", msg: "$52000085_QD__50001538__14$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사10 : TriggerState {
            internal State트루카대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__15$",
                    align: "right", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State홀슈타트대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트대사02 : TriggerState {
            internal State홀슈타트대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: true);
                context.AddCinematicTalk(npcID: 11004022, illustID: "11004022", msg: "$52000085_QD__50001538__16$",
                    align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사11 : TriggerState {
            internal State트루카대사11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__17$",
                    align: "right", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State트루카대사12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트루카대사12 : TriggerState {
            internal State트루카대사12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 309, arg2: true);
                context.AddCinematicTalk(npcID: 11003071, illustID: "11003762", msg: "$52000085_QD__50001538__18$",
                    align: "right", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포털이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털이펙트 : TriggerState {
            internal State포털이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Bore_A");
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.AddCinematicTalk(npcID: 11004022, illustID: "11004022", msg: "$52000085_QD__50001538__19$",
                    align: "left", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateNPC합체(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC합체 : TriggerState {
            internal StateNPC합체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1099");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1099");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 600)) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1003, 1004});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State포털삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털삭제 : TriggerState {
            internal State포털삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State설눈이이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이이동02 : TriggerState {
            internal State설눈이이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 311, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State설눈이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사02 : TriggerState {
            internal State설눈이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__20$", align: "right", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에르다방향전환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다방향전환 : TriggerState {
            internal State에르다방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State에르다대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사05 : TriggerState {
            internal State에르다대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 312, arg2: true);
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__21$", align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State설눈이대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사03 : TriggerState {
            internal State설눈이대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__22$", align: "right", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State에르다대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사06 : TriggerState {
            internal State에르다대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1002, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.CameraSelect(arg1: 313, arg2: true);
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__23$", align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new int[] {1001, 1002, 1003, 1004});
                context.CreateMonster(arg1: new int[] {2001, 2002}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveUser(arg1: 52000085, arg2: 99);
                context.AddBuff(arg1: new int[] {199}, arg2: 70000115, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.CreateMonster(arg1: new int[] {2003, 2004, 2005}, arg2: false);
                    context.State = new State에르다사망대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다사망대기 : TriggerState {
            internal State에르다사망대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2002})) {
                    context.State = new State에르다사망딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다사망딜레이 : TriggerState {
            internal State에르다사망딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2003, 2004, 2005});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000085, arg2: 98);
                context.DestroyMonster(arg1: new int[] {2001, 2002});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State종료연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료연출시작 : TriggerState {
            internal State종료연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "종료연출종료");
                context.CreateMonster(arg1: new int[] {1005, 1006}, arg2: false);
                context.CameraSelect(arg1: 314, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State에르다대사07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다대사07 : TriggerState {
            internal State에르다대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__24$", align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State설눈이대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사04 : TriggerState {
            internal State설눈이대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__25$", align: "right", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State에르다공중부양준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다공중부양준비 : TriggerState {
            internal State에르다공중부양준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 315, arg2: true);
                context.SetNpcEmotionLoop(arg1: 1006, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcID: 11003069, illustID: "SnowQueen_normal",
                    msg: "$52000085_QD__50001538__26$", align: "left", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State에르다공중부양(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다공중부양 : TriggerState {
            internal State에르다공중부양(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006");
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__27$", align: "right", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State얼림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State얼림 : TriggerState {
            internal State얼림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Stun_A", arg3: 999999999999f);
                context.SetPcEmotionLoop(arg1: "StunFrozen_A", arg2: 25000f);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetEffect(arg1: new int[] {603}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State에르다공중부양중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에르다공중부양중 : TriggerState {
            internal State에르다공중부양중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 316, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StatePC말풍선대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사01 : TriggerState {
            internal StatePC말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1006});
                context.CameraSelect(arg1: 317, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000085_QD__50001538__28$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State설눈이말풍선대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이말풍선대사01 : TriggerState {
            internal State설눈이말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1007}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1005, arg3: "$52000085_QD__50001538__29$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC말풍선대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사02 : TriggerState {
            internal StatePC말풍선대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 318, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000085_QD__50001538__30$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State설만이이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설만이이동01 : TriggerState {
            internal State설만이이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1007, arg3: "$52000085_QD__50001538__31$", arg4: 5);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State설눈이인사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이인사 : TriggerState {
            internal State설눈이인사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Idle_A", arg3: 999999999999f);
                context.SetConversation(arg1: 1, arg2: 1005, arg3: "$52000085_QD__50001538__32$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State설만이이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설만이이동02 : TriggerState {
            internal State설만이이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005A");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC말풍선대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사03 : TriggerState {
            internal StatePC말풍선대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 1000f);
                context.MoveUserPath(arg1: "MS2PatrolData_PC2");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007C");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000085_QD__50001538__33$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State설만이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설만이대사01 : TriggerState {
            internal State설만이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "종료연출종료");
                context.CameraSelect(arg1: 319, arg2: true);
                context.AddCinematicTalk(npcID: 11003073, illustID: "11000404", msg: "$52000085_QD__50001538__34$",
                    align: "right", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State설눈이대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사05 : TriggerState {
            internal State설눈이대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__35$", align: "left", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State설만이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설만이대사02 : TriggerState {
            internal State설만이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003073, illustID: "11000404", msg: "$52000085_QD__50001538__36$",
                    align: "right", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State설눈이대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사06 : TriggerState {
            internal State설눈이대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__37$", align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State설눈이대사07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State설눈이대사07 : TriggerState {
            internal State설눈이대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003068, illustID: "Seolnunyi_normal",
                    msg: "$52000085_QD__50001538__38$", align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State종료연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료연출종료 : TriggerState {
            internal State종료연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Idle_A", arg3: 999999999999f);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 1000f);
                context.DestroyMonster(arg1: new int[] {1005, 1006, 1007});
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "snowqueenerda");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State던전종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1008, 1009}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetPortal(arg1: 91, arg2: true, arg3: true, arg4: true);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}