namespace Maple2.Trigger._52000023_qd {
    public static class _main01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000617, 10000618, 10000619}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {20002230}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, arg2: true);
                context.CreateMonster(arg1: new[] {101, 901, 902, 903, 904, 905, 906, 907, 908, 909, 910}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유저이동01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State유저이동01 : TriggerState {
            internal State유저이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동02 : TriggerState {
            internal State유저이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_100");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State유저이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동03 : TriggerState {
            internal State유저이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare01 : TriggerState {
            internal State전투Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__0$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State전투Prepare02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State전투Prepare02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State전투Prepare02 : TriggerState {
            internal State전투Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__1$", arg4: 4, arg5: 0);
                context.SetSkip(state: new StateBattleStart(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new State대화Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화Prepare01 : TriggerState {
            internal State대화Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대화Prepare02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화Prepare02 : TriggerState {
            internal State대화Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_200");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State대화Prepare03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화Prepare03 : TriggerState {
            internal State대화Prepare03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateIshura대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화01 : TriggerState {
            internal StateIshura대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__2$", arg4: 8, arg5: 0);
                context.SetSkip(state: new StateIshura대화02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateIshura대화02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateIshura대화02 : TriggerState {
            internal StateIshura대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: false);
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__3$", arg4: 8, arg5: 0);
                context.SetSkip(state: new StateIshura대화03(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateIshura대화03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateIshura대화03 : TriggerState {
            internal StateIshura대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6004}, arg2: false);
                context.SetEffect(arg1: new[] {6005}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__4$", arg4: 7, arg5: 0);
                context.SetSkip(state: new StateIshura대화04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateIshura대화04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateIshura대화04 : TriggerState {
            internal StateIshura대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6005}, arg2: false);
                context.SetEffect(arg1: new[] {6006}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__5$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State수색Prepare(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State수색Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State수색Prepare : TriggerState {
            internal State수색Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6006}, arg2: false);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000617, 10000618, 10000619}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State수색시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수색시작 : TriggerState {
            internal State수색시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 25200231, textId: 25200231);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000617}, arg2: 0)) {
                    return new State수색종료01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State수색종료01 : TriggerState {
            internal State수색종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000618, 10000619}, arg2: 0);
                context.HideGuideSummary(entityId: 25200231);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State수색종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수색종료02 : TriggerState {
            internal State수색종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104");
                context.SetEffect(arg1: new[] {6007}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$52000023_QD__MAIN01__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State정리Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리Prepare01 : TriggerState {
            internal State정리Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_102");
                context.CameraSelect(arg1: 604, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new[] {103})) {
                    return new State정리Prepare02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리Prepare02 : TriggerState {
            internal State정리Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State정리대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리대화01 : TriggerState {
            internal State정리대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6008}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__7$", arg4: 9, arg5: 0);
                context.SetSkip(state: new State정리대화02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State정리대화02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State정리대화02 : TriggerState {
            internal State정리대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6008}, arg2: false);
                context.SetEffect(arg1: new[] {6009}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__8$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State퇴장Prepare(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State퇴장Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State퇴장Prepare : TriggerState {
            internal State퇴장Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 604, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State퇴장중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장중 : TriggerState {
            internal State퇴장중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "MeetAgain_Ishura");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {103})) {
                    return new State퇴장완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103});
            }
        }

        private class State퇴장완료 : TriggerState {
            internal State퇴장완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6009}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}