namespace Maple2.Trigger._02000378_bf {
    public static class _01_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 44, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 45, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 46, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 47, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 48, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 49, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 51, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4100, 4101, 4102, 4103, 4104, 4105, 4106}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5201, 5000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100, 200}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn01 : TriggerState {
            internal StateReadyToWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_100");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_200");
                context.SetConversation(arg1: 1, arg2: 200, script: "$02000378_BF__01_FINDWAY__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn02 : TriggerState {
            internal StateReadyToWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1301, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2301, key: "RouteSelected", value: 1);
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
                context.SetConversation(arg1: 1, arg2: 200, script: "$02000378_BF__01_FINDWAY__1$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, script: "$02000378_BF__01_FINDWAY__2$", arg4: 2, arg5: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new StateRound01_Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {100, 200});
            }
        }

        private class StateRound01_Start : TriggerState {
            internal StateRound01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 2001}, arg2: false);
                context.SetUserValue(triggerId: 901, key: "MobWaveStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "01RoundSuccess") == 1) {
                    return new StateRound01_Sucess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_Sucess : TriggerState {
            internal StateRound01_Sucess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001");
                context.DestroyMonster(arg1: new[] {1001});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetEffect(arg1: new[] {5201}, arg2: true);
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: true, arg3: 0, arg4: 0);
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000378_BF__01_FINDWAY__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound01_RouteSelect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_RouteSelect : TriggerState {
            internal StateRound01_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PickRoute_Left(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PickRoute_Right(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_04(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_05(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_06(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_07(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_08(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_09(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_10(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRound01_PortalOn_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PickRoute_Left : TriggerState {
            internal StateRound01_PickRoute_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1301, key: "MakeTrue", value: 1);
                context.SetUserValue(triggerId: 2301, key: "MakeFalse", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound02 : TriggerState {
            internal StateGoToRound02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PickRoute_Right : TriggerState {
            internal StateRound01_PickRoute_Right(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1301, key: "MakeFalse", value: 1);
                context.SetUserValue(triggerId: 2301, key: "MakeTrue", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGoToRound03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound03 : TriggerState {
            internal StateGoToRound03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_04 : TriggerState {
            internal StateRound01_PortalOn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 44, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound04 : TriggerState {
            internal StateGoToRound04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 4, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_05 : TriggerState {
            internal StateRound01_PortalOn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 45, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound05 : TriggerState {
            internal StateGoToRound05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 5, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_06 : TriggerState {
            internal StateRound01_PortalOn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 46, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound06 : TriggerState {
            internal StateGoToRound06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 6, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_07 : TriggerState {
            internal StateRound01_PortalOn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 47, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound07 : TriggerState {
            internal StateGoToRound07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 7, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_08 : TriggerState {
            internal StateRound01_PortalOn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 48, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound08 : TriggerState {
            internal StateGoToRound08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 8, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_09 : TriggerState {
            internal StateRound01_PortalOn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 49, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound09 : TriggerState {
            internal StateGoToRound09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 9, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_10 : TriggerState {
            internal StateRound01_PortalOn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 50, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound10 : TriggerState {
            internal StateGoToRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 10, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound01_PortalOn_11 : TriggerState {
            internal StateRound01_PortalOn_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMeshAnimation(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 3);
                context.SetPortal(portalId: 51, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGoToRound11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGoToRound11 : TriggerState {
            internal StateGoToRound11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101New");
                context.SetUserValue(triggerId: 11, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMoveToPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToPortal : TriggerState {
            internal StateMoveToPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201New");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {201});
            }
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