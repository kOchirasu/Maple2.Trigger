namespace Maple2.Trigger._52000104_qd {
    public static class _52000104 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {205}, arg2: false);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10011})) {
                    return new State영상준비_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000104, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Berserker.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State리엔전경씬01(context);
                }

                if (context.WaitTick(waitTick: 75000)) {
                    return new State리엔전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬01 : TriggerState {
            internal State리엔전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1000, 1001}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔전경씬01_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬01_B : TriggerState {
            internal State리엔전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리엔전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬02 : TriggerState {
            internal State리엔전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리엔전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬03 : TriggerState {
            internal State리엔전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000104_QD__52000104__0$", desc: "$52000104_QD__52000104__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬04 : TriggerState {
            internal State리엔전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000104_QD__52000104__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201041, textId: 25201041, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10012})) {
                    return new State리린과대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화01 : TriggerState {
            internal State리린과대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveUser(arg1: 52000104, arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리린과대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화02 : TriggerState {
            internal State리린과대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Ririn_Go");
                context.CameraSelectPath(arg1: new[] {1004, 1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리린과대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화03 : TriggerState {
            internal State리린과대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1006, 1007}, arg2: false);
                context.FaceEmotion(spawnPointId: 200, emotionName: "hello_Cait");
                context.ShowCaption(type: "NameCaption", title: "$52000104_QD__52000104__3$", desc: "$52000104_QD__52000104__4$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State리린과대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화04 : TriggerState {
            internal State리린과대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리린과대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리린과대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화05 : TriggerState {
            internal State리린과대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317}, arg2: false);
                context.FaceEmotion(spawnPointId: 200);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002316}, arg3: new byte[] {1})) {
                    return new State꽃가꾸기Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002317}, arg3: new byte[] {1})) {
                    return new State꽃섬멸Quest01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002317}, arg3: new byte[] {3})) {
                    return new State할아버지Appear씬01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {1})) {
                    return new State할아버지Appear씬01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {2})) {
                    return new State할아버지Appear씬01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {3})) {
                    return new State할아버지Appear씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃가꾸기Quest01 : TriggerState {
            internal State꽃가꾸기Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201042, textId: 25201042, duration: 10000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Ririn_Go2");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002317}, arg3: new byte[] {1})) {
                    return new State꽃섬멸Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃섬멸Quest01 : TriggerState {
            internal State꽃섬멸Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1006, 1007}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Ririn_Go2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State꽃섬멸Quest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃섬멸Quest02 : TriggerState {
            internal State꽃섬멸Quest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1006, 1007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State꽃섬멸Quest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃섬멸Quest03 : TriggerState {
            internal State꽃섬멸Quest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.CreateMonster(arg1: new[] {200, 201, 202, 203, 204}, arg2: false);
                context.SetSound(arg1: 9000, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000104_QD__52000104__5$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201043, textId: 25201043, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002317}, arg3: new byte[] {3})) {
                    return new State할아버지Appear씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Appear씬01 : TriggerState {
            internal State할아버지Appear씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9000, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State할아버지Appear씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Appear씬02 : TriggerState {
            internal State할아버지Appear씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_ten_go");
                context.CameraSelectPath(arg1: new[] {1008, 1009}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지Appear씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Appear씬03 : TriggerState {
            internal State할아버지Appear씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003175, illustId: "Ten_normal", msg: "$52000104_QD__52000104__6$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State할아버지Appear씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Appear씬04 : TriggerState {
            internal State할아버지Appear씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", title: "$52000104_QD__52000104__7$", desc: "$52000104_QD__52000104__8$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State할아버지Appear씬04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Appear씬04_1 : TriggerState {
            internal State할아버지Appear씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지Appear씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_ten_go");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지Appear씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Appear씬05 : TriggerState {
            internal State할아버지Appear씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_ririn_move");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {1})) {
                    return new State대검바라보기01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {2})) {
                    return new State대검바라보기01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {3})) {
                    return new State수련장으로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대검바라보기01 : TriggerState {
            internal State대검바라보기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Ririn_Go3");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_ten_go2");
                context.ShowGuideSummary(entityId: 25201044, textId: 25201044, duration: 10000);
                context.SetEffect(arg1: new[] {5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002319}, arg3: new byte[] {3})) {
                    return new State수련장으로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장으로이동01 : TriggerState {
            internal State수련장으로이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Ririn_Go");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_ten_exit");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000104_QD__52000104__9$", duration: 6000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000104_QD__52000104__10$", duration: 6000, delayTick: 2500);
                context.ShowGuideSummary(entityId: 25201045, textId: 25201045, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 10013, arg2: new[] {102})) {
                    return new State수련장으로이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장으로이동02 : TriggerState {
            internal State수련장으로이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}