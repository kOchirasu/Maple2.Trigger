namespace Maple2.Trigger._02000378_bf {
    public static class _10_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4030, 3010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3110}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3010}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3110}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5210}, arg2: false);
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
                context.SetMesh(arg1: new[] {4030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1310, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2310, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn_FromPortal02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {110, 2010}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000378_BF__10_FINDWAY__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound10_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {110});
            }
        }

        private class StateRound10_Start : TriggerState {
            internal StateRound10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1010}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1010, arg3: "$02000378_BF__10_FINDWAY__4$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 910, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "10RoundSuccess") == 1) {
                    context.State = new StateRound10_Sucess01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_Sucess01 : TriggerState {
            internal StateRound10_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2010, arg2: "MS2PatrolData_2010");
                context.DestroyMonster(arg1: new[] {1010});
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.SetMesh(arg1: new[] {3010}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3110}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3010}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3110}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5210}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000378_BF__10_FINDWAY__5$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound10_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_RouteSelect : TriggerState {
            internal StateRound10_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2010});
                context.CreateMonster(arg1: new[] {210}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound10_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound10_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound10_PickRoute_Left : TriggerState {
            internal StateRound10_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2310, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal17 : TriggerState {
            internal StateGoToPortal17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_17");
                context.MoveNpc(arg1: 210, arg2: "MS2PatrolData_27");
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

        private class StateRound10_PickRoute_Right : TriggerState {
            internal StateRound10_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1310, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2310, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToPortal18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToPortal18 : TriggerState {
            internal StateGoToPortal18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_18");
                context.MoveNpc(arg1: 210, arg2: "MS2PatrolData_28");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
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
                context.DestroyMonster(arg1: new[] {110, 210});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}