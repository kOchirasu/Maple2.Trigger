namespace Maple2.Trigger._52000119_qd {
    public static class _main2 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100060}, arg3: new byte[] {1})) {
                    return new Statefadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {105, 106});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.CreateMonster(arg1: new[] {105, 106}, arg2: true);
                context.MoveUser(arg1: 52000119, arg2: 6002);
                context.SetSceneSkip(arg1: "fadeout_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statefadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006, 4007}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.FaceEmotion(spawnPointId: 0, emotionName: "Object_React_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007, 4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Sit_Down_A", arg3: 6000f);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN2__0$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008, 4013, 4014, 4015}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN2__1$", duration: 3000, align: "Left");
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$52000119_QD__MAIN2__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN2__3$", duration: 3000, align: "Left");
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$52000119_QD__MAIN2__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statescene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN2__5$", duration: 4989, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN2__6$", duration: 8254, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Damg_B");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN2__7$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Attack_02_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN2__8$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4016}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Attack_Idle_A", arg3: 8000f);
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN2__9$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4016, 4017, 4018}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Object_React_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN2__10$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_10 : TriggerState {
            internal Statescene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4018}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN2__11$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_11 : TriggerState {
            internal Statescene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4019}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Attack_02_C");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN2__12$", duration: 3000, align: "Left");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statefadeout_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout_01 : TriggerState {
            internal Statefadeout_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {998}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statefadein_01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statemsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statemsg : TriggerState {
            internal Statemsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000119_QD__MAIN2__13$", arg3: 3000, arg4: "0");
                context.AddBalloonTalk(spawnPointId: 997, msg: "$52000119_QD__MAIN2__14$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {998})) {
                    return new Statefadeout_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout_02 : TriggerState {
            internal Statefadeout_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7002, arg2: false);
                context.DestroyMonster(arg1: new[] {998});
                context.SetAchievement(arg2: "trigger", arg3: "jordysave2");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateend(context);
                }

                return null;
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}