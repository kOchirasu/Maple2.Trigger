namespace Maple2.Trigger._52000128_qd {
    public static class _52000128_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.SetSkill(arg1: new[] {7001}, arg2: false);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: false);
                context.SetMesh(arg1: new[] {4001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new State영상준비_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Thief.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateStart_01(context);
                }

                if (context.WaitTick(waitTick: 33000)) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State금고폭파_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State금고폭파_01 : TriggerState {
            internal State금고폭파_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State금고폭파_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State금고폭파_02 : TriggerState {
            internal State금고폭파_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State금고폭파_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State금고폭파_03 : TriggerState {
            internal State금고폭파_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State폭파확인_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭파확인_01 : TriggerState {
            internal State폭파확인_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State빅스소개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스소개_01 : TriggerState {
            internal State빅스소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State빅스소개_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스소개_02 : TriggerState {
            internal State빅스소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003272, msg: "$52000128_QD__52000128_MAIN__0$", duration: 2000, align: "left");
                context.SetSceneSkip(arg1: "제시소개_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State빅스소개_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스소개_03 : TriggerState {
            internal State빅스소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000128_QD__52000128_MAIN__1$", desc: "$52000128_QD__52000128_MAIN__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State제시소개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제시소개_01 : TriggerState {
            internal State제시소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(arg1: new[] {8002, 8003}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제시소개_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제시소개_02 : TriggerState {
            internal State제시소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003273, msg: "$52000128_QD__52000128_MAIN__3$", duration: 2000, align: "left");
                context.SetSceneSkip(arg1: "카일소개_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제시소개_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제시소개_03 : TriggerState {
            internal State제시소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000128_QD__52000128_MAIN__4$", desc: "$52000128_QD__52000128_MAIN__5$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State카일소개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_01 : TriggerState {
            internal State카일소개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카일소개_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_02 : TriggerState {
            internal State카일소개_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일소개_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_03 : TriggerState {
            internal State카일소개_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003280, msg: "$52000128_QD__52000128_MAIN__6$", duration: 2351, align: "left");
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_B");
                context.SetSceneSkip(arg1: "Quest시작_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카일소개_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일소개_04 : TriggerState {
            internal State카일소개_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000128_QD__52000128_MAIN__7$", desc: "$52000128_QD__52000128_MAIN__8$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateQuest시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest시작_01 : TriggerState {
            internal StateQuest시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 2.0f);
                context.ShowGuideSummary(entityId: 25201281, textId: 25201281);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002690}, arg3: new byte[] {1})) {
                    return new StateQuest진행_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002690}, arg3: new byte[] {2})) {
                    return new StateQuest완료가능_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002690}, arg3: new byte[] {3})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행_01 : TriggerState {
            internal StateQuest진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201281);
                context.ShowGuideSummary(entityId: 25201282, textId: 25201282);
                context.SetEffect(arg1: new[] {5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    return new StateQuest진행_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행_02 : TriggerState {
            internal StateQuest진행_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002690}, arg3: new byte[] {2})) {
                    return new StateQuest완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료가능_01 : TriggerState {
            internal StateQuest완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201281);
                context.HideGuideSummary(entityId: 25201282);
                context.ShowGuideSummary(entityId: 25201283, textId: 25201283);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002690}, arg3: new byte[] {3})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201281);
                context.HideGuideSummary(entityId: 25201282);
                context.HideGuideSummary(entityId: 25201283);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2005");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2007");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State밝은화면_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝은화면_01 : TriggerState {
            internal State밝은화면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잡담_01 : TriggerState {
            internal State잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000128_QD__52000128_MAIN__9$", arg4: 2, arg5: 0);
                context.SetSceneSkip(arg1: "교도관등장_06", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잡담_02 : TriggerState {
            internal State잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {107, 109, 111, 113, 115}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000128_QD__52000128_MAIN__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State교도관Appear_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_01 : TriggerState {
            internal State교도관Appear_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2010");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2008");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2009");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State교도관Appear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_02 : TriggerState {
            internal State교도관Appear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000128_QD__52000128_MAIN__21$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State교도관Appear_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_03 : TriggerState {
            internal State교도관Appear_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관Appear_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_04 : TriggerState {
            internal State교도관Appear_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2012");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관Appear_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_05 : TriggerState {
            internal State교도관Appear_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000128_QD__52000128_MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State교도관Appear_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_06 : TriggerState {
            internal State교도관Appear_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.MoveUserPath(arg1: "MS2PatrolData_2013");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관Appear_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_07 : TriggerState {
            internal State교도관Appear_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2014");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State교도관Appear_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관Appear_08 : TriggerState {
            internal State교도관Appear_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State교도관전투_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 102, 104});
            }
        }

        private class State교도관전투_01 : TriggerState {
            internal State교도관전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201284, textId: 25201284);
                context.DestroyMonster(arg1: new[] {107, 109, 111, 113, 115});
                context.CreateMonster(arg1: new[] {108, 110, 112, 114, 116}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {108, 110, 112, 114, 116})) {
                    return new State교도관전투끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_01 : TriggerState {
            internal State교도관전투끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201284);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교도관전투끝_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_02 : TriggerState {
            internal State교도관전투끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000128, arg2: 99);
                context.CreateMonster(arg1: new[] {117, 118, 119, 120, 121});
                context.CreateMonster(arg1: new[] {105}, arg2: true);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2011");
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 117, arg2: "Dead_Idle_A", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 118, arg2: "Dead_Idle_B", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 119, arg2: "Dead_Idle_B", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 120, arg2: "Dead_Idle_B", arg3: 3600000f);
                context.SetNpcEmotionLoop(arg1: 121, arg2: "Dead_Idle_A", arg3: 3600000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State교도관전투끝_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교도관전투끝_03 : TriggerState {
            internal State교도관전투끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투끝_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝_04 : TriggerState {
            internal State전투끝_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "벨마등장_06", arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, msg: "$52000128_QD__52000128_MAIN__12$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State전투끝_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝_05 : TriggerState {
            internal State전투끝_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52000128_QD__52000128_MAIN__13$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State벨마Appear_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Appear_01 : TriggerState {
            internal State벨마Appear_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State벨마Appear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Appear_02 : TriggerState {
            internal State벨마Appear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003274, msg: "$52000128_QD__52000128_MAIN__14$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State벨마Appear_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Appear_03 : TriggerState {
            internal State벨마Appear_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52000128_QD__52000128_MAIN__15$", duration: 4000, align: "right");
                context.SetPcEmotionSequence(arg1: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State벨마Appear_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Appear_04 : TriggerState {
            internal State벨마Appear_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벨마Appear_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Appear_05 : TriggerState {
            internal State벨마Appear_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003274, msg: "$52000128_QD__52000128_MAIN__16$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State벨마Appear_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Appear_06 : TriggerState {
            internal State벨마Appear_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State벨마전투_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투_01 : TriggerState {
            internal State벨마전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201285, textId: 25201285);
                context.DestroyMonster(arg1: new[] {105});
                context.CreateMonster(arg1: new[] {106}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "battleStop") == 1) {
                    return new State벨마전투끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_01 : TriggerState {
            internal State벨마전투끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201285);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벨마전투끝_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_02 : TriggerState {
            internal State벨마전투끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000128, arg2: 99);
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {105}, arg2: true);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2011");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State벨마전투끝_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마전투끝_03 : TriggerState {
            internal State벨마전투끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.FaceEmotion(spawnPointId: 0);
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52000128_QD__52000128_MAIN__17$", duration: 3000, align: "right");
                context.AddCinematicTalk(npcId: 0, msg: "$52000128_QD__52000128_MAIN__18$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State전투후대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State불길_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불길_01 : TriggerState {
            internal State불길_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈출_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출_01 : TriggerState {
            internal State탈출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8011}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000128_QD__52000128_MAIN__19$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈출_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출_02 : TriggerState {
            internal State탈출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2014");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State탈출_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출_03 : TriggerState {
            internal State탈출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003274, msg: "$52000128_QD__52000128_MAIN__20$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마무리(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000129, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}