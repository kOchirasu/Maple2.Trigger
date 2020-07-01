namespace Maple2.Trigger._52100103_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetEffect(arg1: new[] {700}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작체크 : TriggerState {
            internal State연출시작체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10000}, arg2: new[] {50100960},
                    arg3: new byte[] {2})) {
                    context.State = new State연출시작준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작준비 : TriggerState {
            internal State연출시작준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1}, arg2: false);
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetEffect(arg1: new[] {700}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출NPC소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출NPC소환 : TriggerState {
            internal State연출NPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52100103, arg2: 3);
                context.CreateMonster(arg1: new[] {1000}, arg2: false);
                context.CreateMonster(arg1: new[] {2000}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작암전1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작암전1 : TriggerState {
            internal State시작암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100103, arg2: 3);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "엔딩암전", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State클라디아대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아대사1 : TriggerState {
            internal State클라디아대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
                context.CameraSelectPath(arg1: new[] {1000, 1001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2000, arg2: "Bore_A", arg3: 1333f);
                context.AddCinematicTalk(npcId: 11004419, msg: "$52100103_QD__MAIN__0$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네대사1 : TriggerState {
            internal State마를레네대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
                context.SetNpcEmotionLoop(arg1: 1000, arg2: "Talk_A", arg3: 1333f);
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__1$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State카메라흔들기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라흔들기 : TriggerState {
            internal State카메라흔들기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {700}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네대사2 : TriggerState {
            internal State마를레네대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {3}, arg2: false);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.SetNpcRotation(arg1: 1000, arg2: -45);
                context.SetNpcRotation(arg1: 2000, arg2: 45);
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__2$", duration: 2000, align: "left");
                context.AddCinematicTalk(npcId: 11004419, msg: "$52100103_QD__MAIN__3$", duration: 2000, align: "left");
                context.SetNpcEmotionLoop(arg1: 3, arg2: "Bore_A", arg3: 1333f);
                context.CameraSelect(arg1: 100, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대사1 : TriggerState {
            internal State투르카대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "PatrolData_PC_01");
                context.AddCinematicTalk(npcId: 11004430, msg: "$52100103_QD__MAIN__4$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC돌아보기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC돌아보기 : TriggerState {
            internal StatePC돌아보기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 200, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State포탈오픈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈오픈 : TriggerState {
            internal State포탈오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CameraSelect(arg1: 1002, arg2: true);
                context.CreateMonster(arg1: new[] {300}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사 : TriggerState {
            internal StatePC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__5$", duration: 3000, align: "left");
                context.MoveUser(arg1: 52100103, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카이동1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카이동1 : TriggerState {
            internal State투르카이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 300, arg2: "PatrolData_Turka_1");
                context.MoveNpc(arg1: 200, arg2: "PatrolData_200_1");
                context.MoveNpc(arg1: 201, arg2: "PatrolData_201_1");
                context.MoveNpc(arg1: 202, arg2: "PatrolData_202_1");
                context.MoveNpc(arg1: 203, arg2: "PatrolData_203_1");
                context.CameraSelect(arg1: 1003, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1000}, arg2: false);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.AddCinematicTalk(npcId: 11004430, msg: "$52100103_QD__MAIN__6$", duration: 3000, align: "left");
                context.MoveNpc(arg1: 1001, arg2: "PatrolData_1001_1");
                context.MoveNpc(arg1: 300, arg2: "PatrolData_Turka_2");
                context.MoveNpc(arg1: 200, arg2: "PatrolData_200_2");
                context.MoveNpc(arg1: 201, arg2: "PatrolData_201_2");
                context.MoveNpc(arg1: 202, arg2: "PatrolData_202_2");
                context.MoveNpc(arg1: 203, arg2: "PatrolData_203_2");
                context.MoveUserPath(arg1: "PatrolData_PC_02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC말풍선대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사 : TriggerState {
            internal StatePC말풍선대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52100103_QD__MAIN__7$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC공격자세(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC공격자세 : TriggerState {
            internal StatePC공격자세(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 30000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대사협박1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대사협박1 : TriggerState {
            internal State투르카대사협박1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 202, arg2: 45);
                context.SetNpcRotation(arg1: 201, arg2: -45);
                context.SetNpcRotation(arg1: 200, arg2: 15);
                context.SetNpcRotation(arg1: 203, arg2: -15);
                context.AddCinematicTalk(npcId: 11004430, msg: "$52100103_QD__MAIN__8$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 300, arg2: "Bore_A", arg3: 1333f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네협박(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네협박 : TriggerState {
            internal State마를레네협박(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__9$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Talk_A", arg3: 1333f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대사협박2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대사협박2 : TriggerState {
            internal State투르카대사협박2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004430, msg: "$52100103_QD__MAIN__10$", duration: 6000,
                    align: "left");
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__11$", duration: 2000,
                    align: "left");
                context.AddCinematicTalk(npcId: 11004430, msg: "$52100103_QD__MAIN__12$", duration: 3000,
                    align: "left");
                context.SetNpcEmotionLoop(arg1: 300, arg2: "Bore_A", arg3: 1333f);
                context.DestroyMonster(arg1: new[] {2000}, arg2: false);
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State클라디아대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아대사 : TriggerState {
            internal State클라디아대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "PatrolData_2001_1");
                context.AddCinematicTalk(npcId: 11004385, msg: "$52100103_QD__MAIN__13$", duration: 2000,
                    align: "left");
                context.AddCinematicTalk(npcId: 11004385, msg: "$52100103_QD__MAIN__14$", duration: 3500,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State마를레네대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네대사 : TriggerState {
            internal State마를레네대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__15$", duration: 2000,
                    align: "left");
                context.SetNpcRotation(arg1: 1001, arg2: 45);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State클라디아마를레네바라보기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아마를레네바라보기 : TriggerState {
            internal State클라디아마를레네바라보기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 2001, arg2: -90);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State클라디아대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아대사2 : TriggerState {
            internal State클라디아대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 2001, arg2: "Talk_A", arg3: 1333f);
                context.AddCinematicTalk(npcId: 11004385, msg: "$52100103_QD__MAIN__16$", duration: 4000,
                    align: "left");
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__17$", duration: 3000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대사3 : TriggerState {
            internal State투르카대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004430, msg: "$52100103_QD__MAIN__18$", duration: 3000,
                    align: "left");
                context.SetNpcEmotionLoop(arg1: 300, arg2: "Bore_A", arg3: 1333f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State클라디아퇴장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아퇴장 : TriggerState {
            internal State클라디아퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CameraSelect(arg1: 1004, arg2: true);
                context.MoveNpc(arg1: 2001, arg2: "PatrolData_2001_2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부하퇴장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부하퇴장 : TriggerState {
            internal State부하퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "PatrolData_200_3");
                context.MoveNpc(arg1: 201, arg2: "PatrolData_201_3");
                context.MoveNpc(arg1: 202, arg2: "PatrolData_202_3");
                context.MoveNpc(arg1: 203, arg2: "PatrolData_203_3");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카퇴장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카퇴장 : TriggerState {
            internal State투르카퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 300, arg2: "PatrolData_Turka_3");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네엔딩대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네엔딩대사 : TriggerState {
            internal State마를레네엔딩대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1005, 1006}, arg2: false);
                context.AddCinematicTalk(npcId: 11004395, msg: "$52100103_QD__MAIN__19$", duration: 2000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩암전 : TriggerState {
            internal State엔딩암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터정리 : TriggerState {
            internal State몬스터정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State상황정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상황정리 : TriggerState {
            internal State상황정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100109, arg2: 2);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네생성준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네생성준비 : TriggerState {
            internal State마를레네생성준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네생성 : TriggerState {
            internal State마를레네생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetEffect(arg1: new[] {700}, arg2: false);
                context.CreateMonster(arg1: new[] {1}, arg2: false);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}