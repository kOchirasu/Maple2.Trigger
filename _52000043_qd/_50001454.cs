namespace Maple2.Trigger._52000043_qd {
    public static class _50001454 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606, 607, 608}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateStart조건(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001454}, arg3: new byte[] {3})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003, 2003}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001020, 10001021}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 305, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003D");
                context.MoveUserPath(arg1: "MS2PatrolData_PCD");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new State말퉁선대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말퉁선대사01 : TriggerState {
            internal State말퉁선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000043_QD__50001454__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003E");
                context.MoveUserPath(arg1: "MS2PatrolData_PCE");
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2003D");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 105, arg2: new[] {2003})) {
                    return new State준타대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사01 : TriggerState {
            internal State준타대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__1$", arg4: 4);
                context.SetSkip(arg1: "준타대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사01스킵 : TriggerState {
            internal State준타대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사01(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01 : TriggerState {
            internal State틴차이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001454__2$", arg4: 4);
                context.SetSkip(arg1: "틴차이대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01스킵 : TriggerState {
            internal State틴차이대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사02(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사02 : TriggerState {
            internal State준타대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__3$", arg4: 4);
                context.SetSkip(arg1: "준타대사02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사02스킵 : TriggerState {
            internal State준타대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사03(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사03 : TriggerState {
            internal State준타대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__4$", arg4: 5);
                context.SetSkip(arg1: "준타대사03스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State틴차이대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사03스킵 : TriggerState {
            internal State준타대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사02(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02 : TriggerState {
            internal State틴차이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001454__5$", arg4: 3);
                context.SetSkip(arg1: "틴차이대사02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사02스킵 : TriggerState {
            internal State틴차이대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사04(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사04 : TriggerState {
            internal State준타대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__6$", arg4: 3);
                context.SetSkip(arg1: "준타대사04스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사04스킵 : TriggerState {
            internal State준타대사04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사05(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사05 : TriggerState {
            internal State준타대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__7$", arg4: 5);
                context.SetSkip(arg1: "준타대사05스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사05스킵 : TriggerState {
            internal State준타대사05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사06(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사06 : TriggerState {
            internal State준타대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__8$", arg4: 5);
                context.SetSkip(arg1: "준타대사06스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타대사07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사06스킵 : TriggerState {
            internal State준타대사06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사07(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사07 : TriggerState {
            internal State준타대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__9$", arg4: 6);
                context.SetSkip(arg1: "준타대사07스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State준타대사08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사07스킵 : TriggerState {
            internal State준타대사07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사08(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사08 : TriggerState {
            internal State준타대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__10$", arg4: 3);
                context.SetSkip(arg1: "준타대사08스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State틴차이대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사08스킵 : TriggerState {
            internal State준타대사08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사03(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사03 : TriggerState {
            internal State틴차이대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001454__26$", arg4: 2);
                context.SetSkip(arg1: "틴차이대사03스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타대사09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사03스킵 : TriggerState {
            internal State틴차이대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사09(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사09 : TriggerState {
            internal State준타대사09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__11$", arg4: 4);
                context.SetSkip(arg1: "준타대사09스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타대사10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사09스킵 : TriggerState {
            internal State준타대사09스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사10(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사10 : TriggerState {
            internal State준타대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__12$", arg4: 4);
                context.SetSkip(arg1: "준타대사10스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타대사11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사10스킵 : TriggerState {
            internal State준타대사10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사11(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사11 : TriggerState {
            internal State준타대사11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__13$", arg4: 4);
                context.SetSkip(arg1: "준타대사11스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사11스킵 : TriggerState {
            internal State준타대사11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사04(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사04 : TriggerState {
            internal State틴차이대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001454__14$", arg4: 2);
                context.SetSkip(arg1: "틴차이대사04스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타대사12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사04스킵 : TriggerState {
            internal State틴차이대사04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사12(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사12 : TriggerState {
            internal State준타대사12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__15$", arg4: 4);
                context.SetSkip(arg1: "준타대사12스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타대사13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사12스킵 : TriggerState {
            internal State준타대사12스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사13(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사13 : TriggerState {
            internal State준타대사13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__16$", arg4: 4);
                context.SetSkip(arg1: "준타대사13스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사13스킵 : TriggerState {
            internal State준타대사13스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {608}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePC이동(context);
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PCG");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    return new State준타대사14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사14 : TriggerState {
            internal State준타대사14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__17$", arg4: 4);
                context.SetSkip(arg1: "준타대사14스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사14스킵 : TriggerState {
            internal State준타대사14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사05(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사05 : TriggerState {
            internal State틴차이대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001454__18$", arg4: 2);
                context.SetSkip(arg1: "틴차이대사05스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타대사15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사05스킵 : TriggerState {
            internal State틴차이대사05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사15(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사15 : TriggerState {
            internal State준타대사15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__19$", arg4: 6);
                context.SetSkip(arg1: "준타대사15스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State준타대사16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사15스킵 : TriggerState {
            internal State준타대사15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사16(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사16 : TriggerState {
            internal State준타대사16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__20$", arg4: 3);
                context.SetSkip(arg1: "준타대사16스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타대사17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사16스킵 : TriggerState {
            internal State준타대사16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사17(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사17 : TriggerState {
            internal State준타대사17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__21$", arg4: 4);
                context.SetSkip(arg1: "준타대사17스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사17스킵 : TriggerState {
            internal State준타대사17스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이대사06(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이대사06 : TriggerState {
            internal State틴차이대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001454__22$", arg4: 3);
                context.SetSkip(arg1: "틴차이대사06스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타대사18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이대사06스킵 : TriggerState {
            internal State틴차이대사06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사18(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사18 : TriggerState {
            internal State준타대사18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__23$", arg4: 5);
                context.SetSkip(arg1: "준타대사18스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타대사19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사18스킵 : TriggerState {
            internal State준타대사18스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사19(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사19 : TriggerState {
            internal State준타대사19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__24$", arg4: 6);
                context.SetSkip(arg1: "준타대사19스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State준타대사20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사19스킵 : TriggerState {
            internal State준타대사19스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타대사20(context);
            }

            public override void OnExit() { }
        }

        private class State준타대사20 : TriggerState {
            internal State준타대사20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001454__25$", arg4: 3);
                context.SetSkip(arg1: "준타대사20스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타대사20스킵 : TriggerState {
            internal State준타대사20스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateStopCinematic(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "gdfight");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUser(arg1: 02000039, arg2: 10);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
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