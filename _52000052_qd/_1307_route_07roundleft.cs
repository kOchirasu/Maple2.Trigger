namespace Maple2.Trigger._52000052_qd {
    public static class _1307_route_07roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "18071", arg2: true);
                context.SetAgent(arg1: "18072", arg2: true);
                context.SetAgent(arg1: "18073", arg2: true);
                context.SetAgent(arg1: "18074", arg2: true);
                context.SetEffect(arg1: new[] {5007}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        330700, 330701, 330702, 330703, 330704, 330705, 330706, 330707, 330708, 330709, 330710, 330711,
                        330712, 330713, 330714, 330715, 330716, 330717, 330718, 330719, 330720, 330721
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
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
                if (context.GetUserValue(key: "RouteSelected") == 1) {
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
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
                    }, arg2: true, arg3: 7, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom02(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
                    }, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
                    }, arg2: true, arg3: 7, arg4: 100, arg5: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStartDazzlingRandom01(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    context.State = new StateMakeTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    context.State = new StateMakeFalse(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetRandomMesh(
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
                    }, arg2: false, arg3: 22, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5007}, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new[] {
                        330700, 330701, 330702, 330703, 330704, 330705, 330706, 330707, 330708, 330709, 330710, 330711,
                        330712, 330713, 330714, 330715, 330716, 330717, 330718, 330719, 330720, 330721
                    }, arg2: true, arg3: 22, arg4: 100, arg5: 50);
                context.SetAgent(arg1: "18071", arg2: false);
                context.SetAgent(arg1: "18072", arg2: false);
                context.SetAgent(arg1: "18073", arg2: false);
                context.SetAgent(arg1: "18074", arg2: false);
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
                    arg1: new[] {
                        130700, 130701, 130702, 130703, 130704, 130705, 130706, 130707, 130708, 130709, 130710, 130711,
                        130712, 130713, 130714, 130715, 130716, 130717, 130718, 130719, 130720, 130721
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