namespace Maple2.Trigger._52000192_qd {
    public static class _52000192 {
        public class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(arg1: new[] {6001, 6002, 6003, 6004}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001453, 10001454, 10001455, 10001456}, arg2: 2);
                context.SetPortal(arg1: 5003, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003423}, arg3: new byte[] {1})) {
                    context.State = new Statewait_01_02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003423}, arg3: new byte[] {1})) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_02 : TriggerState {
            internal Statewait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_01_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_03 : TriggerState {
            internal Statewait_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000192, arg2: 5001);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.CreateMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State불난통로_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불난통로_01 : TriggerState {
            internal State불난통로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State불난통로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불난통로_02 : TriggerState {
            internal State불난통로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004785, msg: "$52000192_QD__52000192__0$", align: "left", illustId: "Ereb_surprise", duration: 4000);
                context.CameraSelectPath(arg1: new[] {4002, 4003}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State불난통로_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불난통로_03 : TriggerState {
            internal State불난통로_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 0, msg: "$52000192_QD__52000192__1$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State불난통로_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불난통로_04 : TriggerState {
            internal State불난통로_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000192_QD__52000192__2$", duration: 5000);
                context.AddCinematicTalk(npcId: 11004787, msg: "$52000192_QD__52000192__3$", align: "left", illustId: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State불끄기준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불끄기준비 : TriggerState {
            internal State불끄기준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State불끄기준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State불끄기준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불끄기준비_02 : TriggerState {
            internal State불끄기준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104});
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001453}, arg2: 1);
                context.MoveUser(arg1: 52000192, arg2: 5002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State불꺼라불꺼(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼 : TriggerState {
            internal State불꺼라불꺼(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SideNpcTalk(type: "talk", npcId: 11004787, illust: "Baron_normal", script: "$52000192_QD__52000192__4$", duration: 3000);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001453}, arg2: 0)) {
                    context.State = new State불꺼라불꺼_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_02 : TriggerState {
            internal State불꺼라불꺼_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.AddBalloonTalk(spawnPointId: 104, msg: "$52000192_QD__52000192__5$", duration: 4000);
                context.SetEffect(arg1: new[] {6021}, arg2: false);
                context.SetEffect(arg1: new[] {6005, 6006, 6007, 6008}, arg2: true);
                context.CreateMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203});
                context.CreateMonster(arg1: new[] {204});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State불꺼라불꺼_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_02_02 : TriggerState {
            internal State불꺼라불꺼_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004787, msg: "$52000192_QD__52000192__6$", illust: "Baron_normal", align: "left", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State불꺼라불꺼_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_02_01 : TriggerState {
            internal State불꺼라불꺼_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204})) {
                    context.State = new State불꺼라불꺼_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_03 : TriggerState {
            internal State불꺼라불꺼_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 104, msg: "$52000192_QD__52000192__7$", duration: 4000);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3001");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State불꺼라불꺼_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_04 : TriggerState {
            internal State불꺼라불꺼_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001454}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001454}, arg2: 0)) {
                    context.State = new State불꺼라불꺼_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_05 : TriggerState {
            internal State불꺼라불꺼_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 104, msg: "$52000192_QD__52000192__8$", duration: 4000);
                context.SetEffect(arg1: new[] {6022}, arg2: false);
                context.SetEffect(arg1: new[] {6009, 6010, 6011, 6012}, arg2: true);
                context.CreateMonster(arg1: new[] {205});
                context.CreateMonster(arg1: new[] {206});
                context.CreateMonster(arg1: new[] {207});
                context.CreateMonster(arg1: new[] {208});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {205, 206, 207, 208})) {
                    context.State = new State불꺼라불꺼_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_06 : TriggerState {
            internal State불꺼라불꺼_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 104, msg: "$52000192_QD__52000192__9$", duration: 4000);
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State불꺼라불꺼_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_07 : TriggerState {
            internal State불꺼라불꺼_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001455}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001455}, arg2: 0)) {
                    context.State = new State불꺼라불꺼_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_08 : TriggerState {
            internal State불꺼라불꺼_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 104, msg: "$52000192_QD__52000192__10$", duration: 4000);
                context.SetEffect(arg1: new[] {6023}, arg2: false);
                context.SetEffect(arg1: new[] {6013, 6014, 6015, 6016}, arg2: true);
                context.CreateMonster(arg1: new[] {209});
                context.CreateMonster(arg1: new[] {210});
                context.CreateMonster(arg1: new[] {211});
                context.CreateMonster(arg1: new[] {212});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {209, 210, 211, 212})) {
                    context.State = new State불꺼라불꺼_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_09 : TriggerState {
            internal State불꺼라불꺼_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3005");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State불꺼라불꺼_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_10 : TriggerState {
            internal State불꺼라불꺼_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001456}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001456}, arg2: 0)) {
                    context.State = new State불꺼라불꺼_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_11 : TriggerState {
            internal State불꺼라불꺼_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11004787, illust: "Baron_normal", script: "$52000192_QD__52000192__11$", duration: 3000);
                context.SetEffect(arg1: new[] {6024}, arg2: false);
                context.SetEffect(arg1: new[] {6017, 6018, 6019, 6020}, arg2: true);
                context.CreateMonster(arg1: new[] {213});
                context.CreateMonster(arg1: new[] {214});
                context.CreateMonster(arg1: new[] {215});
                context.CreateMonster(arg1: new[] {216});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {213, 214, 215, 216})) {
                    context.State = new State불꺼라불꺼_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_12 : TriggerState {
            internal State불꺼라불꺼_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 104, msg: "$52000192_QD__52000192__12$", duration: 3000);
                context.SetEffect(arg1: new[] {6004}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3007");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3008");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State다왔다(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다왔다 : TriggerState {
            internal State다왔다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 6000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000192_QD__52000192__13$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004785, msg: "$52000192_QD__52000192__14$", illustId: "Ereb_surprise", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State밖으로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밖으로 : TriggerState {
            internal State밖으로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg3: "EscapePrisonTower");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 5003, arg2: true, arg3: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000119, arg2: 20);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}