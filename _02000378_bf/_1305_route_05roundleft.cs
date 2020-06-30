using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _1305_route_05roundleft {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {4011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "18051", arg2: true);
                context.SetAgent(arg1: "18052", arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        330500, 330501, 330502, 330503, 330504, 330505, 330506, 330507, 330508, 330509, 330510, 330511,
                        330512, 330513, 330514, 330515, 330516, 330517, 330518, 330519
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9000, arg2: 1)) {
                    context.State = new StateStartDazzling01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDazzling01 : TriggerState {
            internal StateStartDazzling01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "RouteSelected", value: 1)) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: true, arg3: 6, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom02(context);
                    return;
                }

                if (context.UserValue(key: "MakeTrue", value: 1)) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.UserValue(key: "MakeFalse", value: 1)) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: true, arg3: 6, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }

                if (context.UserValue(key: "MakeTrue", value: 1)) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.UserValue(key: "MakeFalse", value: 1)) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        330500, 330501, 330502, 330503, 330504, 330505, 330506, 330507, 330508, 330509, 330510, 330511,
                        330512, 330513, 330514, 330515, 330516, 330517, 330518, 330519
                    }, arg2: true, arg3: 20, arg4: 100, arg5: 50);
                context.SetAgent(arg1: "18051", arg2: false);
                context.SetAgent(arg1: "18052", arg2: false);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new int[] {4011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511,
                        130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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