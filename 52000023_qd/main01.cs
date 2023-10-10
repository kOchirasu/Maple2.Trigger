namespace Maple2.Trigger._52000023_qd {
    public static class _main01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, visible: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, visible: false);
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000617, 10000618, 10000619}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{20002230}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, visible: true);
                context.CreateMonster(spawnIds: new []{101, 901, 902, 903, 904, 905, 906, 907, 908, 909, 910}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유저이동01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State유저이동01 : TriggerState {
            internal State유저이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_100");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State유저이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동03 : TriggerState {
            internal State유저이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{601, 602}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__0$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State전투Prepare02(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6001}, visible: false);
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__1$", arg4: 4, arg5: 0);
                context.SetSkip(state: new StateBattleStart(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 603, enabled: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new State대화Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화Prepare01 : TriggerState {
            internal State대화Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_200");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State대화Prepare03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화Prepare03 : TriggerState {
            internal State대화Prepare03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__2$", arg4: 8, arg5: 0);
                context.SetSkip(state: new StateIshura대화02(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6003}, visible: false);
                context.SetEffect(triggerIds: new []{6004}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__3$", arg4: 8, arg5: 0);
                context.SetSkip(state: new StateIshura대화03(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6004}, visible: false);
                context.SetEffect(triggerIds: new []{6005}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__4$", arg4: 7, arg5: 0);
                context.SetSkip(state: new StateIshura대화04(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6005}, visible: false);
                context.SetEffect(triggerIds: new []{6006}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__5$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State수색Prepare(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State수색Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State수색Prepare : TriggerState {
            internal State수색Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6006}, visible: false);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000617, 10000618, 10000619}, state: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 25200231, textId: 25200231);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000617}, arg2: 0)) {
                    return new State수색종료01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State수색종료01 : TriggerState {
            internal State수색종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000618, 10000619}, state: 0);
                context.HideGuideSummary(entityId: 25200231);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_104");
                context.SetEffect(triggerIds: new []{6007}, visible: true);
                context.SetConversation(type: 1, spawnId: 103, script: "$52000023_QD__MAIN01__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_102");
                context.CameraSelect(triggerId: 604, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9003, spawnIds: new []{103})) {
                    return new State정리Prepare02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리Prepare02 : TriggerState {
            internal State정리Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6007}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6008}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__7$", arg4: 9, arg5: 0);
                context.SetSkip(state: new State정리대화02(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6008}, visible: false);
                context.SetEffect(triggerIds: new []{6009}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000023_QD__MAIN01__8$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State퇴장Prepare(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 604, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "MeetAgain_Ishura");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_103");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{103})) {
                    return new State퇴장완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{103});
            }
        }

        private class State퇴장완료 : TriggerState {
            internal State퇴장완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6009}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
