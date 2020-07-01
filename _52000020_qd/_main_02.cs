namespace Maple2.Trigger._52000020_qd {
    public static class _main_02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100095}, arg3: new byte[] {1})) {
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
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202, 302, 404, 405, 406, 407, 408, 409, 410, 411}, arg2: true);
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
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.AddCinematicTalk(npcId: 11003193, msg: "$52000020_QD__MAIN_02__0$", duration: 2000, align: "center");
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
                context.CameraSelectPath(arg1: new[] {4003, 4004}, arg2: false);
                context.MoveUser(arg1: 52000020, arg2: 6001);
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
                context.SetNpcEmotionSequence(arg1: 302, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__1$", duration: 2000, align: "left");
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
                context.SetNpcEmotionSequence(arg1: 302, arg2: "Emotion_Angry_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__2$", duration: 2000, align: "center");
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
                context.SetNpcEmotionSequence(arg1: 302, arg2: "ChatUp_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__3$", duration: 2000, align: "center");
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
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 404, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 405, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 406, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 407, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 408, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 409, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 410, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 411, arg2: "ChatUp_A");
                context.AddBalloonTalk(spawnPointId: 404, msg: "$52000020_QD__MAIN_02__4$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 405, msg: "$52000020_QD__MAIN_02__5$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 406, msg: "$52000020_QD__MAIN_02__6$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 407, msg: "$52000020_QD__MAIN_02__7$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 408, msg: "$52000020_QD__MAIN_02__8$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 409, msg: "$52000020_QD__MAIN_02__9$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 410, msg: "$52000020_QD__MAIN_02__10$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 411, msg: "$52000020_QD__MAIN_02__11$", duration: 2000, delayTick: 0);
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
                context.SetNpcEmotionSequence(arg1: 502, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__12$", duration: 2000, align: "center");
                context.SetSceneSkip();
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {404, 405});
                context.SetSkip();
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new[] {604, 605}, arg2: true);
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
                context.SetEventUI(arg1: 1, arg2: "$52000020_QD__MAIN_02__13$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {604, 605})) {
                    context.State = new Statedelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedelay : TriggerState {
            internal Statedelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateround_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateround_2 : TriggerState {
            internal Stateround_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {406, 407, 408, 409});
                context.CreateMonster(arg1: new[] {606, 607, 608, 609}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {604, 605})) {
                    context.State = new Statedelay_a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedelay_a : TriggerState {
            internal Statedelay_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateround_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateround_3 : TriggerState {
            internal Stateround_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {410, 411, 302});
                context.CreateMonster(arg1: new[] {610, 611, 502}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {610, 611, 502})) {
                    context.State = new Statedelay_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedelay_b : TriggerState {
            internal Statedelay_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2002, arg2: "trigger", arg3: "mafiabattle");
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
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetSound(arg1: 7002, arg2: false);
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