namespace Maple2.Trigger._52000052_qd {
    public static class _05_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4025, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3105}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3105}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5205}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {4025}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_105");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_205");
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$52000052_QD__04_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1305, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2305, key: "RouteSelected", value: 1);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000052_QD__04_FINDWAY__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound05_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {104, 204});
            }
        }

        private class StateRound05_Start : TriggerState {
            internal StateRound05_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1005, 2005}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1005, arg3: "$52000052_QD__04_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 905, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "05RoundSuccess") == 1) {
                    return new StateRound05_Sucess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound05_Sucess : TriggerState {
            internal StateRound05_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData_2005");
                context.DestroyMonster(arg1: new[] {1005});
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.SetMesh(arg1: new[] {3005}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3105}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3005}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3105}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5205}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$52000052_QD__04_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound05_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound05_RouteSelect : TriggerState {
            internal StateRound05_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2005});
                context.CreateMonster(arg1: new[] {205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    return new StateRound05_PickRoute_Left(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateRound05_PickRoute_Right(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound05_PickRoute_Left : TriggerState {
            internal StateRound05_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1305, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2305, key: "MakeFalse", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal11 : TriggerState {
            internal StateGoToPortal11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_11");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_21");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound05_PickRoute_Right : TriggerState {
            internal StateRound05_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1305, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2305, key: "MakeTrue", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToPortal12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal12 : TriggerState {
            internal StateGoToPortal12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_12");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_22");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {105, 205});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}