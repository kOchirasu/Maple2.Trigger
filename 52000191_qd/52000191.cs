using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000191_qd {
    public static class _52000191 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001, 6008, 6015, 6022, 6033}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003412}, arg3: new byte[] {1})) {
                    return new StateCameraEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.MoveUser(arg1: 52000191, arg2: 5001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4002, 4003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000191_QD__52000191__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State바론과첫만남_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_01 : TriggerState {
            internal State바론과첫만남_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4004}, arg2: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__1$", duration: 5000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__2$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State바론과첫만남_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_02 : TriggerState {
            internal State바론과첫만남_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4005, 4006}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 5000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__3$", duration: 5000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__4$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State바론과첫만남_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_02_02 : TriggerState {
            internal State바론과첫만남_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 5000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__5$", duration: 5000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__6$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__7$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State바론과첫만남_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바론과첫만남_03 : TriggerState {
            internal State바론과첫만남_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__8$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__9$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare : TriggerState {
            internal State전투Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.MoveUser(arg1: 52000191, arg2: 5003);
                context.CameraSelectPath(pathIds: new[] {4007, 4008}, arg2: false);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__10$", duration: 4000);
                context.SetEffect(arg1: new[] {6029, 6030, 6031}, arg2: true);
                context.CreateMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State전투Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare_02 : TriggerState {
            internal State전투Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투Prepare_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000191, arg2: 5003);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투Prepare_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare_03 : TriggerState {
            internal State전투Prepare_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103});
                context.VisibleMyPc(isVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Phase : TriggerState {
            internal State1Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007}, arg2: true);
                context.CreateMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203});
                context.CreateMonster(arg1: new[] {204});
                context.CreateMonster(arg1: new[] {205});
                context.CreateMonster(arg1: new[] {206});
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206})) {
                    return new State2Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Phase : TriggerState {
            internal State2Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004787, illust: "Baron_normal", script: "$52000191_QD__52000191__11$", duration: 3000);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.SetEffect(arg1: new[] {6015, 6016, 6017, 6018, 6019, 6020, 6021}, arg2: true);
                context.CreateMonster(arg1: new[] {213});
                context.CreateMonster(arg1: new[] {214});
                context.CreateMonster(arg1: new[] {215});
                context.CreateMonster(arg1: new[] {216});
                context.CreateMonster(arg1: new[] {217});
                context.CreateMonster(arg1: new[] {218});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {213, 214, 215, 216, 217, 218})) {
                    return new State3Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Phase : TriggerState {
            internal State3Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004787, illust: "Baron_normal", script: "$52000191_QD__52000191__12$", duration: 3000);
                context.SetEffect(arg1: new[] {6015}, arg2: false);
                context.SetEffect(arg1: new[] {6008, 6009, 6010, 6011, 6012, 6013, 6014}, arg2: true);
                context.CreateMonster(arg1: new[] {207});
                context.CreateMonster(arg1: new[] {208});
                context.CreateMonster(arg1: new[] {209});
                context.CreateMonster(arg1: new[] {210});
                context.CreateMonster(arg1: new[] {211});
                context.CreateMonster(arg1: new[] {212});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {207, 208, 209, 210, 211, 212})) {
                    return new State4Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4Phase : TriggerState {
            internal State4Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004787, illust: "Baron_normal", script: "$52000191_QD__52000191__13$", duration: 3000);
                context.SetEffect(arg1: new[] {6008}, arg2: false);
                context.SetEffect(arg1: new[] {6022, 6023, 6024, 6025, 6026, 6027, 6028}, arg2: true);
                context.CreateMonster(arg1: new[] {219});
                context.CreateMonster(arg1: new[] {220});
                context.CreateMonster(arg1: new[] {221});
                context.CreateMonster(arg1: new[] {222});
                context.CreateMonster(arg1: new[] {223});
                context.CreateMonster(arg1: new[] {224});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {219, 220, 221, 222, 223, 224})) {
                    return new State5Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5Phase : TriggerState {
            internal State5Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004787, illust: "Baron_normal", script: "$52000191_QD__52000191__14$", duration: 3000);
                context.SetEffect(arg1: new[] {6022}, arg2: false);
                context.SetEffect(arg1: new[] {6033, 6032, 6034, 6035, 6036, 6037, 6038}, arg2: true);
                context.CreateMonster(arg1: new[] {225});
                context.CreateMonster(arg1: new[] {226});
                context.CreateMonster(arg1: new[] {227});
                context.CreateMonster(arg1: new[] {228});
                context.CreateMonster(arg1: new[] {229});
                context.CreateMonster(arg1: new[] {230});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {225, 226, 227, 228, 229, 230})) {
                    return new State고마해(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해 : TriggerState {
            internal State고마해(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State고마해_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_02 : TriggerState {
            internal State고마해_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6033}, arg2: false);
                context.CameraSelectPath(pathIds: new[] {4009}, arg2: false);
                context.MoveUser(arg1: 52000191, arg2: 5002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State고마해_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_03 : TriggerState {
            internal State고마해_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State고마해_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_04 : TriggerState {
            internal State고마해_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {4004}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 5000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__15$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__16$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State고마해_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_05 : TriggerState {
            internal State고마해_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4011, 4012}, arg2: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__17$", duration: 5000);
                context.AddCinematicTalk(npcId: 0, script: "$52000191_QD__52000191__18$", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State고마해_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_06 : TriggerState {
            internal State고마해_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4013, 4014}, arg2: false);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__19$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000191_QD__52000191__20$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State고마해_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State고마해_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고마해_07 : TriggerState {
            internal State고마해_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 2001, arg3: "BattlewithBaron");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State그만싸워(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그만싸워 : TriggerState {
            internal State그만싸워(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}