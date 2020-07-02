namespace Maple2.Trigger._52000048_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210}, arg2: false);
                context.CreateMonster(arg1: new[] {2001});
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {600, 601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1102, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1103, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1104, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1105, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1106, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1107, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1108, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1109, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1110, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1010, arg2: "MS2PatrolData_B");
                context.MoveNpc(arg1: 1201, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1202, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1203, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1204, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1205, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1206, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1207, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1208, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1209, arg2: "MS2PatrolData_C");
                context.MoveNpc(arg1: 1210, arg2: "MS2PatrolData_C");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State칸두라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라이동 : TriggerState {
            internal State칸두라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_K1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.SetNpcEmotionSequence(arg1: 2001, arg2: "Attack_01_A");
                    return new State칸두라이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라이동2 : TriggerState {
            internal State칸두라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_K2");
                    return new StateCamera이동대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동대기 : TriggerState {
            internal StateCamera이동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCamera이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동2 : TriggerState {
            internal StateCamera이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State라오즈Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈Appear : TriggerState {
            internal State라오즈Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CreateMonster(arg1: new[] {2002});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePC말풍선(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선 : TriggerState {
            internal StatePC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000048_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State라오즈대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈대사01 : TriggerState {
            internal State라오즈대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001768, arg3: "$52000048_QD__MAIN__1$", arg4: 3);
                context.SetSkip(arg1: "라오즈대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라오즈대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈대사01스킵 : TriggerState {
            internal State라오즈대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State라오즈대사02(context);
            }

            public override void OnExit() { }
        }

        private class State라오즈대사02 : TriggerState {
            internal State라오즈대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001768, arg3: "$52000048_QD__MAIN__2$", arg4: 6);
                context.SetSkip(arg1: "라오즈대사02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State라오즈대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈대사02스킵 : TriggerState {
            internal State라오즈대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State라오즈대사03(context);
            }

            public override void OnExit() { }
        }

        private class State라오즈대사03 : TriggerState {
            internal State라오즈대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001768, arg3: "$52000048_QD__MAIN__3$", arg4: 6);
                context.SetSkip(arg1: "라오즈대사03스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuest완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈대사03스킵 : TriggerState {
            internal State라오즈대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateQuest완료(context);
            }

            public override void OnExit() { }
        }

        private class StateQuest완료 : TriggerState {
            internal StateQuest완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "MessageThroughAnimar");
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
                context.CameraSelect(arg1: 304, arg2: false);
                context.MoveUser(arg1: 52000050, arg2: 1);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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