namespace Maple2.Trigger._52000124_qd {
    public static class _main_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100145},
                    arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001},
                    arg2: new[] {60100145, 60100146, 60100147, 60100148, 60100149, 60100150},
                    arg3: new byte[] {2})) {
                    context.State = new Statedelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000124, arg2: 6002);
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
                context.CreateMonster(arg1: new[] {401, 402}, arg2: true);
                context.AddCinematicTalk(npcId: 11000069, msg: "$52000124_QD__MAIN_01__0$", duration: 2000,
                    align: "left");
                context.SetSceneSkip(arg1: "battle_ready", arg2: "exit");
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
                context.AddCinematicTalk(npcId: 11000069, msg: "$52000124_QD__MAIN_01__1$", duration: 2000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.AddCinematicTalk(npcId: 11003304, msg: "$52000124_QD__MAIN_01__2$", duration: 2000,
                    align: "left");
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000124_QD__MAIN_01__3$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003304, msg: "$52000124_QD__MAIN_01__4$", duration: 2000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000069, msg: "$52000124_QD__MAIN_01__5$", duration: 2000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003304, msg: "$52000124_QD__MAIN_01__6$", duration: 2000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003304, msg: "$52000124_QD__MAIN_01__7$", duration: 2000,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statebattle_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_ready : TriggerState {
            internal Statebattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {401, 402});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new[] {601, 602}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.SetEventUI(arg1: 1, arg2: "$52000124_QD__MAIN_01__8$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602})) {
                    context.State = new Statedelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedelay : TriggerState {
            internal Statedelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "eveguard");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewinready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewinready : TriggerState {
            internal Statewinready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601, 602});
                context.MoveUser(arg1: 52000124, arg2: 6001);
                context.CreateMonster(arg1: new[] {302}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_10 : TriggerState {
            internal Statescene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3002");
                context.CameraSelectPath(arg1: new[] {4007, 4008}, arg2: false);
                context.AddCinematicTalk(npcId: 11003196, illustId: "Katvan_normal", msg: "$52000124_QD__MAIN_01__9$",
                    duration: 3000, align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_11 : TriggerState {
            internal Statescene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {302});
                context.CreateMonster(arg1: new[] {301}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statedel : TriggerState {
            internal Statedel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}