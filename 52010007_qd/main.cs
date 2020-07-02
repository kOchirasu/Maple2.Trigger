namespace Maple2.Trigger._52010007_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002834}, arg3: new byte[] {1})) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1002})) {
                    return new State둔바대사01(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {1003})) {
                    return new State둔바대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대사01 : TriggerState {
            internal State둔바대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010007_QD__MAIN__0$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에레브대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브대사01 : TriggerState {
            internal State에레브대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010007_QD__MAIN__1$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNPC이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동2 : TriggerState {
            internal StateNPC이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_B");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_B");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State말풍선대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선대사01 : TriggerState {
            internal State말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52010007_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State말풍선대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선대사02 : TriggerState {
            internal State말풍선대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52010007_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State말풍선대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선대사03 : TriggerState {
            internal State말풍선대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$52010007_QD__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State스타츠대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠대사01 : TriggerState {
            internal State스타츠대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010007_QD__MAIN__5$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State스타츠이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠이동 : TriggerState {
            internal State스타츠이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_C");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State타라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타라이동 : TriggerState {
            internal State타라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_C");
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$52010007_QD__MAIN__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State둔바이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바이동 : TriggerState {
            internal State둔바이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1002});
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_C");
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52010007_QD__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에레브대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브대사02 : TriggerState {
            internal State에레브대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {1003, 1004});
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010007_QD__MAIN__8$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에레브대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브대사03 : TriggerState {
            internal State에레브대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010007_QD__MAIN__9$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetCinematicUI(arg1: 0);
                    context.SetCinematicUI(arg1: 2);
                    context.CameraSelect(arg1: 301, arg2: false);
                    context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "Find_Lamestone");
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