namespace Maple2.Trigger._52000151_qd {
    public static class _52000151 {
        public class Statewait : TriggerState {
            internal Statewait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001642},
                    arg3: new byte[] {1})) {
                    context.State = new State생명의틈으로01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {3})) {
                    context.State = new State생틈퀘수령전대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {2})) {
                    context.State = new State생틈퀘수령전대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {1})) {
                    context.State = new State파토스등장연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_2 : TriggerState {
            internal Statewait_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {10010})) {
                    context.State = new State파토스등장연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생틈퀘수령전대기 : TriggerState {
            internal State생틈퀘수령전대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Event_01_A", arg3: 999999f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001642},
                    arg3: new byte[] {1})) {
                    context.State = new State생명의틈으로01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출01 : TriggerState {
            internal State파토스등장연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Stun_A", arg3: 999999f);
                context.FaceEmotion(spawnPointId: 201, emotionName: "Concerned");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State파토스등장연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출02 : TriggerState {
            internal State파토스등장연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "exit");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State파토스등장연출02_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출02_B : TriggerState {
            internal State파토스등장연출02_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3000, 3001}, arg2: false);
                context.SetEffect(arg1: new[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107}, arg2: true, arg3: 0,
                    arg4: 100);
                context.SetEffect(arg1: new[] {1200, 1201, 1202, 1203, 1204, 1205, 1206}, arg2: true, arg3: 0,
                    arg4: 100);
                context.SetEffect(
                    arg1: new[] {1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311},
                    arg2: true, arg3: 0, arg4: 100);
                context.SetEffect(arg1: new[] {1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409},
                    arg2: true, arg3: 0, arg4: 100);
                context.SetEffect(arg1: new[] {1500, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: true,
                    arg3: 0, arg4: 100);
                context.SetEffect(arg1: new[] {1600, 1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608}, arg2: true,
                    arg3: 0, arg4: 100);
                context.SetEffect(arg1: new[] {1700, 1701, 1702, 1703, 1704}, arg2: true, arg3: 0, arg4: 100);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출03 : TriggerState {
            internal State파토스등장연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003439, illustId: "0", msg: "$52000151_QD__52000151__0$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7000, 7001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출04 : TriggerState {
            internal State파토스등장연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "0", msg: "$52000151_QD__52000151__1$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7002, 7003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출05 : TriggerState {
            internal State파토스등장연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__2$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7004, 7005}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출06 : TriggerState {
            internal State파토스등장연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__3$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7006, 7007}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_patos_come");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출08 : TriggerState {
            internal State파토스등장연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__4$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7008, 7009}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출09 : TriggerState {
            internal State파토스등장연출09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "0", msg: "$52000151_QD__52000151__5$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7010, 7011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출10 : TriggerState {
            internal State파토스등장연출10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003439, illustId: "0", msg: "$52000151_QD__52000151__6$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7000, 7001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출12 : TriggerState {
            internal State파토스등장연출12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003439, illustId: "0", msg: "$52000151_QD__52000151__7$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7012, 7013, 7014, 7015}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출13 : TriggerState {
            internal State파토스등장연출13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__8$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7016, 7017}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State파토스등장연출14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출14 : TriggerState {
            internal State파토스등장연출14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__9$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State파토스등장연출15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출15 : TriggerState {
            internal State파토스등장연출15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__10$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7018, 7019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State파토스등장연출16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출16 : TriggerState {
            internal State파토스등장연출16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__11$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State파토스등장연출17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출17 : TriggerState {
            internal State파토스등장연출17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__12$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State파토스등장연출18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출18 : TriggerState {
            internal State파토스등장연출18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__13$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7020, 7021}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_patos_exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State파토스등장연출19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출19 : TriggerState {
            internal State파토스등장연출19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__14$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7022, 7023}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_patos_turn");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출20 : TriggerState {
            internal State파토스등장연출20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", msg: "$52000151_QD__52000151__15$",
                    duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {7024, 7025}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출21 : TriggerState {
            internal State파토스등장연출21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State파토스등장연출22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출22 : TriggerState {
            internal State파토스등장연출22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_anosTurn");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State파토스등장연출23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파토스등장연출23 : TriggerState {
            internal State파토스등장연출23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetAchievement(arg1: 10010, arg2: "trigger", arg3: "ProtectFinish");
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Event_01_A", arg3: 999999f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSound(arg1: 9000, arg2: true);
                context.DestroyMonster(arg1: new[] {203});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001642},
                    arg3: new byte[] {1})) {
                    context.State = new State생명의틈으로01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Event_01_A", arg3: 999999f);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSound(arg1: 9000, arg2: true);
                context.DestroyMonster(arg1: new[] {203});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSkip_1_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1_1 : TriggerState {
            internal StateSkip_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 10010, arg2: "trigger", arg3: "ProtectFinish");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001642},
                    arg3: new byte[] {1})) {
                    context.State = new State생명의틈으로01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생명의틈으로01 : TriggerState {
            internal State생명의틈으로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000172, arg2: 21002);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}