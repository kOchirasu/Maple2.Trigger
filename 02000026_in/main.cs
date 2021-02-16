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
                    return new State아노스Exists01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001568}, arg3: new byte[] {1})) {
                    return new State아노스만남CinematicWait(context);
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
                    return new State아노스Exists01(context);
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
                    return new State아노스Exists01(context);
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

        private class State아노스Exists01 : TriggerState {
            internal State아노스Exists01(ITriggerContext context) : base(context) { }

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

        private class State아노스만남CinematicWait : TriggerState {
            internal State아노스만남CinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State아노스Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn : TriggerState {
            internal State아노스Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_00");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__0$", arg4: 4, arg5: 0);
                context.SetSceneSkip(state: new State아노스만남_스킵완료(context), arg2: "nextState");
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
                    return new State아노스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01 : TriggerState {
            internal State아노스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(state: new State아노스Script01_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera이동_라딘01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01_skip : TriggerState {
            internal State아노스Script01_skip(ITriggerContext context) : base(context) { }

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
                    return new State라딘Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script01 : TriggerState {
            internal State라딘Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.SetSkip(state: new State라딘Script01_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    return new State아노스Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script01_skip : TriggerState {
            internal State라딘Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스Script02(context);
            }

            public override void OnExit() { }
        }

        private class State아노스Script02 : TriggerState {
            internal State아노스Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__5$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State아노스Script02_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4519)) {
                    return new State라딘Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script02_skip : TriggerState {
            internal State아노스Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State라딘Script02(context);
            }

            public override void OnExit() { }
        }

        private class State라딘Script02 : TriggerState {
            internal State라딘Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "ChatUP_A");
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__6$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State라딘Script02_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    return new StateCamera이동_아노스01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script02_skip : TriggerState {
            internal State라딘Script02_skip(ITriggerContext context) : base(context) { }

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
                    return new State아노스Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script03 : TriggerState {
            internal State아노스Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "ChatUp_A");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__7$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아노스Script03_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6817)) {
                    return new State아노스Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script03_skip : TriggerState {
            internal State아노스Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스Script04(context);
            }

            public override void OnExit() { }
        }

        private class State아노스Script04 : TriggerState {
            internal State아노스Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__8$", arg4: 3, arg5: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                context.SetSkip(state: new State아노스Script04_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라딘Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script04_skip : TriggerState {
            internal State아노스Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State라딘Script03(context);
            }

            public override void OnExit() { }
        }

        private class State라딘Script03 : TriggerState {
            internal State라딘Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__9$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State라딘Script03_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePC안녕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script03_skip : TriggerState {
            internal State라딘Script03_skip(ITriggerContext context) : base(context) { }

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
                    return new State아노스Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script05 : TriggerState {
            internal State아노스Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__10$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아노스Script05_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3343)) {
                    return new State아노스Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script05_skip : TriggerState {
            internal State아노스Script05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스Script06(context);
            }

            public override void OnExit() { }
        }

        private class State아노스Script06 : TriggerState {
            internal State아노스Script06(ITriggerContext context) : base(context) { }

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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
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