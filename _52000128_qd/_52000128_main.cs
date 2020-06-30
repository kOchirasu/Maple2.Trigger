using System;

namespace Maple2.Trigger._52000128_qd {
    public static class _52000128_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5008}, arg2: false);
                context.SetEffect(arg1: new int[] {5009}, arg2: false);
                context.SetMesh(arg1: new int[] {4001}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Thief.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State시작_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 33000)) {
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
                    context.State = new State금고폭파_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State금고폭파_01 : TriggerState {
            internal State금고폭파_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State금고폭파_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State금고폭파_02 : TriggerState {
            internal State금고폭파_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State금고폭파_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State금고폭파_03 : TriggerState {
            internal State금고폭파_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7001}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State폭파확인_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭파확인_01 : TriggerState {
            internal State폭파확인_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State빅스소개_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빅스소개_01 : TriggerState {
            internal State빅스소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State빅스소개_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빅스소개_02 : TriggerState {
            internal State빅스소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003272, msg: "$52000128_QD__52000128_MAIN__0$", duration: 2000,
                    align: "left");
                context.SetSceneSkip(arg1: "제시소개_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State빅스소개_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빅스소개_03 : TriggerState {
            internal State빅스소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000128_QD__52000128_MAIN__1$",
                    desc: "$52000128_QD__52000128_MAIN__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State제시소개_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시소개_01 : TriggerState {
            internal State제시소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(arg1: new int[] {8002, 8003}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제시소개_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시소개_02 : TriggerState {
            internal State제시소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003273, msg: "$52000128_QD__52000128_MAIN__3$", duration: 2000,
                    align: "left");
                context.SetSceneSkip(arg1: "카일소개_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제시소개_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시소개_03 : TriggerState {
            internal State제시소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000128_QD__52000128_MAIN__4$",
                    desc: "$52000128_QD__52000128_MAIN__5$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State카일소개_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일소개_01 : TriggerState {
            internal State카일소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(arg1: new int[] {8003, 8004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카일소개_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일소개_02 : TriggerState {
            internal State카일소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카일소개_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일소개_03 : TriggerState {
            internal State카일소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003280, msg: "$52000128_QD__52000128_MAIN__6$", duration: 2351,
                    align: "left");
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_B");
                context.SetSceneSkip(arg1: "퀘스트시작_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카일소개_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일소개_04 : TriggerState {
            internal State카일소개_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000128_QD__52000128_MAIN__7$",
                    desc: "$52000128_QD__52000128_MAIN__8$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State퀘스트시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트시작_01 : TriggerState {
            internal State퀘스트시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 2.0f);
                context.ShowGuideSummary(entityID: 25201281, textID: 25201281);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002690},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트진행_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002690},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료가능_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002690},
                    arg3: new byte[] {3})) {
                    context.State = new State암전_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트진행_01 : TriggerState {
            internal State퀘스트진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25201281);
                context.ShowGuideSummary(entityID: 25201282, textID: 25201282);
                context.SetEffect(arg1: new int[] {5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702")) {
                    context.State = new State퀘스트진행_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트진행_02 : TriggerState {
            internal State퀘스트진행_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002690},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료가능_01 : TriggerState {
            internal State퀘스트완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25201281);
                context.HideGuideSummary(entityID: 25201282);
                context.ShowGuideSummary(entityID: 25201283, textID: 25201283);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002690},
                    arg3: new byte[] {3})) {
                    context.State = new State암전_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25201281);
                context.HideGuideSummary(entityID: 25201282);
                context.HideGuideSummary(entityID: 25201283);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State암전_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005}, arg2: false);
                context.DestroyMonster(arg1: new int[] {103});
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2005");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State밝은화면_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밝은화면_01 : TriggerState {
            internal State밝은화면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State잡담_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잡담_01 : TriggerState {
            internal State잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000128_QD__52000128_MAIN__9$", arg4: 2, arg5: 0);
                context.SetSceneSkip(arg1: "교도관등장_06", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State잡담_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잡담_02 : TriggerState {
            internal State잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {107, 109, 111, 113, 115}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000128_QD__52000128_MAIN__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State교도관등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_01 : TriggerState {
            internal State교도관등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2010");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2008");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2009");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State교도관등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_02 : TriggerState {
            internal State교도관등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000128_QD__52000128_MAIN__21$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State교도관등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_03 : TriggerState {
            internal State교도관등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State교도관등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_04 : TriggerState {
            internal State교도관등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2012");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State교도관등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_05 : TriggerState {
            internal State교도관등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000128_QD__52000128_MAIN__11$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    context.State = new State교도관등장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_06 : TriggerState {
            internal State교도관등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.MoveUserPath(arg1: "MS2PatrolData_2013");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State교도관등장_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_07 : TriggerState {
            internal State교도관등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2014");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State교도관등장_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관등장_08 : TriggerState {
            internal State교도관등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State교도관전투_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {101, 102, 104});
            }
        }

        private class State교도관전투_01 : TriggerState {
            internal State교도관전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 25201284, textID: 25201284);
                context.DestroyMonster(arg1: new int[] {107, 109, 111, 113, 115});
                context.CreateMonster(arg1: new int[] {108, 110, 112, 114, 116}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {108, 110, 112, 114, 116})) {
                    context.State = new State교도관전투끝_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_01 : TriggerState {
            internal State교도관전투끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityID: 25201284);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State교도관전투끝_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_02 : TriggerState {
            internal State교도관전투끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000128, arg2: 99);
                context.CreateMonster(arg1: new int[] {117, 118, 119, 120, 121});
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2011");
                context.CameraSelectPath(arg1: new int[] {8009}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 117, arg2: "Dead_Idle_A", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 118, arg2: "Dead_Idle_B", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 119, arg2: "Dead_Idle_B", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 120, arg2: "Dead_Idle_B", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 121, arg2: "Dead_Idle_A", arg3: 3600000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State교도관전투끝_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_03 : TriggerState {
            internal State교도관전투끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투끝_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투끝_04 : TriggerState {
            internal State전투끝_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "벨마등장_06", arg2: "nextState");
                context.AddCinematicTalk(npcID: 0, msg: "$52000128_QD__52000128_MAIN__12$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    context.State = new State전투끝_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투끝_05 : TriggerState {
            internal State전투끝_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
                context.AddCinematicTalk(npcID: 0, msg: "$52000128_QD__52000128_MAIN__13$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    context.State = new State벨마등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장_01 : TriggerState {
            internal State벨마등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State벨마등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장_02 : TriggerState {
            internal State벨마등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003274, msg: "$52000128_QD__52000128_MAIN__14$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    context.State = new State벨마등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장_03 : TriggerState {
            internal State벨마등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8007}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "$52000128_QD__52000128_MAIN__15$", duration: 4000,
                    align: "right");
                context.SetPcEmotionSequence(arg1: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State벨마등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장_04 : TriggerState {
            internal State벨마등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벨마등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장_05 : TriggerState {
            internal State벨마등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcID: 11003274, msg: "$52000128_QD__52000128_MAIN__16$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State벨마등장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마등장_06 : TriggerState {
            internal State벨마등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State벨마전투_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마전투_01 : TriggerState {
            internal State벨마전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 25201285, textID: 25201285);
                context.DestroyMonster(arg1: new int[] {105});
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "battleStop", value: 1)) {
                    context.State = new State벨마전투끝_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_01 : TriggerState {
            internal State벨마전투끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityID: 25201285);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State벨마전투끝_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_02 : TriggerState {
            internal State벨마전투끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000128, arg2: 99);
                context.DestroyMonster(arg1: new int[] {106});
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2011");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State벨마전투끝_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_03 : TriggerState {
            internal State벨마전투끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투후대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: false);
                context.FaceEmotion(spawnPointID: 0);
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.AddCinematicTalk(npcID: 0, msg: "$52000128_QD__52000128_MAIN__17$", duration: 3000,
                    align: "right");
                context.AddCinematicTalk(npcID: 0, msg: "$52000128_QD__52000128_MAIN__18$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State전투후대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State불길_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불길_01 : TriggerState {
            internal State불길_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State탈출_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출_01 : TriggerState {
            internal State탈출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8011}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000128_QD__52000128_MAIN__19$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State탈출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출_02 : TriggerState {
            internal State탈출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2014");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State탈출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출_03 : TriggerState {
            internal State탈출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8008}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcID: 11003274, msg: "$52000128_QD__52000128_MAIN__20$", duration: 2000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.MoveUser(arg1: 52000129, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}