using System;

namespace Maple2.Trigger._52000052_qd {
    public static class _2307_route_07roundright {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "28071", arg2: true);
                context.SetAgent(arg1: "28072", arg2: true);
                context.SetAgent(arg1: "28073", arg2: true);
                context.SetAgent(arg1: "28074", arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        430700, 430701, 430702, 430703, 430704, 430705, 430706, 430707, 430708, 430709, 430710, 430711,
                        430712, 430713, 430714, 430715, 430716, 430717, 430718, 430719
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
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
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
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
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
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5007}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        430700, 430701, 430702, 430703, 430704, 430705, 430706, 430707, 430708, 430709, 430710, 430711,
                        430712, 430713, 430714, 430715, 430716, 430717, 430718, 430719
                    }, arg2: true, arg3: 20, arg4: 0, arg5: 50);
                context.SetAgent(arg1: "28071", arg2: false);
                context.SetAgent(arg1: "28072", arg2: false);
                context.SetAgent(arg1: "28073", arg2: false);
                context.SetAgent(arg1: "28074", arg2: false);
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
                        230700, 230701, 230702, 230703, 230704, 230705, 230706, 230707, 230708, 230709, 230710, 230711,
                        230712, 230713, 230714, 230715, 230716, 230717, 230718, 230719
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