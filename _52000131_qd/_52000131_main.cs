namespace Maple2.Trigger._52000131_qd {
    public static class _52000131_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new State침대로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침대로이동 : TriggerState {
            internal State침대로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000131, arg2: 99);
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카메라이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라이동_01 : TriggerState {
            internal State카메라이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 80000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Think_A");
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State페이드인1_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페이드인1_01 : TriggerState {
            internal State페이드인1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State독백_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_01 : TriggerState {
            internal State독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000131_QD__52000131_MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카메라이동1_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라이동1_01 : TriggerState {
            internal State카메라이동1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State버튼등장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼등장_01 : TriggerState {
            internal State버튼등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼등장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼등장_02 : TriggerState {
            internal State버튼등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼등장_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼등장_03 : TriggerState {
            internal State버튼등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_01 : TriggerState {
            internal State버튼과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_02 : TriggerState {
            internal State버튼과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__1$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_03 : TriggerState {
            internal State버튼과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.FaceEmotion(spawnPointId: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_04 : TriggerState {
            internal State버튼과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000131_QD__52000131_MAIN__2$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_05 : TriggerState {
            internal State버튼과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_06 : TriggerState {
            internal State버튼과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__3$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_07 : TriggerState {
            internal State버튼과대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_08 : TriggerState {
            internal State버튼과대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000131_QD__52000131_MAIN__4$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_09 : TriggerState {
            internal State버튼과대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_10 : TriggerState {
            internal State버튼과대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__5$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_11 : TriggerState {
            internal State버튼과대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_12 : TriggerState {
            internal State버튼과대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000131_QD__52000131_MAIN__6$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_13 : TriggerState {
            internal State버튼과대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_14 : TriggerState {
            internal State버튼과대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__7$", duration: 4000, align: "right");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_15 : TriggerState {
            internal State버튼과대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000131_QD__52000131_MAIN__8$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_16 : TriggerState {
            internal State버튼과대화_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__9$", duration: 4000, align: "right");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_17 : TriggerState {
            internal State버튼과대화_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000131_QD__52000131_MAIN__10$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_18 : TriggerState {
            internal State버튼과대화_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__11$", duration: 3000, align: "right");
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__12$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State버튼과대화_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_19 : TriggerState {
            internal State버튼과대화_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__13$", duration: 3000, align: "right");
                context.AddCinematicTalk(npcId: 11001540, msg: "$52000131_QD__52000131_MAIN__14$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State버튼과대화_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_20 : TriggerState {
            internal State버튼과대화_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_21 : TriggerState {
            internal State버튼과대화_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000131_QD__52000131_MAIN__15$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}