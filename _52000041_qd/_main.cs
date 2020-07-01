namespace Maple2.Trigger._52000041_qd {
    public static class _main {
        public class State50001392완료조건체크 : TriggerState {
            internal State50001392완료조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606}, arg2: false);
            }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001392}, arg3: new byte[] {3})) {
                    context.State = new State상태01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001392}, arg3: new byte[] {3})) {
                    context.State = new State상태02조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State50001402진행조건체크 : TriggerState {
            internal State50001402진행조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001402}, arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001402}, arg3: new byte[] {1})) {
                    context.State = new State50001400진행조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State50001400진행조건체크 : TriggerState {
            internal State50001400진행조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001400}, arg3: new byte[] {1})) {
                    context.State = new State상태02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001400}, arg3: new byte[] {2})) {
                    context.State = new State상태02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001400}, arg3: new byte[] {3})) {
                    context.State = new State상태02(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State상태01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태02조건 : TriggerState {
            internal State상태02조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001421}, arg3: new byte[] {3})) {
                    context.State = new State50001402진행조건체크(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001421}, arg3: new byte[] {3})) {
                    context.State = new State상태03조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태03조건 : TriggerState {
            internal State상태03조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001431}, arg3: new byte[] {3})) {
                    context.State = new State상태03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001431}, arg3: new byte[] {3})) {
                    context.State = new State상태03_2조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태03_2조건 : TriggerState {
            internal State상태03_2조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001432}, arg3: new byte[] {3})) {
                    context.State = new State상태03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001432}, arg3: new byte[] {3})) {
                    context.State = new State상태04조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태04조건 : TriggerState {
            internal State상태04조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001433}, arg3: new byte[] {3})) {
                    context.State = new State상태04(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001432}, arg3: new byte[] {2})) {
                    context.State = new State상태07(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001433}, arg3: new byte[] {3})) {
                    context.State = new State상태05조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태05조건 : TriggerState {
            internal State상태05조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001444}, arg3: new byte[] {3})) {
                    context.State = new State상태05(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001444}, arg3: new byte[] {3})) {
                    context.State = new State상태06조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태06조건 : TriggerState {
            internal State상태06조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001450}, arg3: new byte[] {3})) {
                    context.State = new State상태06(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001450}, arg3: new byte[] {3})) {
                    context.State = new State상태06_2조건(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태06_2조건 : TriggerState {
            internal State상태06_2조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {3})) {
                    context.State = new State상태06(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {3})) {
                    context.State = new State상태07조건(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태07조건 : TriggerState {
            internal State상태07조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {1})) {
                    context.State = new State상태06(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {2})) {
                    context.State = new State상태07(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001453}, arg3: new byte[] {3})) {
                    context.State = new State상태08조건(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태08조건 : TriggerState {
            internal State상태08조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {3})) {
                    context.State = new State상태08(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태01 : TriggerState {
            internal State상태01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태02 : TriggerState {
            internal State상태02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002, 2002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태03 : TriggerState {
            internal State상태03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태04 : TriggerState {
            internal State상태04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태05 : TriggerState {
            internal State상태05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태06 : TriggerState {
            internal State상태06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006, 2006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태07 : TriggerState {
            internal State상태07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상태08 : TriggerState {
            internal State상태08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1000, 2000, 3000}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2000, arg2: "DownIdle_A", arg3: 2000f);
                context.SetNpcEmotionLoop(arg1: 3000, arg2: "Talk_A", arg3: 30000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_2000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateNPC이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_9000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State어흥이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사01 : TriggerState {
            internal State어흥이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__0$", arg4: 3);
                context.SetSkip(arg1: "어흥이대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State틴차이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사01스킵 : TriggerState {
            internal State어흥이대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State틴차이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01 : TriggerState {
            internal State틴차이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__1$", arg4: 3);
                context.SetSkip(arg1: "틴차이대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State준타대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01스킵 : TriggerState {
            internal State틴차이대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01 : TriggerState {
            internal State준타대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__2$", arg4: 6);
                context.SetSkip(arg1: "준타대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State어흥이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01스킵 : TriggerState {
            internal State준타대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State어흥이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사02 : TriggerState {
            internal State어흥이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__3$", arg4: 4);
                context.SetSkip(arg1: "어흥이대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State준타대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사02스킵 : TriggerState {
            internal State어흥이대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02 : TriggerState {
            internal State준타대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__4$", arg4: 5);
                context.SetSkip(arg1: "준타대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State준타대사02_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02스킵 : TriggerState {
            internal State준타대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사02_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02_2 : TriggerState {
            internal State준타대사02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__5$", arg4: 3);
                context.SetSkip(arg1: "준타대사02_2스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State어흥이대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02_2스킵 : TriggerState {
            internal State준타대사02_2스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State어흥이대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사03 : TriggerState {
            internal State어흥이대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__6$", arg4: 3);
                context.SetSkip(arg1: "어흥이대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사03스킵 : TriggerState {
            internal State어흥이대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동03 : TriggerState {
            internal StateNPC이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1000B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State틴차이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02 : TriggerState {
            internal State틴차이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__7$", arg4: 3);
                context.SetSkip(arg1: "틴차이대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State틴차이대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02스킵 : TriggerState {
            internal State틴차이대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State틴차이대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사03 : TriggerState {
            internal State틴차이대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__8$", arg4: 3);
                context.SetSkip(arg1: "틴차이대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State틴차이대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사03스킵 : TriggerState {
            internal State틴차이대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State틴차이대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사04 : TriggerState {
            internal State틴차이대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__9$", arg4: 3);
                context.SetSkip(arg1: "틴차이대사04스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State말풍선대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사04스킵 : TriggerState {
            internal State틴차이대사04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State말풍선대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사01 : TriggerState {
            internal State말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1000, arg3: "$52000041_QD__MAIN__10$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 3000, arg3: "$52000041_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State말풍선대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사02 : TriggerState {
            internal State말풍선대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2000, arg3: "$52000041_QD__MAIN__15$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State말풍선대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사03 : TriggerState {
            internal State말풍선대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 3000, arg3: "$52000041_QD__MAIN__16$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State말풍선대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사04 : TriggerState {
            internal State말풍선대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1000, arg3: "$52000041_QD__MAIN__17$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State말풍선대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사05 : TriggerState {
            internal State말풍선대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000041_QD__MAIN__18$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State준타대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사03 : TriggerState {
            internal State준타대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__12$", arg4: 5);
                context.SetSkip(arg1: "준타대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State어흥이대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사03스킵 : TriggerState {
            internal State준타대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State어흥이대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사05 : TriggerState {
            internal State어흥이대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__13$", arg4: 4);
                context.SetSkip(arg1: "어흥이대사05스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State어흥이대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사05스킵 : TriggerState {
            internal State어흥이대사05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State어흥이대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사06 : TriggerState {
            internal State어흥이대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__14$", arg4: 1);
                context.SetSkip(arg1: "어흥이대사06스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateNPC이동04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어흥이대사06스킵 : TriggerState {
            internal State어흥이대사06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC이동04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동04 : TriggerState {
            internal StateNPC이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 3000, arg2: "MS2PatrolData_3000");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 101, arg2: new[] {3000})) {
                    context.DestroyMonster(arg1: new[] {3000});
                    context.State = new StateNPC이동05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동05 : TriggerState {
            internal StateNPC이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: false);
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1000C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DestroyMonster(arg1: new[] {1000, 2000});
                    context.CreateMonster(arg1: new[] {1010, 2010}, arg2: false);
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "gdreunion");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}