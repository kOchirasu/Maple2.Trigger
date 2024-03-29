namespace Maple2.Trigger._52000052_qd {
    public static class _03_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4023, 3003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3103}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3003}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3103}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5203}, visible: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    return new StateReadyToWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4023}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_103");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_203");
                context.SetConversation(type: 1, spawnId: 201, script: "$52000052_QD__02_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1303, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2303, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52000052_QD__02_FINDWAY__2$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateRound03_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101, 201});
            }
        }

        private class StateRound03_Start : TriggerState {
            internal StateRound03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1003, 2003}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1003, script: "$52000052_QD__02_FINDWAY__3$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 903, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "03RoundSuccess") == 1) {
                    return new StateRound03_Sucess01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound03_Sucess01 : TriggerState {
            internal StateRound03_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9003, spawnIds: new []{2203})) {
                    return new StateRound03_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound03_Sucess02 : TriggerState {
            internal StateRound03_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2203, patrolName: "MS2PatrolData_2003");
                context.DestroyMonster(spawnIds: new []{1003});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.SetMesh(triggerIds: new []{3003}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3103}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3003}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3103}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5203}, visible: true);
                context.SetConversation(type: 1, spawnId: 103, script: "$52000052_QD__02_FINDWAY__4$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound03_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound03_RouteSelect : TriggerState {
            internal StateRound03_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2203});
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateRound03_PickRoute_Left(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateRound03_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound03_PickRoute_Left : TriggerState {
            internal StateRound03_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1303, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2303, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound04 : TriggerState {
            internal StateGoToRound04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "FindWayRight", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound03_PickRoute_Right : TriggerState {
            internal StateRound03_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1303, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2303, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound08 : TriggerState {
            internal StateGoToRound08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
