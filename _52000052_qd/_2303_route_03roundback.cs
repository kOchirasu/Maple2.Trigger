using System;

namespace Maple2.Trigger._52000052_qd {
    public static class _2303_route_03roundback {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "28031", arg2: true);
                context.SetAgent(arg1: "28032", arg2: true);
                context.SetAgent(arg1: "28033", arg2: true);
                context.SetAgent(arg1: "28034", arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        430300, 430301, 430302, 430303, 430304, 430305, 430306, 430307, 430308, 430309, 430310, 430311,
                        430312, 430313, 430314, 430315, 430316, 430317, 430318, 430319
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
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
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
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
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
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        430300, 430301, 430302, 430303, 430304, 430305, 430306, 430307, 430308, 430309, 430310, 430311,
                        430312, 430313, 430314, 430315, 430316, 430317, 430318, 430319
                    }, arg2: true, arg3: 20, arg4: 100, arg5: 50);
                context.SetAgent(arg1: "28031", arg2: false);
                context.SetAgent(arg1: "28032", arg2: false);
                context.SetAgent(arg1: "28033", arg2: false);
                context.SetAgent(arg1: "28034", arg2: false);
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
                        230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311,
                        230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319
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