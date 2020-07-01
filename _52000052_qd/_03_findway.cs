namespace Maple2.Trigger._52000052_qd {
    public static class _03_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4023}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3003}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3103}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5203}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateReadyToWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4023}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_103");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000052_QD__02_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateReadyToWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1303, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2303, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000052_QD__02_FINDWAY__2$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateRound03_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 201});
            }
        }

        private class StateRound03_Start : TriggerState {
            internal StateRound03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000052_QD__02_FINDWAY__3$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 903, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "03RoundSuccess") == 1) {
                    context.State = new StateRound03_Sucess01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound03_Sucess01 : TriggerState {
            internal StateRound03_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new[] {2203})) {
                    context.State = new StateRound03_Sucess02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound03_Sucess02 : TriggerState {
            internal StateRound03_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2203, arg2: "MS2PatrolData_2003");
                context.DestroyMonster(arg1: new[] {1003});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3103}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3103}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5203}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$52000052_QD__02_FINDWAY__4$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound03_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound03_RouteSelect : TriggerState {
            internal StateRound03_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2203});
                context.CreateMonster(arg1: new[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound03_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound03_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound03_PickRoute_Left : TriggerState {
            internal StateRound03_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1303, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2303, key: "MakeFalse", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound04 : TriggerState {
            internal StateGoToRound04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "FindWayRight", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound03_PickRoute_Right : TriggerState {
            internal StateRound03_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1303, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2303, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound08 : TriggerState {
            internal StateGoToRound08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}