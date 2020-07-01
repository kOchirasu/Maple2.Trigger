namespace Maple2.Trigger._02000378_bf {
    public static class _08_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 23, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4028, 3008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3008}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3108}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5208}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    return new StateReadyToWalkIn_FromPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromPortal : TriggerState {
            internal StateReadyToWalkIn_FromPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4028}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1308, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2308, key: "RouteSelected", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn_FromPortal02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {108, 2008}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$02000378_BF__08_FINDWAY__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound08_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {108});
            }
        }

        private class StateRound08_Start : TriggerState {
            internal StateRound08_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1008, arg3: "$02000378_BF__08_FINDWAY__2$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 908, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "08RoundSuccess") == 1) {
                    return new StateRound08_Sucess02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound08_Sucess02 : TriggerState {
            internal StateRound08_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2008, arg2: "MS2PatrolData_2008");
                context.DestroyMonster(arg1: new[] {1008});
                context.CreateMonster(arg1: new[] {108}, arg2: false);
                context.SetMesh(arg1: new[] {3008}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3008}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5208}, arg2: true);
                context.SetPortal(arg1: 23, arg2: true, arg3: true, arg4: false);
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$02000378_BF__08_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound08_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound08_RouteSelect : TriggerState {
            internal StateRound08_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2008});
                context.CreateMonster(arg1: new[] {208}, arg2: false);
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_108New");
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
                context.DestroyMonster(arg1: new[] {108});
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_208New");
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
                context.DestroyMonster(arg1: new[] {208});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}