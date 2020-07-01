namespace Maple2.Trigger._52000052_qd {
    public static class _1306_route_06roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4013}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {18061, 18062}, arg2: true);
                context.SetEffect(arg1: new[] {5006}, arg2: false);
                context.SetMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625, 330600, 330601, 330602, 330603, 330604, 330605, 330606, 330607, 330608, 330609, 330610, 330611, 330612, 330613, 330614, 330615, 330616, 330617, 330618, 330619, 330620, 330621, 330622, 330623, 330624, 330625}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, arg2: false, arg3: 26, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, arg2: true, arg3: 7, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, arg2: false, arg3: 26, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5006}, arg2: true);
                context.SetMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {330600, 330601, 330602, 330603, 330604, 330605, 330606, 330607, 330608, 330609, 330610, 330611, 330612, 330613, 330614, 330615, 330616, 330617, 330618, 330619, 330620, 330621, 330622, 330623, 330624, 330625}, arg2: true, arg3: 26, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {18061, 18062}, arg2: false);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new[] {4013}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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