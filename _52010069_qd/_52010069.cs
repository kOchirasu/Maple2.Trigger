namespace Maple2.Trigger._52010069_qd {
    public static class _52010069 {
        public class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100680}, arg3: new byte[] {3})) {
                    return new StateNPC소멸(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100680}, arg3: new byte[] {2})) {
                    return new State아이오브라펜타로(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100680}, arg3: new byte[] {1})) {
                    return new State전경씬_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100670}, arg3: new byte[] {2})) {
                    return new State전경씬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬 : TriggerState {
            internal State전경씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경씬_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_02 : TriggerState {
            internal State전경씬_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4000, 4001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전경씬_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_03 : TriggerState {
            internal State전경씬_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52010069_QD__52010069__0$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State전경씬_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_03_01 : TriggerState {
            internal State전경씬_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전경씬_03_02(context);
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
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전경씬_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_03_02 : TriggerState {
            internal State전경씬_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100680}, arg3: new byte[] {1})) {
                    return new State전경씬_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_04 : TriggerState {
            internal State전경씬_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경씬_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_04_01 : TriggerState {
            internal State전경씬_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010069, arg2: 6001);
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Object_React_H", arg2: 12000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__1$", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State조사중_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조사중_01 : TriggerState {
            internal State조사중_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조사중_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조사중_02 : TriggerState {
            internal State조사중_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__2$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__3$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__4$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State조사중_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조사중_03 : TriggerState {
            internal State조사중_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_01 : TriggerState {
            internal State재회_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__5$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재회_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_02 : TriggerState {
            internal State재회_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006, 4007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State재회_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_03 : TriggerState {
            internal State재회_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__6$", duration: 2800);
                context.MoveUser(arg1: 52010069, arg2: 6002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재회_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_04 : TriggerState {
            internal State재회_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData1");
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__7$", duration: 3000);
                context.AddCinematicTalk(npcId: 11001229, align: "left", illustId: "Ishura_Dark_Idle", msg: "$52010069_QD__52010069__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__9$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__10$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State재회_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_05 : TriggerState {
            internal State재회_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009, 4010}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010069_QD__52010069__11$", duration: 6000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State재회정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회정리 : TriggerState {
            internal State재회정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회정리_02 : TriggerState {
            internal State재회정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52010069, arg2: 6002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회정리_03 : TriggerState {
            internal State재회정리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100680}, arg3: new byte[] {2})) {
                    return new State아이오브라펜타로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이오브라펜타로 : TriggerState {
            internal State아이오브라펜타로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이오브라펜타로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이오브라펜타로_01 : TriggerState {
            internal State아이오브라펜타로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아이오브라펜타로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이오브라펜타로_02 : TriggerState {
            internal State아이오브라펜타로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000496, arg2: 5);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}