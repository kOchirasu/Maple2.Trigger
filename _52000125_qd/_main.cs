namespace Maple2.Trigger._52000125_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetSound(arg1: 7001, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100185},
                    arg3: new byte[] {1})) {
                    context.State = new Statefadein(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001},
                    arg2: new[] {
                        60100185, 60100186, 60100187, 60100188, 60100189, 60100190, 60100191, 60100192, 60100193,
                        60100194, 60100195
                    }, arg3: new byte[] {2})) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "battle_ready", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {301}, arg2: true);
                context.CreateMonster(arg1: new[] {302}, arg2: true);
                context.CreateMonster(arg1: new[] {303}, arg2: true);
                context.MoveUser(arg1: 52000125, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003205, msg: "$52000125_QD__MAIN__0$", duration: 3000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000125_QD__MAIN__1$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000125_QD__MAIN__2$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.AddCinematicTalk(npcId: 11003213, msg: "$52000125_QD__MAIN__3$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003205, msg: "$52000125_QD__MAIN__4$", duration: 3000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003212, msg: "$52000125_QD__MAIN__5$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.AddCinematicTalk(npcId: 11003205, msg: "$52000125_QD__MAIN__6$", duration: 3000,
                    align: "center");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebattle_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_ready : TriggerState {
            internal Statebattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statewait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait : TriggerState {
            internal Statewait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301, 302, 303});
                context.CreateMonster(arg1: new[] {601, 602, 603}, arg2: false);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statebattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle : TriggerState {
            internal Statebattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBalloonTalk(spawnPointId: 601, msg: "$52000125_QD__MAIN__7$", duration: 3000,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 602, msg: "$52000125_QD__MAIN__8$", duration: 3000,
                    delayTick: 3000);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatebattleMsg(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatebattleMsg : TriggerState {
            internal StatebattleMsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000125_QD__MAIN__9$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603})) {
                    context.State = new Statedelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedelay : TriggerState {
            internal Statedelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "markguard");
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statewinready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewinready : TriggerState {
            internal Statewinready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601, 602, 603});
                context.CreateMonster(arg1: new[] {304, 305, 306}, arg2: true);
                context.MoveUser(arg1: 52000125, arg2: 6001);
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateendcamera(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendcamera : TriggerState {
            internal Stateendcamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statebye(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebye : TriggerState {
            internal Statebye(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000125_QD__MAIN__10$", duration: 3000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Staterun(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Staterun : TriggerState {
            internal Staterun(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 306, arg2: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000125_QD__MAIN__11$", duration: 3000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statethanks(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statethanks : TriggerState {
            internal Statethanks(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Clap_A");
                context.AddCinematicTalk(npcId: 11003205, msg: "$52000125_QD__MAIN__12$", duration: 2000,
                    align: "center");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSound(arg1: 7001, arg2: false);
                context.DestroyMonster(arg1: new[] {304, 305, 306});
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}