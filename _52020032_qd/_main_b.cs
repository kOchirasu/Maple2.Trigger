namespace Maple2.Trigger._52020032_qd {
    public static class _main_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(arg1: 8002, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 8003, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 8004, arg2: false, arg3: "Idle_A");
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200165},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpc_Set(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200165},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpc_Set(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200165},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpc_All_Del(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200160},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_A_Ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200160},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpc_Set(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200160},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpc_Set(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200150},
                    arg3: new byte[] {2})) {
                    context.State = new StateEvent_A_Ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200150},
                    arg3: new byte[] {3})) {
                    context.State = new StateEvent_A_Ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200155},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_A_Ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200155},
                    arg3: new byte[] {2})) {
                    context.State = new StateEvent_A_Ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200155},
                    arg3: new byte[] {3})) {
                    context.State = new StateEvent_A_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_Ready : TriggerState {
            internal StateEvent_A_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: true);
                context.SetActor(arg1: 8002, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 8003, arg2: true, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200160},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_C_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200150},
                    arg3: new byte[] {3})) {
                    context.State = new StateEvent_A_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200155},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_B_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_01 : TriggerState {
            internal StateEvent_A_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8003, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 8004, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200155},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_B_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200160},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_C_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_B_01 : TriggerState {
            internal StateEvent_B_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateEvent_B_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_B_02 : TriggerState {
            internal StateEvent_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020016, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200160},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_C_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_01 : TriggerState {
            internal StateEvent_C_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetActor(arg1: 8002, arg2: true, arg3: "Idle_A");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Event_C_Skip_01", arg2: "Exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateEvent_C_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_02 : TriggerState {
            internal StateEvent_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020032, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateEvent_C_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_03 : TriggerState {
            internal StateEvent_C_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 90000f);
                context.AddCinematicTalk(npcId: 11003620, msg: "그럼 편안한 죽음 되시길.", duration: 2800,
                    illustId: "Michael_normal", align: "Center");
                context.DestroyMonster(arg1: new[] {401});
                context.SetActor(arg1: 8002, arg2: false, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_04 : TriggerState {
            internal StateEvent_C_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBalloonTalk(spawnPointId: 0, msg: "......", duration: 1800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_05 : TriggerState {
            internal StateEvent_C_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_06 : TriggerState {
            internal StateEvent_C_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003622, msg: "$npcName:11003620$놈!", duration: 2800,
                    illustId: "Turka_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_C_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_07 : TriggerState {
            internal StateEvent_C_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.CreateMonster(arg1: new[] {501}, arg2: true);
                context.AddCinematicTalk(npcId: 11003622, msg: "감히 날 배신하다니!", duration: 2800, illustId: "Turka_normal",
                    align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_08 : TriggerState {
            internal StateEvent_C_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003622, msg: "배신의 대가는 톡톡히 치르게 해주겠다.", duration: 0,
                    illustId: "Turka_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_09 : TriggerState {
            internal StateEvent_C_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003622, msg: ".......", duration: 1800, illustId: "0",
                    align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_C_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_10 : TriggerState {
            internal StateEvent_C_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003622, msg: "이렇게 된 이상 그 계획을 빨리 진행해야겠군.", duration: 2800,
                    illustId: "0", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_11 : TriggerState {
            internal StateEvent_C_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_3002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateEvent_C_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_12 : TriggerState {
            internal StateEvent_C_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.DestroyMonster(arg1: new[] {501});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_C_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_13 : TriggerState {
            internal StateEvent_C_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_C_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_14 : TriggerState {
            internal StateEvent_C_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "......", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_C_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_15 : TriggerState {
            internal StateEvent_C_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(arg1: 8003, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 8004, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {402}, arg2: true);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 3000f);
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Eavesdrop");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_C_Exit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_Skip_01 : TriggerState {
            internal StateEvent_C_Skip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_C_Skip_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_Skip_02 : TriggerState {
            internal StateEvent_C_Skip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 3000f);
                context.DestroyMonster(arg1: new[] {401});
                context.DestroyMonster(arg1: new[] {501});
                context.CreateMonster(arg1: new[] {402}, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(arg1: 8002, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 8003, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 8004, arg2: false, arg3: "Idle_A");
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Eavesdrop");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_C_Exit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_Exit : TriggerState {
            internal StateEvent_C_Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateNpc_Set : TriggerState {
            internal StateNpc_Set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {402}, arg2: true);
                context.DestroyMonster(arg1: new[] {401});
                context.DestroyMonster(arg1: new[] {501});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateNpc_All_Del : TriggerState {
            internal StateNpc_All_Del(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {401});
                context.DestroyMonster(arg1: new[] {402});
                context.DestroyMonster(arg1: new[] {501});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}