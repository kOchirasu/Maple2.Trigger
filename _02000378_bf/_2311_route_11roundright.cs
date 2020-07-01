namespace Maple2.Trigger._02000378_bf {
    public static class _2311_route_11roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {28111, 28112}, arg2: true);
                context.SetMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111, 431100, 431101, 431102, 431103, 431104, 431105, 431106, 431107, 431108, 431109, 431110, 431111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RouteSelected") == 1) {
                    return new StateStartDazzlingRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, arg2: true, arg3: 4, arg4: 100, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom02(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, arg2: true, arg3: 4, arg4: 100, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom01(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, arg2: false, arg3: 12, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5011}, arg2: true);
                context.SetMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {431100, 431101, 431102, 431103, 431104, 431105, 431106, 431107, 431108, 431109, 431110, 431111}, arg2: true, arg3: 12, arg4: 0, arg5: 50);
                context.SetAgent(arg1: new[] {28111, 28112}, arg2: false);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.SetMesh(arg1: new[] {4010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
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