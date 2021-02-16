namespace Maple2.Trigger._02000378_bf {
    public static class _02_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 24, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {4022, 3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5202}, arg2: false);
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
                context.SetMesh(arg1: new[] {4022}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
                context.SetConversation(arg1: 1, arg2: 201, script: "$02000378_BF__02_FINDWAY__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 1302, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2302, key: "RouteSelected", value: 1);
                context.SetConversation(arg1: 1, arg2: 201, script: "$02000378_BF__02_FINDWAY__1$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReadyToWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn03 : TriggerState {
            internal StateReadyToWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000378_BF__02_FINDWAY__2$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateRound02_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 201});
            }
        }

        private class StateRound02_Start : TriggerState {
            internal StateRound02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002, 2002}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1002, script: "$02000378_BF__02_FINDWAY__3$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 902, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "02RoundSuccess") == 1) {
                    return new StateRound02_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound02_Sucess02 : TriggerState {
            internal StateRound02_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");
                context.DestroyMonster(arg1: new[] {1002});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5202}, arg2: true);
                context.SetPortal(portalId: 24, visible: true, enabled: true, minimapVisible: false);
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000378_BF__02_FINDWAY__4$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound02_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound02_RouteSelect : TriggerState {
            internal StateRound02_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102New");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202New");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202, 901, 902, 903});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}