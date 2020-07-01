namespace Maple2.Trigger._52000052_qd {
    public static class _02_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4022}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5202}, arg2: false);
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
                context.SetMesh(arg1: new[] {4022}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
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
                context.SetUserValue(triggerId: 1302, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2302, key: "RouteSelected", value: 1);
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
                    context.State = new StateRound02_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 201});
            }
        }

        private class StateRound02_Start : TriggerState {
            internal StateRound02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$52000052_QD__02_FINDWAY__3$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 902, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "02RoundSuccess") == 1) {
                    context.State = new StateRound02_Sucess01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_Sucess01 : TriggerState {
            internal StateRound02_Sucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new[] {2202})) {
                    context.State = new StateRound02_Sucess02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_Sucess02 : TriggerState {
            internal StateRound02_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2202, arg2: "MS2PatrolData_2002");
                context.DestroyMonster(arg1: new[] {1002});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3102}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3102}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5202}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000052_QD__02_FINDWAY__4$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound02_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_RouteSelect : TriggerState {
            internal StateRound02_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2202});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound02_PickRoute_Left(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateRound02_PickRoute_Right(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_PickRoute_Left : TriggerState {
            internal StateRound02_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1302, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2302, key: "MakeFalse", value: 1);
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
                context.SetUserValue(triggerId: 4, key: "FindWayLeft", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound02_PickRoute_Right : TriggerState {
            internal StateRound02_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1302, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2302, key: "MakeTrue", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound07 : TriggerState {
            internal StateGoToRound07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7, key: "FindWay", value: 1);
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