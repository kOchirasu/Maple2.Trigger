namespace Maple2.Trigger._52000052_qd {
    public static class _2304_route_04roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {28041, 28042, 28043, 28044}, arg2: true);
                context.SetMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419, 430400, 430401, 430402, 430403, 430404, 430405, 430406, 430407, 430408, 430409, 430410, 430411, 430412, 430413, 430414, 430415, 430416, 430417, 430418, 430419}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {430400, 430401, 430402, 430403, 430404, 430405, 430406, 430407, 430408, 430409, 430410, 430411, 430412, 430413, 430414, 430415, 430416, 430417, 430418, 430419}, arg2: true, arg3: 20, arg4: 0, arg5: 50);
                context.SetAgent(arg1: new[] {28041, 28042, 28043, 28044}, arg2: false);
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
                context.SetMesh(arg1: new[] {230400, 230401, 230402, 230403, 230404, 230405, 230406, 230407, 230408, 230409, 230410, 230411, 230412, 230413, 230414, 230415, 230416, 230417, 230418, 230419}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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