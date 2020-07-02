namespace Maple2.Trigger._02000026_in {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568}, arg3: new byte[] {3})) {
                    return new State조건체크01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568}, arg3: new byte[] {2})) {
                    return new State아노스있음01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568}, arg3: new byte[] {1})) {
                    return new State아노스만남연출대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001567}, arg3: new byte[] {3})) {
                    return new StateWait조건01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001567}, arg3: new byte[] {2})) {
                    return new StateWait조건01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001567}, arg3: new byte[] {1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait조건01 : TriggerState {
            internal StateWait조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568}, arg3: new byte[] {1})) {
                    return new State아노스만남StartCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568}, arg3: new byte[] {1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크01 : TriggerState {
            internal State조건체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001569}, arg3: new byte[] {1})) {
                    return new State아노스있음01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001569}, arg3: new byte[] {1})) {
                    return new State조건체크02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크02 : TriggerState {
            internal State조건체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001573}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568, 50001569, 50001570, 50001571, 50001572, 50001573}, arg3: new byte[] {2})) {
                    return new State아노스있음01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스있음01 : TriggerState {
            internal State아노스있음01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스만남연출대기 : TriggerState {
            internal State아노스만남연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_PC_00");
                    return new State아노스만남StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스만남StartCinematic : TriggerState {
            internal State아노스만남StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State아노스Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Appear : TriggerState {
            internal State아노스Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_00");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__0$", arg4: 4, arg5: 0);
                context.SetSceneSkip(arg1: "아노스만남_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스이동01 : TriggerState {
            internal State아노스이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_01");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3239)) {
                    return new State아노스이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스이동02 : TriggerState {
            internal State아노스이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스이동03 : TriggerState {
            internal State아노스이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__2$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "ChatUp_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    return new State아노스대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사01 : TriggerState {
            internal State아노스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아노스대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera이동_라딘01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사01_skip : TriggerState {
            internal State아노스대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateCamera이동_라딘01(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_라딘01 : TriggerState {
            internal StateCamera이동_라딘01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대사01 : TriggerState {
            internal State라딘대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.SetSkip(arg1: "라딘대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    return new State아노스대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대사01_skip : TriggerState {
            internal State라딘대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사02(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사02 : TriggerState {
            internal State아노스대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__5$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "아노스대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4519)) {
                    return new State라딘대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사02_skip : TriggerState {
            internal State아노스대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State라딘대사02(context);
            }

            public override void OnExit() { }
        }

        private class State라딘대사02 : TriggerState {
            internal State라딘대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "ChatUP_A");
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__6$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "라딘대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    return new StateCamera이동_아노스01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대사02_skip : TriggerState {
            internal State라딘대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateCamera이동_아노스01(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_아노스01 : TriggerState {
            internal StateCamera이동_아노스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사03 : TriggerState {
            internal State아노스대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "ChatUp_A");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__7$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "아노스대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6817)) {
                    return new State아노스대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사03_skip : TriggerState {
            internal State아노스대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사04(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사04 : TriggerState {
            internal State아노스대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__8$", arg4: 3, arg5: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                context.SetSkip(arg1: "아노스대사04_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라딘대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사04_skip : TriggerState {
            internal State아노스대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State라딘대사03(context);
            }

            public override void OnExit() { }
        }

        private class State라딘대사03 : TriggerState {
            internal State라딘대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__9$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "라딘대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePC안녕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대사03_skip : TriggerState {
            internal State라딘대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePC안녕(context);
            }

            public override void OnExit() { }
        }

        private class StatePC안녕 : TriggerState {
            internal StatePC안녕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Hello_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사05 : TriggerState {
            internal State아노스대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__10$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "아노스대사05_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3343)) {
                    return new State아노스대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사05_skip : TriggerState {
            internal State아노스대사05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사06(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사06 : TriggerState {
            internal State아노스대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__11$", arg4: 3, arg5: 0);
                context.ShowCaption(type: "NameCaption", title: "$02000026_IN__MAIN__12$", desc: "$02000026_IN__MAIN__13$", align: "centerLeft", offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 5000, scale: 2.0f);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스만남_스킵완료 : TriggerState {
            internal State아노스만남_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "MeetAnos");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}