namespace Maple2.Trigger._02000378_bf {
    public static class _11_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4031, 3011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3011}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3111}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5211}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateReadyToWalkIn_FromPortal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromPortal : TriggerState {
            internal StateReadyToWalkIn_FromPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4031}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1311, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2311, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn_FromPortal02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {111, 2011}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$02000378_BF__11_FINDWAY__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound11_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {111});
            }
        }

        private class StateRound11_Start : TriggerState {
            internal StateRound11_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1011}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1011, arg3: "$02000378_BF__11_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 911, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "11RoundSuccess") == 1) {
                    context.State = new StateRound11_Sucess(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_Sucess : TriggerState {
            internal StateRound11_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2011, arg2: "MS2PatrolData_2011");
                context.DestroyMonster(arg1: new[] {1011});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.SetMesh(arg1: new[] {3011}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3111}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3011}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3111}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5211}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$02000378_BF__11_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRound11_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_RouteSelect : TriggerState {
            internal StateRound11_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2011});
                context.CreateMonster(arg1: new[] {211}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound11_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound11_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_PickRoute_Left : TriggerState {
            internal StateRound11_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1311, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2311, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal19 : TriggerState {
            internal StateGoToPortal19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_19");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_29");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound11_PickRoute_Right : TriggerState {
            internal StateRound11_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1311, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2311, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal10 : TriggerState {
            internal StateGoToPortal10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_10");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_20");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 211});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}