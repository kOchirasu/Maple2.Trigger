namespace Maple2.Trigger._52000142_qd {
    public static class _52000142_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106}, arg2: false);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028, 5029, 5030, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5040, 5041, 5042, 5043}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002721}, arg3: new byte[] {3})) {
                    context.State = new State단계별이동_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002721}, arg3: new byte[] {2})) {
                    context.State = new State단계별이동_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002720}, arg3: new byte[] {3})) {
                    context.State = new State단계별이동_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002720}, arg3: new byte[] {2})) {
                    context.State = new State단계별이동_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002720}, arg3: new byte[] {1})) {
                    context.State = new State퀘스트1진행_01(context);
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
                context.AddBuff(arg1: new[] {701}, arg2: 70000124, arg3: 1, arg4: false, arg5: false);
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Knight.usm", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State시작_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 53000)) {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구보훈련_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구보훈련_01 : TriggerState {
            internal State구보훈련_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State구보훈련_01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구보훈련_01_1 : TriggerState {
            internal State구보훈련_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003, 8005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구보훈련_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구보훈련_02 : TriggerState {
            internal State구보훈련_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구보훈련_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구보훈련_03 : TriggerState {
            internal State구보훈련_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__0$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State구보훈련_04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구보훈련_04_1 : TriggerState {
            internal State구보훈련_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구보훈련_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구보훈련_04 : TriggerState {
            internal State구보훈련_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201421, textId: 25201421);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002720}, arg3: new byte[] {1})) {
                    context.State = new State퀘스트1진행_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State단계별이동_01 : TriggerState {
            internal State단계별이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBuff(arg1: new[] {701}, arg2: 70000124, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State단계별이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State단계별이동_02 : TriggerState {
            internal State단계별이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000142, arg2: 99);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002721}, arg3: new byte[] {3})) {
                    context.State = new State퀘2완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002721}, arg3: new byte[] {2})) {
                    context.State = new State퀘2완료가능(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002720}, arg3: new byte[] {3})) {
                    context.State = new State퀘1완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002720}, arg3: new byte[] {2})) {
                    context.State = new State퀘1완료가능(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘2완료 : TriggerState {
            internal State퀘2완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 106});
                context.CreateMonster(arg1: new[] {108, 109}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Emotion_lie_facedown_Idle_A", arg3: 600000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트2완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘2완료가능 : TriggerState {
            internal State퀘2완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 106, 107});
                context.CreateMonster(arg1: new[] {108, 109}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Emotion_lie_facedown_Idle_A", arg3: 600000f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State수호사제찾기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘1완료 : TriggerState {
            internal State퀘1완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Down_Idle_B", arg3: 600000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트1완료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘1완료가능 : TriggerState {
            internal State퀘1완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {106});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트1완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1진행_01 : TriggerState {
            internal State퀘스트1진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {106});
                context.HideGuideSummary(entityId: 25201421);
                context.ShowGuideSummary(entityId: 25201422, textId: 25201422);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025}, arg2: true);
                context.AddBuff(arg1: new[] {701}, arg2: 70000124, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002720}, arg3: new byte[] {2})) {
                    context.State = new State퀘스트1완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1완료가능_01 : TriggerState {
            internal State퀘스트1완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025}, arg2: false);
                context.HideGuideSummary(entityId: 25201422);
                context.ShowGuideSummary(entityId: 25201423, textId: 25201423);
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Down_Idle_B", arg3: 600000f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002720}, arg3: new byte[] {3})) {
                    context.State = new State퀘스트1완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1완료_01 : TriggerState {
            internal State퀘스트1완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201423);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트1완료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1완료_02 : TriggerState {
            internal State퀘스트1완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000142, arg2: 99);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {108}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트1완료_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트1완료_03 : TriggerState {
            internal State퀘스트1완료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State로베와대화1_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_01 : TriggerState {
            internal State로베와대화1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "벌칙_01", arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__1$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State로베와대화1_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_02 : TriggerState {
            internal State로베와대화1_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__2$", duration: 3000, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State로베와대화1_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_03 : TriggerState {
            internal State로베와대화1_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__3$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State로베와대화1_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_04 : TriggerState {
            internal State로베와대화1_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__4$", duration: 4000, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State로베와대화1_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_05 : TriggerState {
            internal State로베와대화1_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__5$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State로베와대화1_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_06 : TriggerState {
            internal State로베와대화1_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__6$", duration: 3500, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__7$", duration: 2500, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__8$", duration: 4000, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State로베와대화1_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_07 : TriggerState {
            internal State로베와대화1_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__9$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State로베와대화1_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_08 : TriggerState {
            internal State로베와대화1_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__10$", duration: 3500, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State동료의비웃음_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동료의비웃음_01 : TriggerState {
            internal State동료의비웃음_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000142_QD__52000142_MAIN__11$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State동료의비웃음_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동료의비웃음_02 : TriggerState {
            internal State동료의비웃음_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$52000142_QD__52000142_MAIN__12$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State동료의비웃음_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동료의비웃음_03 : TriggerState {
            internal State동료의비웃음_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000142_QD__52000142_MAIN__13$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State해명에도불구_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해명에도불구_01 : TriggerState {
            internal State해명에도불구_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__14$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State해명에도불구_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해명에도불구_02 : TriggerState {
            internal State해명에도불구_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__15$", duration: 3000, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State해명에도불구_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해명에도불구_03 : TriggerState {
            internal State해명에도불구_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__16$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State벌칙_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_01 : TriggerState {
            internal State벌칙_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 999, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벌칙_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_02 : TriggerState {
            internal State벌칙_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000142_QD__52000142_MAIN__17$");
                context.DestroyMonster(arg1: new[] {102, 103, 104, 107});
                context.CreateMonster(arg1: new[] {109}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Emotion_lie_facedown_Idle_A", arg3: 600000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State벌칙_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State벌칙_03 : TriggerState {
            internal State벌칙_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 999, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벌칙_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_04 : TriggerState {
            internal State벌칙_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "수호사제찾기_01", arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__18$", duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State벌칙_04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_04_1 : TriggerState {
            internal State벌칙_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벌칙_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_05 : TriggerState {
            internal State벌칙_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__19$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State벌칙_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_06 : TriggerState {
            internal State벌칙_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003399, msg: "$52000142_QD__52000142_MAIN__20$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State벌칙_06_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_06_1 : TriggerState {
            internal State벌칙_06_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벌칙_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_07 : TriggerState {
            internal State벌칙_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__21$", duration: 3500, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State벌칙_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_08 : TriggerState {
            internal State벌칙_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__22$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State벌칙_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_09 : TriggerState {
            internal State벌칙_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__23$", duration: 4000, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__24$", duration: 2500, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__25$", duration: 3000, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State벌칙_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벌칙_10 : TriggerState {
            internal State벌칙_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__26$", duration: 3500, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__27$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new State수호사제찾기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수호사제찾기_01 : TriggerState {
            internal State수호사제찾기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201424, textId: 25201424);
                context.SetEffect(arg1: new[] {5026, 5027, 5028, 5029, 5030, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039}, arg2: true);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {703})) {
                    context.State = new State수호사제찾기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수호사제찾기_02 : TriggerState {
            internal State수호사제찾기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5026, 5027, 5028, 5029, 5030, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039}, arg2: false);
                context.HideGuideSummary(entityId: 25201424);
                context.ShowGuideSummary(entityId: 25201425, textId: 25201425);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {703}, arg2: new[] {40002721}, arg3: new byte[] {2})) {
                    context.State = new State퀘스트2완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2완료가능_01 : TriggerState {
            internal State퀘스트2완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201425);
                context.ShowGuideSummary(entityId: 25201426, textId: 25201426);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {703}, arg2: new[] {40002721}, arg3: new byte[] {3})) {
                    context.State = new State퀘스트2완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2완료_01 : TriggerState {
            internal State퀘스트2완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.DestroyMonster(arg1: new[] {105});
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.MoveUser(arg1: 52000142, arg2: 99);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트2완료_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트2완료_03 : TriggerState {
            internal State퀘스트2완료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State란스구하기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_01 : TriggerState {
            internal State란스구하기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "란스구하기스킵_01", arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__28$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_02 : TriggerState {
            internal State란스구하기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__29$", duration: 3500, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_03 : TriggerState {
            internal State란스구하기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__30$", duration: 2500, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State란스구하기_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_04 : TriggerState {
            internal State란스구하기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 8000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State란스구하기_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_05 : TriggerState {
            internal State란스구하기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__31$", duration: 3000, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__32$", duration: 3500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new State란스구하기_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_06 : TriggerState {
            internal State란스구하기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003399, msg: "$52000142_QD__52000142_MAIN__33$", duration: 1000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State란스구하기_06_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_06_1 : TriggerState {
            internal State란스구하기_06_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2006");
                context.DestroyMonster(arg1: new[] {109});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Down_Idle_B", arg3: 600000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State란스구하기_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_07 : TriggerState {
            internal State란스구하기_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State란스구하기_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_08 : TriggerState {
            internal State란스구하기_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000142_QD__52000142_MAIN__34$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State란스구하기_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_09 : TriggerState {
            internal State란스구하기_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$52000142_QD__52000142_MAIN__35$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State란스구하기_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_10 : TriggerState {
            internal State란스구하기_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__36$", duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State란스구하기_10_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_10_1 : TriggerState {
            internal State란스구하기_10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State란스구하기_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_11 : TriggerState {
            internal State란스구하기_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 110, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__37$", duration: 5720, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5720)) {
                    context.State = new State란스구하기_11_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_11_1 : TriggerState {
            internal State란스구하기_11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State란스구하기_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_12 : TriggerState {
            internal State란스구하기_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__38$", duration: 3000, illustId: "Robe_normal", align: "right");
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__39$", duration: 2500, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State란스구하기_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_13 : TriggerState {
            internal State란스구하기_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__40$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_14 : TriggerState {
            internal State란스구하기_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__41$", duration: 5903, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8698)) {
                    context.State = new State란스구하기_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_15 : TriggerState {
            internal State란스구하기_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2005");
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__42$", duration: 5955, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5955)) {
                    context.State = new State란스구하기_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_16 : TriggerState {
            internal State란스구하기_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__43$", duration: 3500, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_17 : TriggerState {
            internal State란스구하기_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__44$", duration: 3500, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_18 : TriggerState {
            internal State란스구하기_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000142_QD__52000142_MAIN__45$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_19 : TriggerState {
            internal State란스구하기_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__46$", duration: 3000, illustId: "Robe_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State란스구하기_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_20 : TriggerState {
            internal State란스구하기_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__47$", duration: 3000, align: "left");
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__48$", duration: 2500, align: "left");
                context.AddCinematicTalk(npcId: 11003403, msg: "$52000142_QD__52000142_MAIN__49$", duration: 3500, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State란스구하기_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기_21 : TriggerState {
            internal State란스구하기_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, msg: "$52000142_QD__52000142_MAIN__50$", duration: 3000, illustId: "Robe_normal", align: "right");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기스킵_01 : TriggerState {
            internal State란스구하기스킵_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {109});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Down_Idle_B", arg3: 600000f);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State란스구하기스킵_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State란스구하기스킵_02 : TriggerState {
            internal State란스구하기스킵_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장_01 : TriggerState {
            internal State퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State퇴장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장_02 : TriggerState {
            internal State퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {108});
                context.ShowGuideSummary(entityId: 25201427, textId: 25201427);
                context.SetEffect(arg1: new[] {5040, 5041, 5042, 5043}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {704})) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201427);
                context.RemoveBuff(arg1: 704, arg2: 70000124);
                context.SetEffect(arg1: new[] {5040, 5041, 5042, 5043}, arg2: false);
                context.MoveUser(arg1: 52000143, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}