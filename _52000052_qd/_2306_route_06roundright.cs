namespace Maple2.Trigger._52000052_qd {
    public static class _2306_route_06roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4014}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "28061", arg2: true);
                context.SetAgent(arg1: "28062", arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        430600, 430601, 430602, 430603, 430604, 430605, 430606, 430607, 430608, 430609, 430610, 430611,
                        430612, 430613, 430614, 430615, 430616, 430617, 430618, 430619
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

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
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
                    }, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new[] {
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
                    }, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
                    }, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5006}, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(
                    arg1: new[] {
                        430600, 430601, 430602, 430603, 430604, 430605, 430606, 430607, 430608, 430609, 430610, 430611,
                        430612, 430613, 430614, 430615, 430616, 430617, 430618, 430619
                    }, arg2: true, arg3: 20, arg4: 0, arg5: 50);
                context.SetAgent(arg1: "28061", arg2: false);
                context.SetAgent(arg1: "28062", arg2: false);
                context.SetPortal(arg1: 14, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new[] {4014}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                        230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611,
                        230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619
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