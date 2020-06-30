using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _2311_route_11roundright {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {4010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "28111", arg2: true);
                context.SetAgent(arg1: "28112", arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        431100, 431101, 431102, 431103, 431104, 431105, 431106, 431107, 431108, 431109, 431110, 431111
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

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
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
                    }, arg2: true, arg3: 4, arg4: 100, arg5: 500);
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
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
                    }, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
                    }, arg2: true, arg3: 4, arg4: 100, arg5: 500);
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
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
                    }, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5011}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        431100, 431101, 431102, 431103, 431104, 431105, 431106, 431107, 431108, 431109, 431110, 431111
                    }, arg2: true, arg3: 12, arg4: 0, arg5: 50);
                context.SetAgent(arg1: "28111", arg2: false);
                context.SetAgent(arg1: "28112", arg2: false);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new int[] {4010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                        231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111
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