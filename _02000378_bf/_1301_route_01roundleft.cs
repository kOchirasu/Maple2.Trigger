using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _1301_route_01roundleft {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "18011", arg2: true);
                context.SetAgent(arg1: "18012", arg2: true);
                context.SetAgent(arg1: "18013", arg2: true);
                context.SetAgent(arg1: "18014", arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        330100, 330101, 330102, 330103, 330104, 330105, 330106, 330107, 330108, 330109, 330110, 330111,
                        330112, 330113, 330114, 330115, 330116, 330117, 330118, 330119, 330120, 330121, 330122, 330123
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
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
                    }, arg2: true, arg3: 8, arg4: 100, arg5: 500);
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
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
                    }, arg2: false, arg3: 24, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
                    }, arg2: true, arg3: 8, arg4: 100, arg5: 500);
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
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
                    }, arg2: false, arg3: 24, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        330100, 330101, 330102, 330103, 330104, 330105, 330106, 330107, 330108, 330109, 330110, 330111,
                        330112, 330113, 330114, 330115, 330116, 330117, 330118, 330119, 330120, 330121, 330122, 330123
                    }, arg2: true, arg3: 24, arg4: 100, arg5: 50);
                context.SetAgent(arg1: "18011", arg2: false);
                context.SetAgent(arg1: "18012", arg2: false);
                context.SetAgent(arg1: "18013", arg2: false);
                context.SetAgent(arg1: "18014", arg2: false);
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
                        130100, 130101, 130102, 130103, 130104, 130105, 130106, 130107, 130108, 130109, 130110, 130111,
                        130112, 130113, 130114, 130115, 130116, 130117, 130118, 130119, 130120, 130121, 130122, 130123
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