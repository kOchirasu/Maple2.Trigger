using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _03_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 25, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {4023}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {3103}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "FindWay", value: 1)) {
                    context.State = new StateReadyToWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4023}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {904, 905, 906}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_103");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000378_BF__03_FINDWAY__0$", arg4: 2, arg5: 0);
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
                context.SetUserValue(triggerID: 1303, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerID: 2303, key: "RouteSelected", value: 1);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000378_BF__03_FINDWAY__1$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateReadyToWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000378_BF__03_FINDWAY__2$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateRound03_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {101, 201});
            }
        }

        private class StateRound03_Start : TriggerState {
            internal StateRound03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000378_BF__03_FINDWAY__3$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerID: 903, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "03RoundSuccess", value: 1)) {
                    context.State = new StateRound03_Sucess02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound03_Sucess02 : TriggerState {
            internal StateRound03_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2003");
                context.DestroyMonster(arg1: new int[] {1003});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetMesh(arg1: new int[] {3003}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {3003}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5203}, arg2: true);
                context.SetPortal(arg1: 25, arg2: true, arg3: true, arg4: false);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000378_BF__03_FINDWAY__4$", arg4: 2, arg5: 1);
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
                context.DestroyMonster(arg1: new int[] {2003});
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103New");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203New");
                context.SetUserValue(triggerID: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {203});
                context.DestroyMonster(arg1: new int[] {904, 905, 906});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}