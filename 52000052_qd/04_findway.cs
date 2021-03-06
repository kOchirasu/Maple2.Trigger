namespace Maple2.Trigger._52000052_qd {
    public static class _04_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {4024, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5204}, arg2: false);
                context.SetUserValue(key: "FindWayLeft", value: 0);
                context.SetUserValue(key: "FindWayRight", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {4024}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_104L");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_204L");
                context.SetConversation(arg1: 1, arg2: 202, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 1304, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2304, key: "RouteSelected", value: 1);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound04_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {102, 202});
            }
        }

        private class StateReadyToWalkIn_FromRight01 : TriggerState {
            internal StateReadyToWalkIn_FromRight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4024}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104R");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_204R");
                context.SetConversation(arg1: 1, arg2: 203, script: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 1304, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2304, key: "RouteSelected", value: 1);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 103, script: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound04_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103, 203});
            }
        }

        private class StateRound04_Start : TriggerState {
            internal StateRound04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1004, 2004}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1004, script: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 904, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "04RoundSuccess") == 1) {
                    return new StateRound04_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound04_Sucess02 : TriggerState {
            internal StateRound04_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData_2004");
                context.DestroyMonster(arg1: new[] {1004});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.SetMesh(arg1: new[] {3004}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3004}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5204}, arg2: true);
                context.SetPortal(portalId: 21, visible: true, enabled: true, minimapVisible: false);
                context.SetConversation(arg1: 1, arg2: 104, script: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound04_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound04_RouteSelect : TriggerState {
            internal StateRound04_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2004});
                context.CreateMonster(arg1: new[] {204}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104New");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204New");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {204});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound04_PickRoute_Left : TriggerState {
            internal StateRound04_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1304, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2304, key: "MakeFalse", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound05 : TriggerState {
            internal StateGoToRound05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound04_PickRoute_Right : TriggerState {
            internal StateRound04_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1304, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2304, key: "MakeTrue", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound06 : TriggerState {
            internal StateGoToRound06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 6, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}