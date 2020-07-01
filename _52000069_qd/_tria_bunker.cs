namespace Maple2.Trigger._52000069_qd {
    public static class _tria_bunker {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.SetEffect(arg1: new[] {608}, arg2: false);
                context.SetEffect(arg1: new[] {609}, arg2: false);
                context.SetEffect(arg1: new[] {610}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetAgent(arg1: "8011", arg2: true);
                context.SetAgent(arg1: "8012", arg2: true);
                context.SetAgent(arg1: "8013", arg2: true);
                context.SetAgent(arg1: "8014", arg2: true);
                context.SetAgent(arg1: "8015", arg2: true);
                context.SetAgent(arg1: "8016", arg2: true);
                context.SetAgent(arg1: "8017", arg2: true);
                context.SetAgent(arg1: "8018", arg2: true);
                context.SetAgent(arg1: "8019", arg2: true);
                context.SetAgent(arg1: "8020", arg2: true);
                context.SetAgent(arg1: "8021", arg2: true);
                context.CreateMonster(arg1: new[] {1000, 1001, 1002, 1003}, arg2: false);
                context.CreateMonster(
                    arg1: new[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110}, arg2: false);
                context.CreateMonster(arg1: new[] {1201, 1202, 1203}, arg2: false);
                context.CreateMonster(arg1: new[] {2001, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108},
                    arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetSceneSkip(arg1: "연출종료");
                    context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                    context.State = new State카메라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddCinematicTalk(npcId: 11000064, illustId: "Lennon_normal",
                    msg: "$52000069_QD__TRIA_BUNKER__0$", duration: 9195, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.AddBuff(arg1: new[] {199}, arg2: 70000109, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003A");
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000069_QD__TRIA_BUNKER__1$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State2차연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차연출 : TriggerState {
            internal State2차연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 11100101, enable: true,
                    path: @"BG/Common/Sound/Eff_Object_Devlin_Appear_01.xml ");
                context.SetNpcEmotionSequence(arg1: 2001, arg2: "AttackReady_A");
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State프레이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이대사01 : TriggerState {
            internal State프레이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2003, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11000119, illustId: "Fray_serious",
                    msg: "$52000069_QD__TRIA_BUNKER__2$", duration: 4000, align: "center");
                context.SetSceneSkip(arg1: "대사스킵용01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State돌격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사스킵용01 : TriggerState {
            internal State대사스킵용01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State돌격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌격 : TriggerState {
            internal State돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.SetAgent(arg1: "8013", arg2: false);
                context.SetAgent(arg1: "8014", arg2: false);
                context.SetAgent(arg1: "8015", arg2: false);
                context.SetAgent(arg1: "8016", arg2: false);
                context.SetAgent(arg1: "8017", arg2: false);
                context.SetAgent(arg1: "8018", arg2: false);
                context.SetAgent(arg1: "8019", arg2: false);
                context.SetAgent(arg1: "8020", arg2: false);
                context.SetAgent(arg1: "8021", arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State지원군대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군대기 : TriggerState {
            internal State지원군대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 304, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State지원군등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군등장 : TriggerState {
            internal State지원군등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1201, 1202, 1203});
                context.DestroyMonster(arg1: new[] {2101, 2102, 2103});
                context.CreateMonster(arg1: new[] {1004, 1005, 1301, 1302, 1303, 1304}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State지원군연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군연출 : TriggerState {
            internal State지원군연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$52000069_QD__TRIA_BUNKER__3$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1005, arg3: "$52000069_QD__TRIA_BUNKER__4$", arg4: 4, arg5: 0);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005A");
                context.MoveNpc(arg1: 1301, arg2: "MS2PatrolData_1301A");
                context.MoveNpc(arg1: 1302, arg2: "MS2PatrolData_1302A");
                context.MoveNpc(arg1: 1303, arg2: "MS2PatrolData_1303A");
                context.MoveNpc(arg1: 1304, arg2: "MS2PatrolData_1304A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State임무종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State임무종료대기 : TriggerState {
            internal State임무종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.CameraSelect(arg1: 305, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State데블린사망딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State데블린사망딜레이 : TriggerState {
            internal State데블린사망딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateNPC교체(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000069, arg2: 2);
                context.CreateMonster(arg1: new[] {1006, 1007, 1009}, arg2: false);
                context.DestroyMonster(arg1: new[]
                    {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110});
                context.DestroyMonster(arg1: new[]
                    {1003, 1004, 1005, 1301, 1302, 1303, 1304, 2001, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State에레브연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브연출시작 : TriggerState {
            internal State에레브연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "NPC교체2", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 306, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State에레브대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브대사01 : TriggerState {
            internal State에레브대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(arg1: 1000, arg2: "Talk_A");
                context.SetSound(arg1: 90000, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52000069_QD__TRIA_BUNKER__5$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State에레브대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브대사02 : TriggerState {
            internal State에레브대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000069_QD__TRIA_BUNKER__6$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State에레브대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브대사03 : TriggerState {
            internal State에레브대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001975, arg3: "$52000069_QD__TRIA_BUNKER__7$", arg4: 4);
                context.SetOnetimeEffect(id: 1991, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_02_00001991.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브대사04 : TriggerState {
            internal State에레브대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 90000, arg2: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_surprise",
                    msg: "$52000069_QD__TRIA_BUNKER__8$", duration: 4000, align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아등장 : TriggerState {
            internal State마드리아등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CameraSelect(arg1: 307, arg2: true);
                context.CreateMonster(arg1: new[] {2000}, arg2: false, arg3: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State방향전환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방향전환 : TriggerState {
            internal State방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006A");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007A");
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_1009A");
                context.MoveUserPath(arg1: "MS2PatrolData_PCA");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State광역마법(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State광역마법 : TriggerState {
            internal State광역마법(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_2000A");
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetEffect(arg1: new[] {606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State처맞음(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처맞음 : TriggerState {
            internal State처맞음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetNpcEmotionSequence(arg1: 1006, arg2: "Damg_A");
                context.SetNpcEmotionSequence(arg1: 1007, arg2: "Damg_A");
                context.SetNpcEmotionSequence(arg1: 1009, arg2: "Damg_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    context.State = new State쓰러짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쓰러짐 : TriggerState {
            internal State쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1006, arg2: "Down_Idle_A", arg3: 999999999f);
                context.SetNpcEmotionLoop(arg1: 1007, arg2: "Down_Idle_A", arg3: 999999999f);
                context.SetNpcEmotionLoop(arg1: 1009, arg2: "Dead_Idle_A", arg3: 999999999f);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 12000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State쓰러짐2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쓰러짐2 : TriggerState {
            internal State쓰러짐2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002});
                context.CameraSelect(arg1: 309, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State마드리아워킹(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아워킹 : TriggerState {
            internal State마드리아워킹(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State마드리아오버숄더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아오버숄더 : TriggerState {
            internal State마드리아오버숄더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000069_QD__TRIA_BUNKER__9$", arg4: 7);
                context.SetOnetimeEffect(id: 1992, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_03_00001992.xml");
                context.CameraSelect(arg1: 310, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State마드리아공격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아공격 : TriggerState {
            internal State마드리아공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious",
                    msg: "$52000069_QD__TRIA_BUNKER__10$", duration: 3000, align: "center");
                context.CameraSelect(arg1: 311, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아공격2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아공격2 : TriggerState {
            internal State마드리아공격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000069_QD__TRIA_BUNKER__11$", arg4: 12);
                context.SetOnetimeEffect(id: 1993, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_04_00001993.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12500)) {
                    context.State = new State마드리아공격3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아공격3 : TriggerState {
            internal State마드리아공격3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000069_QD__TRIA_BUNKER__12$", arg4: 11);
                context.SetOnetimeEffect(id: 1994, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_05_00001994.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11200)) {
                    context.State = new State마드리아공격4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아공격4 : TriggerState {
            internal State마드리아공격4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000069_QD__TRIA_BUNKER__13$", arg4: 8);
                context.SetOnetimeEffect(id: 1995, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_06_00001995.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8100)) {
                    context.State = new State마드리아공격5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아공격5 : TriggerState {
            internal State마드리아공격5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1000, arg2: "Damg_A");
                context.CameraSelect(arg1: 315, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에레브각성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브각성 : TriggerState {
            internal State에레브각성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State에레브각성2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브각성2 : TriggerState {
            internal State에레브각성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1000, arg2: "Damg_Idle_B", arg3: 999999999f);
                context.CameraSelect(arg1: 312, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State마드리아놀람(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아놀람 : TriggerState {
            internal State마드리아놀람(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 314, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라눈속임(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라눈속임 : TriggerState {
            internal State카메라눈속임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 312, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State에레브버프2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브버프2 : TriggerState {
            internal State에레브버프2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 313, arg2: true);
                context.SetNpcEmotionSequence(arg1: 1000, arg2: "Spell_A");
                context.SetOnetimeEffect(id: 02100287, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter8_Destruction_of_Ereb_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State화이트아웃(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화이트아웃 : TriggerState {
            internal State화이트아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아대사01 : TriggerState {
            internal State마드리아대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000069_QD__TRIA_BUNKER__14$", arg4: 7);
                context.SetOnetimeEffect(id: 1996, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_07_00001996.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State마드리아대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아대사02 : TriggerState {
            internal State마드리아대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000069_QD__TRIA_BUNKER__15$", arg4: 3);
                context.SetOnetimeEffect(id: 1997, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_TriaSeige_08_00001997.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateNPC교체2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC교체2 : TriggerState {
            internal StateNPC교체2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveBuff(arg1: 199, arg2: 70000109);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Idle_A");
                context.DestroyMonster(arg1: new[] {1000, 1006, 1007, 1009, 2000, 1001, 1002});
                context.MoveUser(arg1: 52000069, arg2: 2);
                context.CreateMonster(arg1: new[] {1000, 1006, 1007, 1010, 1011, 1001, 1002, 9999}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 91000, arg2: "trigger", arg3: "TriaSeigeClear");
                context.SetSound(arg1: 90000, arg2: true);
                context.CameraSelect(arg1: 313, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}