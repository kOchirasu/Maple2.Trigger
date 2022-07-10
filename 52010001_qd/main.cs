namespace Maple2.Trigger._52010001_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000871, 10000910}, state: 1);
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Down_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000871, 10000910}, arg2: 0)) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "Firepotoff");
            }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1001, visible: false, initialSequence: "Down_Idle_A");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1001");
                context.SetConversation(type: 1, spawnId: 101, script: "$52010001_QD__MAIN__0$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{101})) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52010001_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1002");
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52010001_QD__MAIN__2$", arg4: 3, arg5: 0);
                context.SetInteractObject(interactIds: new []{10000871}, state: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 703, spawnIds: new []{101})) {
                    return new StateEvent_04_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_02 : TriggerState {
            internal StateEvent_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1004");
                context.SetConversation(type: 1, spawnId: 101, script: "$52010001_QD__MAIN__3$", arg4: 3, arg5: 0);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52010001_QD__MAIN__4$", arg4: 3, arg5: 3);
                context.SetInteractObject(interactIds: new []{10000910}, state: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1005");
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 704, spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Down_Idle_A");
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
