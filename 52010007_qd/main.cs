namespace Maple2.Trigger._52010007_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002834}, questStates: new byte[]{1})) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_A");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_A");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{1002})) {
                    return new State둔바Script01(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{1003})) {
                    return new State둔바Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바Script01 : TriggerState {
            internal State둔바Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010007_QD__MAIN__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에레브Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script01 : TriggerState {
            internal State에레브Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010007_QD__MAIN__1$", arg4: 4);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_B");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_B");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State말풍선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script01 : TriggerState {
            internal State말풍선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1003, script: "$52010007_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State말풍선Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script02 : TriggerState {
            internal State말풍선Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1003, script: "$52010007_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State말풍선Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Script03 : TriggerState {
            internal State말풍선Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1004, script: "$52010007_QD__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State스타츠Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠Script01 : TriggerState {
            internal State스타츠Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010007_QD__MAIN__5$", arg4: 4);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_C");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_C");
                context.SetConversation(type: 1, spawnId: 1004, script: "$52010007_QD__MAIN__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{1002});
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_C");
                context.SetConversation(type: 1, spawnId: 1003, script: "$52010007_QD__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에레브Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script02 : TriggerState {
            internal State에레브Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{1003, 1004});
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010007_QD__MAIN__8$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에레브Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script03 : TriggerState {
            internal State에레브Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010007_QD__MAIN__9$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    context.CameraSelect(triggerId: 301, enable: false);
                    context.SetAchievement(triggerId: 100, type: "trigger", code: "Find_Lamestone");
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
