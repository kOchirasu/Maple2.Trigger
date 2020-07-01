using System;

namespace Maple2.Trigger._52000119_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateintro(context);

        private class Stateintro : TriggerState {
            internal Stateintro(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[] {
                        901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919,
                        920
                    }, arg2: true);
                context.CreateMonster(arg1: new int[] {921, 922, 923, 924, 925, 926, 927, 928, 929}, arg2: true);
                context.CreateMonster(arg1: new int[] {104, 105}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100030},
                    arg3: new byte[] {1})) {
                    context.State = new Statefadeout_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_01 : TriggerState {
            internal Statefadeout_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {104, 105});
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {4010, 4001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statefadein_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein_01 : TriggerState {
            internal Statefadein_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Sit_Down_A", arg3: 900000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateeventscene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_01 : TriggerState {
            internal Stateeventscene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003169, illustID: "Jordy_normal", msg: "$52000119_QD__MAIN__0$",
                    duration: 3000, align: "Left");
                context.SetSceneSkip(arg1: "fadeout_02", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateeventscene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_02 : TriggerState {
            internal Stateeventscene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.SetConversation(arg1: 2, arg2: 11000173, arg3: "$52000119_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11000173, arg3: "$52000119_QD__MAIN__2$", arg4: 3, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Stateeventscene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_03 : TriggerState {
            internal Stateeventscene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk");
                context.SetConversation(arg1: 2, arg2: 11000173, arg3: "$52000119_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateeventscene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_04 : TriggerState {
            internal Stateeventscene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Damg_B");
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN__4$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateeventscene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_05 : TriggerState {
            internal Stateeventscene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.SetConversation(arg1: 2, arg2: 11000173, arg3: "$52000119_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11000173, arg3: "$52000119_QD__MAIN__6$", arg4: 3, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Stateeventscene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_06 : TriggerState {
            internal Stateeventscene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN__7$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN__8$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000119_QD__MAIN__9$", arg4: 2, arg5: 4);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statefadeout_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_02 : TriggerState {
            internal Statefadeout_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statereset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statereset : TriggerState {
            internal Statereset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateeventscene_end(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventscene_end : TriggerState {
            internal Stateeventscene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 3);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000119_QD__MAIN__10$", arg3: new int[] {1000}, arg4: "0");
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statehintmsg(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statehintmsg : TriggerState {
            internal Statehintmsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 0, arg3: "$52000119_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateplay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateplay : TriggerState {
            internal Stateplay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2002})) {
                    context.State = new Statefadeout_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_03 : TriggerState {
            internal Statefadeout_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920
                });
                context.DestroyMonster(arg1: new int[] {921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.DestroyMonster(arg1: new int[] {101, 102, 103});
                context.CreateMonster(arg1: new int[] {104, 105, 106}, arg2: true);
                context.MoveUser(arg1: 52000119, arg2: 6002);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statefadein_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein_03 : TriggerState {
            internal Statefadein_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_3003");
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000119_QD__MAIN__12$", duration: 2000, delayTick: 0);
                context.SetSceneSkip(arg1: "fadeout_04", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statebossscene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_01 : TriggerState {
            internal Statebossscene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Sit_Down_A", arg3: 150000f);
                context.SetConversation(arg1: 2, arg2: 11003187, arg3: "$52000119_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebossscene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_02 : TriggerState {
            internal Statebossscene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.SetConversation(arg1: 2, arg2: 11003187, arg3: "$52000119_QD__MAIN__14$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebossscene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_03 : TriggerState {
            internal Statebossscene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11003187, arg3: "$52000119_QD__MAIN__15$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$52000119_QD__MAIN__16$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statebossscene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_04 : TriggerState {
            internal Statebossscene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013, 4014, 4015}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.SetConversation(arg1: 2, arg2: 11003187, arg3: "$52000119_QD__MAIN__17$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statebossscene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_05 : TriggerState {
            internal Statebossscene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.FaceEmotion(spawnPointID: 0, emotionName: "Object_React_A");
                context.SetConversation(arg1: 2, arg2: 11003187, arg3: "$52000119_QD__MAIN__18$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebossscene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_06 : TriggerState {
            internal Statebossscene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3004");
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Attack_01_C");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_3001");
                context.FaceEmotion(spawnPointID: 0, emotionName: "Object_React_A");
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN__19$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebossscene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossscene_07 : TriggerState {
            internal Statebossscene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Bore_A");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 4000f);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Object_React_A");
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN__20$", arg4: 3, arg5: 0);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statefadeout_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_04 : TriggerState {
            internal Statefadeout_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.DestroyMonster(arg1: new int[] {106});
                context.CreateMonster(arg1: new int[] {997}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefadein_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein_04 : TriggerState {
            internal Statefadein_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.AddBalloonTalk(spawnPointID: 997, msg: "$52000119_QD__MAIN__21$", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statebossmsg(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebossmsg : TriggerState {
            internal Statebossmsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000119_QD__MAIN__22$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {997})) {
                    context.State = new Statewait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait : TriggerState {
            internal Statewait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7002, arg2: false);
                context.AddBalloonTalk(spawnPointID: 104, msg: "$52000119_QD__MAIN__23$", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statefadeout_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout_05 : TriggerState {
            internal Statefadeout_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {997});
                context.SetAchievement(arg2: "trigger", arg3: "jordysave");
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
    }
}