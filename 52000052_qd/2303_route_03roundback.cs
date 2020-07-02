namespace Maple2.Trigger._52000052_qd {
    public static class _2303_route_03roundback {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {28031, 28032, 28033, 28034}, arg2: true);
                context.SetMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319, 430300, 430301, 430302, 430303, 430304, 430305, 430306, 430307, 430308, 430309, 430310, 430311, 430312, 430313, 430314, 430315, 430316, 430317, 430318, 430319}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, arg2: true, arg3: 6, arg4: 100, arg5: 500);
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
                context.SetRandomMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, arg2: false, arg3: 20, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {430300, 430301, 430302, 430303, 430304, 430305, 430306, 430307, 430308, 430309, 430310, 430311, 430312, 430313, 430314, 430315, 430316, 430317, 430318, 430319}, arg2: true, arg3: 20, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {28031, 28032, 28033, 28034}, arg2: false);
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
                context.SetMesh(arg1: new[] {230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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