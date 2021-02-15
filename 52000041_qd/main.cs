namespace Maple2.Trigger._52000041_qd {
    public static class _main {
        public class State50001392완료ConditionCheck : TriggerState {
            internal State50001392완료ConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001392}, arg3: new byte[] {3})) {
                    return new State01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001392}, arg3: new byte[] {3})) {
                    return new State02조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50001402진행ConditionCheck : TriggerState {
            internal State50001402진행ConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001402}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001402}, arg3: new byte[] {1})) {
                    return new State50001400진행ConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50001400진행ConditionCheck : TriggerState {
            internal State50001400진행ConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001400}, arg3: new byte[] {1})) {
                    return new State02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001400}, arg3: new byte[] {2})) {
                    return new State02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001400}, arg3: new byte[] {3})) {
                    return new State02(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02조건 : TriggerState {
            internal State02조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001421}, arg3: new byte[] {3})) {
                    return new State50001402진행ConditionCheck(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001421}, arg3: new byte[] {3})) {
                    return new State03조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03조건 : TriggerState {
            internal State03조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001431}, arg3: new byte[] {3})) {
                    return new State03(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001431}, arg3: new byte[] {3})) {
                    return new State03_2조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03_2조건 : TriggerState {
            internal State03_2조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001432}, arg3: new byte[] {3})) {
                    return new State03(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001432}, arg3: new byte[] {3})) {
                    return new State04조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State04조건 : TriggerState {
            internal State04조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001433}, arg3: new byte[] {3})) {
                    return new State04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001432}, arg3: new byte[] {2})) {
                    return new State07(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001433}, arg3: new byte[] {3})) {
                    return new State05조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State05조건 : TriggerState {
            internal State05조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001444}, arg3: new byte[] {3})) {
                    return new State05(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001444}, arg3: new byte[] {3})) {
                    return new State06조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State06조건 : TriggerState {
            internal State06조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001450}, arg3: new byte[] {3})) {
                    return new State06(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001450}, arg3: new byte[] {3})) {
                    return new State06_2조건(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State06_2조건 : TriggerState {
            internal State06_2조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {3})) {
                    return new State06(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {3})) {
                    return new State07조건(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State07조건 : TriggerState {
            internal State07조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {1})) {
                    return new State06(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001451}, arg3: new byte[] {2})) {
                    return new State07(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001453}, arg3: new byte[] {3})) {
                    return new State08조건(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State08조건 : TriggerState {
            internal State08조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {3})) {
                    return new State08(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01 : TriggerState {
            internal State01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02 : TriggerState {
            internal State02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03 : TriggerState {
            internal State03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State04 : TriggerState {
            internal State04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State05 : TriggerState {
            internal State05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State06 : TriggerState {
            internal State06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006, 2006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State07 : TriggerState {
            internal State07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State08 : TriggerState {
            internal State08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1000, 2000, 3000}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2000, arg2: "DownIdle_A", arg3: 2000f);
                context.SetNpcEmotionLoop(arg1: 3000, arg2: "Talk_A", arg3: 30000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_2000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_9000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State어흥이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어흥이Script01 : TriggerState {
            internal State어흥이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__0$", arg4: 3);
                context.SetSkip(arg1: "어흥이Script01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State틴차이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어흥이Script01스킵 : TriggerState {
            internal State어흥이Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이Script01(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01 : TriggerState {
            internal State틴차이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__1$", arg4: 3);
                context.SetSkip(arg1: "틴차이Script01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01스킵 : TriggerState {
            internal State틴차이Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타Script01(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script01 : TriggerState {
            internal State준타Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__2$", arg4: 6);
                context.SetSkip(arg1: "준타Script01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State어흥이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01스킵 : TriggerState {
            internal State준타Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State어흥이Script02(context);
            }

            public override void OnExit() { }
        }

        private class State어흥이Script02 : TriggerState {
            internal State어흥이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__3$", arg4: 4);
                context.SetSkip(arg1: "어흥이Script02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어흥이Script02스킵 : TriggerState {
            internal State어흥이Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타Script02(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script02 : TriggerState {
            internal State준타Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__4$", arg4: 5);
                context.SetSkip(arg1: "준타Script02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타Script02_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script02스킵 : TriggerState {
            internal State준타Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타Script02_2(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script02_2 : TriggerState {
            internal State준타Script02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__5$", arg4: 3);
                context.SetSkip(arg1: "준타Script02_2스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State어흥이Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script02_2스킵 : TriggerState {
            internal State준타Script02_2스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State어흥이Script03(context);
            }

            public override void OnExit() { }
        }

        private class State어흥이Script03 : TriggerState {
            internal State어흥이Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__6$", arg4: 3);
                context.SetSkip(arg1: "어흥이Script03스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어흥이Script03스킵 : TriggerState {
            internal State어흥이Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateNPC이동03(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC이동03 : TriggerState {
            internal StateNPC이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1000B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State틴차이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script02 : TriggerState {
            internal State틴차이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__7$", arg4: 3);
                context.SetSkip(arg1: "틴차이Script02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State틴차이Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script02스킵 : TriggerState {
            internal State틴차이Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이Script03(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script03 : TriggerState {
            internal State틴차이Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__8$", arg4: 3);
                context.SetSkip(arg1: "틴차이Script03스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State틴차이Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script03스킵 : TriggerState {
            internal State틴차이Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이Script04(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script04 : TriggerState {
            internal State틴차이Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000041_QD__MAIN__9$", arg4: 3);
                context.SetSkip(arg1: "틴차이Script04스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State말풍선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script04스킵 : TriggerState {
            internal State틴차이Script04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State말풍선Script01(context);
            }

            public override void OnExit() { }
        }

        private class State말풍선Script01 : TriggerState {
            internal State말풍선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1000, arg3: "$52000041_QD__MAIN__10$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 3000, arg3: "$52000041_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State말풍선Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script02 : TriggerState {
            internal State말풍선Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2000, arg3: "$52000041_QD__MAIN__15$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State말풍선Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script03 : TriggerState {
            internal State말풍선Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 3000, arg3: "$52000041_QD__MAIN__16$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State말풍선Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script04 : TriggerState {
            internal State말풍선Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1000, arg3: "$52000041_QD__MAIN__17$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State말풍선Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script05 : TriggerState {
            internal State말풍선Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000041_QD__MAIN__18$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State준타Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script03 : TriggerState {
            internal State준타Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000041_QD__MAIN__12$", arg4: 5);
                context.SetSkip(arg1: "준타Script03스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어흥이Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script03스킵 : TriggerState {
            internal State준타Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State어흥이Script05(context);
            }

            public override void OnExit() { }
        }

        private class State어흥이Script05 : TriggerState {
            internal State어흥이Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__13$", arg4: 4);
                context.SetSkip(arg1: "어흥이Script05스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State어흥이Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어흥이Script05스킵 : TriggerState {
            internal State어흥이Script05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State어흥이Script06(context);
            }

            public override void OnExit() { }
        }

        private class State어흥이Script06 : TriggerState {
            internal State어흥이Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001729, arg3: "$52000041_QD__MAIN__14$", arg4: 1);
                context.SetSkip(arg1: "어흥이Script06스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateNPC이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어흥이Script06스킵 : TriggerState {
            internal State어흥이Script06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateNPC이동04(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC이동04 : TriggerState {
            internal StateNPC이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 3000, arg2: "MS2PatrolData_3000");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 101, arg2: new[] {3000})) {
                    context.DestroyMonster(arg1: new[] {3000});
                    return new StateNPC이동05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동05 : TriggerState {
            internal StateNPC이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: false);
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1000C");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DestroyMonster(arg1: new[] {1000, 2000});
                    context.CreateMonster(arg1: new[] {1010, 2010}, arg2: false);
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "gdreunion");
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