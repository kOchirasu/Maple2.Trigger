namespace Maple2.Trigger._52000145_qd {
    public static class _52000145_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002711},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트2완료_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002711},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트2진행_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002711},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트2시작_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002710},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트1완료가능_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002710},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트1진행_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002710},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트1수락_02(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new State영상준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State영상재생_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Ranger.usm", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State독백_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 45000)) {
                    context.State = new State독백_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State독백_01 : TriggerState {
            internal State독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000145_QD__52000145_MAIN__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_01 : TriggerState {
            internal State시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State시작_02 : TriggerState {
            internal State시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000145, arg2: 99);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State하스터숙면_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_01 : TriggerState {
            internal State하스터숙면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__1$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State하스터숙면_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_02 : TriggerState {
            internal State하스터숙면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__2$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State하스터숙면_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_03 : TriggerState {
            internal State하스터숙면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State하스터숙면_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_04 : TriggerState {
            internal State하스터숙면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "퀘스트1수락_01", arg2: "nextState");
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 3000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__3$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State하스터숙면_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_05 : TriggerState {
            internal State하스터숙면_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__4$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State하스터숙면_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_06 : TriggerState {
            internal State하스터숙면_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "Think_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__5$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State퀘스트1수락_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1수락_01 : TriggerState {
            internal State퀘스트1수락_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State퀘스트1수락_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1수락_02 : TriggerState {
            internal State퀘스트1수락_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201456, textId: 25201456);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 702}, arg2: new[] {40002710},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트1진행_00(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201456);
            }
        }

        private class State퀘스트1진행_00 : TriggerState {
            internal State퀘스트1진행_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트1진행_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1진행_01 : TriggerState {
            internal State퀘스트1진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201451, textId: 25201451);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 702}, arg2: new[] {40002710},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트1완료가능_00(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201451);
            }
        }

        private class State퀘스트1완료가능_00 : TriggerState {
            internal State퀘스트1완료가능_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트1완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1완료가능_01 : TriggerState {
            internal State퀘스트1완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201452, textId: 25201452);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 702}, arg2: new[] {40002710},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트1완료_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201452);
            }
        }

        private class State퀘스트1완료_01 : TriggerState {
            internal State퀘스트1완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트2시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2시작_01 : TriggerState {
            internal State퀘스트2시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201453, textId: 25201453);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 702}, arg2: new[] {40002711},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트2진행_00(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201453);
            }
        }

        private class State퀘스트2진행_00 : TriggerState {
            internal State퀘스트2진행_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트2진행_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2진행_01 : TriggerState {
            internal State퀘스트2진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201454, textId: 25201454);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 703}, arg2: new[] {40002711},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트2완료가능_00(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201454);
            }
        }

        private class State퀘스트2완료가능_00 : TriggerState {
            internal State퀘스트2완료가능_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트2완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2완료가능_01 : TriggerState {
            internal State퀘스트2완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201455, textId: 25201455);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 702}, arg2: new[] {40002711},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트2완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2완료_01 : TriggerState {
            internal State퀘스트2완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201455);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트2완료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2완료_02 : TriggerState {
            internal State퀘스트2완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.MoveUser(arg1: 52000145, arg2: 99);
                context.CreateMonster(arg1: new[] {103}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State오스칼등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_01 : TriggerState {
            internal State오스칼등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionSequence(arg1: "Emotion_Troubled_A");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State오스칼등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_02 : TriggerState {
            internal State오스칼등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State오스칼등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_03 : TriggerState {
            internal State오스칼등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
                context.FaceEmotion(spawnPointId: 0, emotionName: "Think_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__7$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State오스칼등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_04 : TriggerState {
            internal State오스칼등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__8$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State오스칼등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_05 : TriggerState {
            internal State오스칼등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__9$", duration: 3000,
                    align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__10$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State오스칼등장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_06 : TriggerState {
            internal State오스칼등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__11$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5485)) {
                    context.State = new State오스칼등장_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_07 : TriggerState {
            internal State오스칼등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State오스칼등장_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_08 : TriggerState {
            internal State오스칼등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__12$", duration: 3000,
                    align: "left");
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Sit_Down_A", arg3: 70000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_08_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_08_1 : TriggerState {
            internal State오스칼등장_08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__13$", duration: 2500,
                    align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State오스칼등장_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_09 : TriggerState {
            internal State오스칼등장_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State오스칼등장_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_10 : TriggerState {
            internal State오스칼등장_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__14$", duration: 4000,
                    illustId: "Hastur_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State오스칼등장_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_11 : TriggerState {
            internal State오스칼등장_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__15$", duration: 3000,
                    illustId: "Oskhal_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_12 : TriggerState {
            internal State오스칼등장_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__16$", duration: 3500,
                    illustId: "Hastur_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_13 : TriggerState {
            internal State오스칼등장_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__17$", duration: 2500,
                    illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__18$", duration: 3500,
                    illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__19$", duration: 3000,
                    illustId: "Oskhal_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    context.State = new State오스칼등장_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_14 : TriggerState {
            internal State오스칼등장_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__20$", duration: 3000,
                    illustId: "Hastur_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_15 : TriggerState {
            internal State오스칼등장_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__21$", duration: 3500,
                    illustId: "Oskhal_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5172)) {
                    context.State = new State오스칼등장_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_16 : TriggerState {
            internal State오스칼등장_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__22$", duration: 3000,
                    illustId: "Hastur_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_17 : TriggerState {
            internal State오스칼등장_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__23$", duration: 2500,
                    illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__24$", duration: 3500,
                    illustId: "Oskhal_normal", align: "left");
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__25$", duration: 2500,
                    illustId: "Oskhal_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9742)) {
                    context.State = new State오스칼등장_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_18 : TriggerState {
            internal State오스칼등장_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__26$", duration: 3000,
                    illustId: "Hastur_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_19 : TriggerState {
            internal State오스칼등장_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, msg: "$52000145_QD__52000145_MAIN__27$", duration: 3000,
                    illustId: "Oskhal_normal", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3631)) {
                    context.State = new State오스칼등장_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_20 : TriggerState {
            internal State오스칼등장_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, msg: "$52000145_QD__52000145_MAIN__28$", duration: 3500,
                    illustId: "Hastur_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State오스칼등장_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼등장_21 : TriggerState {
            internal State오스칼등장_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0);
                context.AddCinematicTalk(npcId: 0, msg: "$52000145_QD__52000145_MAIN__29$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000146, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}