using System;

namespace Maple2.Trigger._52000020_qd {
    public static class _main_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100090},
                    arg3: new byte[] {2})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.CreateMonster(arg1: new int[] {401, 402, 403}, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetSceneSkip(arg1: "battle_ready", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statecamera(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera : TriggerState {
            internal Statecamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4001, arg2: false);
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Bore_C");
                context.AddCinematicTalk(npcID: 29000266, msg: "$52000020_QD__MAIN_01__0$", duration: 3709,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003193, msg: "$52000020_QD__MAIN_01__1$", duration: 3369,
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
                context.AddCinematicTalk(npcID: 11003193, msg: "$52000020_QD__MAIN_01__2$", duration: 2000,
                    align: "center");
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
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Emotion_Troubled_A");
                context.AddCinematicTalk(npcID: 29000266, msg: "$52000020_QD__MAIN_01__3$", duration: 3000,
                    align: "left");
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
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Bore_B");
                context.AddCinematicTalk(npcID: 29000266, msg: "$52000020_QD__MAIN_01__4$", duration: 2000,
                    align: "left");
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
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 401, msg: "$52000020_QD__MAIN_01__5$", duration: 1000,
                    delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 402, msg: "$52000020_QD__MAIN_01__6$", duration: 1000,
                    delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 403, msg: "$52000020_QD__MAIN_01__7$", duration: 1000,
                    delayTick: 0);
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
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Emotion_Angry_A");
                context.AddCinematicTalk(npcID: 29000266, msg: "$52000020_QD__MAIN_01__8$", duration: 2000,
                    align: "left");
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000020_QD__MAIN_01__9$", duration: 2000,
                    delayTick: 1000);
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
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[] {301});
                context.DestroyMonster(arg1: new int[] {401, 402, 403});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statebattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle : TriggerState {
            internal Statebattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new int[] {501}, arg2: true);
                context.CreateMonster(arg1: new int[] {601, 602, 603}, arg2: true);
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
                context.SetEventUI(arg1: 1, arg2: "$52000020_QD__MAIN_01__10$", arg3: new int[] {3000}, arg4: "0");
                context.AddBalloonTalk(spawnPointID: 601, msg: "$52000020_QD__MAIN_01__11$", duration: 3000,
                    delayTick: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {501, 601, 602, 603})) {
                    context.State = new Statedelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedelay : TriggerState {
            internal Statedelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7002, arg2: false);
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
                context.DestroyMonster(arg1: new int[] {202});
                context.DestroyMonster(arg1: new int[] {501});
                context.DestroyMonster(arg1: new int[] {601, 602, 603});
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
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

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}