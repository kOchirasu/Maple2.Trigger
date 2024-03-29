namespace Maple2.Trigger._52000052_qd {
    public static class _10_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4030, 3010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3110}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3010}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3110}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5210}, visible: false);
                context.SetUserValue(key: "FindWayLeft", value: 0);
                context.SetUserValue(key: "FindWayRight", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FindWayLeft") == 1) {
                    return new StateReadyToWalkIn_FromLeft01(context);
                }

                if (context.GetUserValue(key: "FindWayRight") == 1) {
                    return new StateReadyToWalkIn_FromRight01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromLeft01 : TriggerState {
            internal StateReadyToWalkIn_FromLeft01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_110L");
                context.MoveNpc(spawnId: 207, patrolName: "MS2PatrolData_210L");
                context.SetConversation(type: 1, spawnId: 207, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn_FromLeft02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromLeft02 : TriggerState {
            internal StateReadyToWalkIn_FromLeft02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2310, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn_FromLeft03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromLeft03 : TriggerState {
            internal StateReadyToWalkIn_FromLeft03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 107, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound10_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{107, 207});
            }
        }

        private class StateReadyToWalkIn_FromRight01 : TriggerState {
            internal StateReadyToWalkIn_FromRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 108, patrolName: "MS2PatrolData_110R");
                context.MoveNpc(spawnId: 208, patrolName: "MS2PatrolData_210R");
                context.SetConversation(type: 1, spawnId: 208, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn_FromRight02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromRight02 : TriggerState {
            internal StateReadyToWalkIn_FromRight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2310, key: "RouteSelected", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn_FromRight03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromRight03 : TriggerState {
            internal StateReadyToWalkIn_FromRight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 108, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound10_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{108, 208});
            }
        }

        private class StateRound10_Start : TriggerState {
            internal StateRound10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1010, 2010}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1010, script: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 910, key: "MobWaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "10RoundSuccess") == 1) {
                    return new StateRound10_Sucess01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_Sucess01 : TriggerState {
            internal StateRound10_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2010, patrolName: "MS2PatrolData_2010");
                context.DestroyMonster(spawnIds: new []{1010});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
                context.SetMesh(triggerIds: new []{3010}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3110}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{3010}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3110}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5210}, visible: true);
                context.SetConversation(type: 1, spawnId: 110, script: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound10_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_RouteSelect : TriggerState {
            internal StateRound10_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2010});
                context.CreateMonster(spawnIds: new []{210}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateRound10_PickRoute_Left(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateRound10_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Left : TriggerState {
            internal StateRound10_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2310, key: "MakeFalse", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal17 : TriggerState {
            internal StateGoToPortal17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_17");
                context.MoveNpc(spawnId: 210, patrolName: "MS2PatrolData_27");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Right : TriggerState {
            internal StateRound10_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2310, key: "MakeTrue", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal18 : TriggerState {
            internal StateGoToPortal18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_18");
                context.MoveNpc(spawnId: 210, patrolName: "MS2PatrolData_28");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{110, 210});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
