using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _2304_route_04roundback {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "28041", arg2: true);
                context.SetAgent(arg1: "28042", arg2: true);
                context.SetAgent(arg1: "28043", arg2: true);
                context.SetAgent(arg1: "28044", arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        430400, 430401, 430402, 430403, 430404, 430405, 430406, 430407, 430408, 430409, 430410, 430411,
                        430412, 430413, 430414, 430415, 430416, 430417, 430418, 430419
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
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
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
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
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
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        430400, 430401, 430402, 430403, 430404, 430405, 430406, 430407, 430408, 430409, 430410, 430411,
                        430412, 430413, 430414, 430415, 430416, 430417, 430418, 430419
                    }, arg2: true, arg3: 20, arg4: 0, arg5: 50);
                context.SetAgent(arg1: "28041", arg2: false);
                context.SetAgent(arg1: "28042", arg2: false);
                context.SetAgent(arg1: "28043", arg2: false);
                context.SetAgent(arg1: "28044", arg2: false);
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
                        230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411,
                        230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419
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