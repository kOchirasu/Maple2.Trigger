using System;

namespace Maple2.Trigger._52000139_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new int[] {109}, arg2: true);
                context.CreateMonster(arg1: new int[] {110}, arg2: true);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
                context.CreateMonster(arg1: new int[] {107}, arg2: true);
                context.SetEffect(
                    arg1: new int[]
                        {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014},
                    arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002700},
                    arg3: new byte[] {3})) {
                    context.State = new State다시검은화면_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002700},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트진행_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002700},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트수락_02(context);
                    return;
                }

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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Priest.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State영상마무리_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 53000)) {
                    context.State = new State영상마무리_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상마무리_01 : TriggerState {
            internal State영상마무리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라연출_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State카메라연출_01 : TriggerState {
            internal State카메라연출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출_02 : TriggerState {
            internal State카메라연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Emotion_Disappoint_Idle_A", arg2: 14000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State카메라연출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출_03 : TriggerState {
            internal State카메라연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000139_QD__MAIN__22$",
                    desc: "$52000139_QD__MAIN__23$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 4000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State검은화면전환_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검은화면전환_01 : TriggerState {
            internal State검은화면전환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State검은화면전환_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검은화면전환_02 : TriggerState {
            internal State검은화면전환_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State밝은화면전환_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밝은화면전환_01 : TriggerState {
            internal State밝은화면전환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(arg1: "Emotion_Disappoint_Idle_A", arg2: 2000f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State기사와대화_00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_00 : TriggerState {
            internal State기사와대화_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "퀘스트수락_01", arg2: "nextState");
                context.AddCinematicTalk(npcID: 11003320, msg: "$52000139_QD__MAIN__0$", duration: 2500, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State기사와대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_01 : TriggerState {
            internal State기사와대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__1$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State기사와대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_02 : TriggerState {
            internal State기사와대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003320, msg: "$52000139_QD__MAIN__2$", duration: 2500, align: "left");
                context.AddCinematicTalk(npcID: 11003320, msg: "$52000139_QD__MAIN__3$", duration: 2500, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State기사와대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_03 : TriggerState {
            internal State기사와대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__4$", duration: 2500);
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__5$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State기사와대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_04 : TriggerState {
            internal State기사와대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003320, msg: "$52000139_QD__MAIN__6$", duration: 3000, align: "left");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State기사와대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_05 : TriggerState {
            internal State기사와대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__7$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State기사와대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_06 : TriggerState {
            internal State기사와대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.AddCinematicTalk(npcID: 11003321, msg: "$52000139_QD__MAIN__8$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State기사와대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기사와대화_07 : TriggerState {
            internal State기사와대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003320, msg: "$52000139_QD__MAIN__9$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State퀘스트수락_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트수락_01 : TriggerState {
            internal State퀘스트수락_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트수락_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트수락_02 : TriggerState {
            internal State퀘스트수락_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25201394, textID: 25201394);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {40002700},
                    arg3: new byte[] {1})) {
                    context.State = new State기지로이동_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25201394);
            }
        }

        private class State기지로이동_01 : TriggerState {
            internal State기지로이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(
                    arg1: new int[]
                        {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014},
                    arg2: true);
                context.ShowGuideSummary(entityID: 25201391, textID: 25201391);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {40002700},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트진행_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25201391);
            }
        }

        private class State퀘스트진행_01 : TriggerState {
            internal State퀘스트진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(
                    arg1: new int[]
                        {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014},
                    arg2: false);
                context.ShowGuideSummary(entityID: 25201392, textID: 25201392);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701, 702}, arg2: new int[] {40002700},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {107});
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
            }
        }

        private class State퀘스트완료가능_01 : TriggerState {
            internal State퀘스트완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25201392);
                context.ShowGuideSummary(entityID: 25201393, textID: 25201393);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {40002700},
                    arg3: new byte[] {3})) {
                    context.State = new State다시검은화면_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다시검은화면_01 : TriggerState {
            internal State다시검은화면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000139, arg2: 99);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State다시검은화면_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다시검은화면_02 : TriggerState {
            internal State다시검은화면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State부상병과대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_01 : TriggerState {
            internal State부상병과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25201393);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003327, msg: "$52000139_QD__MAIN__13$", duration: 3000);
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State부상병과대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_02 : TriggerState {
            internal State부상병과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__14$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State부상병과대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_03 : TriggerState {
            internal State부상병과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003327, msg: "$52000139_QD__MAIN__15$", duration: 2500);
                context.AddCinematicTalk(npcID: 11003327, msg: "$52000139_QD__MAIN__16$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State부상병과대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_04 : TriggerState {
            internal State부상병과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__17$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State부상병과대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_05 : TriggerState {
            internal State부상병과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003327, msg: "$52000139_QD__MAIN__18$", duration: 2500);
                context.AddCinematicTalk(npcID: 11003327, msg: "$52000139_QD__MAIN__19$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State부상병과대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_06 : TriggerState {
            internal State부상병과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__20$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State부상병과대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_07 : TriggerState {
            internal State부상병과대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004, 8005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State부상병과대화_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병과대화_08 : TriggerState {
            internal State부상병과대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52000139_QD__MAIN__21$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.MoveUser(arg1: 52000140, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}