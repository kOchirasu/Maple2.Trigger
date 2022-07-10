namespace Maple2.Trigger._52000038_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20020010);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002632}, questStates: new byte[]{3})) {
                    context.SetActor(triggerId: 3001, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3002, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3003, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3004, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3005, visible: false, initialSequence: "Dead_A");
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002632}, questStates: new byte[]{2})) {
                    context.SetActor(triggerId: 3001, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3002, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3003, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3004, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3005, visible: false, initialSequence: "Dead_A");
                    context.CreateMonster(spawnIds: new []{131, 132}, arg2: true);
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002631}, questStates: new byte[]{3})) {
                    context.SetActor(triggerId: 3001, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3002, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3003, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3004, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3005, visible: false, initialSequence: "Dead_A");
                    context.CreateMonster(spawnIds: new []{131, 132}, arg2: true);
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002631}, questStates: new byte[]{2})) {
                    context.SetActor(triggerId: 3001, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3002, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3003, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3004, visible: false, initialSequence: "Dead_A");
                    context.SetActor(triggerId: 3005, visible: false, initialSequence: "Dead_A");
                    context.CreateMonster(spawnIds: new []{131, 132}, arg2: true);
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002631}, questStates: new byte[]{1})) {
                    context.CreateMonster(spawnIds: new []{121, 122}, arg2: true);
                    return new StateScene_b_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002630}, questStates: new byte[]{3})) {
                    return new StateScene_b_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002630}, questStates: new byte[]{2})) {
                    return new StateScene_b_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002630}, questStates: new byte[]{1})) {
                    return new StateReady_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002630}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000038_QD__MAIN__0$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000038_QD__MAIN__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2003");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000038_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2004");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000038_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_05_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05_b : TriggerState {
            internal StateStart_05_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3001, visible: false, initialSequence: "Dead_A");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2005");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000038_QD__MAIN__4$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2006");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000038_QD__MAIN__5$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202, 203, 204, 205}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3002, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 3003, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 3004, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 3005, visible: false, initialSequence: "Dead_A");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2007");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000038_QD__MAIN__6$", arg4: 2, arg5: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2008");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000038_QD__MAIN__7$", arg4: 2, arg5: 4);
                context.ShowGuideSummary(entityId: 40010, textId: 40010);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205})) {
                    context.DestroyMonster(spawnIds: new []{101, 102});
                    context.HideGuideSummary(entityId: 40010);
                    return new StateScene_b_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_01 : TriggerState {
            internal StateScene_b_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "beyondroid1");
                context.CreateMonster(spawnIds: new []{111, 112}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002631}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{111, 112});
                    context.CreateMonster(spawnIds: new []{121, 122}, arg2: true);
                    return new StateScene_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_02 : TriggerState {
            internal StateScene_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2009");
                context.SetConversation(type: 1, spawnId: 121, script: "$52000038_QD__MAIN__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateScene_b_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_03 : TriggerState {
            internal StateScene_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2010");
                context.SetConversation(type: 1, spawnId: 122, script: "$52000038_QD__MAIN__9$", arg4: 2, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateScene_b_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_04 : TriggerState {
            internal StateScene_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
                context.ShowGuideSummary(entityId: 20020010, textId: 20020010);
                context.SetConversation(type: 1, spawnId: 121, script: "$52000038_QD__MAIN__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002631}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{121, 122});
                    context.CreateMonster(spawnIds: new []{131, 132}, arg2: true);
                    context.HideGuideSummary(entityId: 20020010);
                    return new StateScene_c_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_c_01 : TriggerState {
            internal StateScene_c_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
