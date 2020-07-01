namespace Maple2.Trigger._52000119_qd {
    public static class _main3 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100070}, arg3: new byte[] {2})) {
                    context.State = new Statemonsterdel(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100075}, arg3: new byte[] {1})) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateready(context);
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
                context.CameraSelectPath(arg1: new[] {4020}, arg2: false);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.CreateMonster(arg1: new[] {106, 201, 202, 301, 302, 303, 304, 305, 306}, arg2: true);
                context.MoveUser(arg1: 52000119, arg2: 6001);
                context.SetSceneSkip(arg1: "fadeout_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statefadein(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 6000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Object_React_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4021}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003169, illustId: "Jordy_normal", msg: "$52000119_QD__MAIN3__0$", duration: 3000, align: "Right");
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
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN3__1$", duration: 3000);
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
                context.CameraSelectPath(arg1: new[] {4013, 4014, 4015}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN3__2$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN3__3$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statecheer_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecheer_01 : TriggerState {
            internal Statecheer_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.CameraSelectPath(arg1: new[] {4023, 4024}, arg2: false);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__4$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statecheer_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecheer_02 : TriggerState {
            internal Statecheer_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 306, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__5$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statecheer_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecheer_03 : TriggerState {
            internal Statecheer_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4024, 4025}, arg2: false);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__6$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__7$", duration: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statecheer_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecheer_04 : TriggerState {
            internal Statecheer_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__8$", duration: 2000);
                context.AddBalloonTalk(spawnPointId: 303, msg: "$52000119_QD__MAIN3__9$", duration: 2000, delayTick: 1);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__10$", duration: 1000);
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
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Stun_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN3__11$", duration: 2000);
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
                context.CameraSelectPath(arg1: new[] {4019}, arg2: false);
                context.SetEffect(arg1: new[] {5002, 5003, 5004, 5005}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN3__12$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4019, 4022}, arg2: false);
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_3001");
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN3__13$", arg4: 3, arg5: 0);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statefadeout_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_01 : TriggerState {
            internal Statefadeout_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {999}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 100f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefadein_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein_01 : TriggerState {
            internal Statefadein_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statemsg(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemsg : TriggerState {
            internal Statemsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000119_QD__MAIN3__14$", arg3: 3000, arg4: "0");
                context.AddBalloonTalk(spawnPointId: 999, msg: "$52000119_QD__MAIN3__15$", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    context.State = new Statefadeout_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_02 : TriggerState {
            internal Statefadeout_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7002, arg2: false);
                context.AddBalloonTalk(spawnPointId: 999, msg: "$52000119_QD__MAIN3__19$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 306, msg: "$52000119_QD__MAIN3__20$", duration: 2000, delayTick: 1);
                context.DestroyMonster(arg1: new[] {201, 202, 401, 402, 403, 404, 405, 406, 407});
                context.SetAchievement(arg2: "trigger", arg3: "jordysave3");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statemonsterdel : TriggerState {
            internal Statemonsterdel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.CreateMonster(arg1: new[] {401, 402, 403, 404, 405, 406, 407}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100075}, arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}