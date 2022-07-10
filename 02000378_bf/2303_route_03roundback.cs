namespace Maple2.Trigger._02000378_bf {
    public static class _2303_route_03roundback {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{28031, 28032, 28033, 28034}, visible: true);
                context.SetMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319, 430300, 430301, 430302, 430303, 430304, 430305, 430306, 430307, 430308, 430309, 430310, 430311, 430312, 430313, 430314, 430315, 430316, 430317, 430318, 430319}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, visible: true, meshCount: 6, arg4: 100, delay: 500);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, visible: true, meshCount: 6, arg4: 100, delay: 500);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{430300, 430301, 430302, 430303, 430304, 430305, 430306, 430307, 430308, 430309, 430310, 430311, 430312, 430313, 430314, 430315, 430316, 430317, 430318, 430319}, visible: true, meshCount: 20, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{28031, 28032, 28033, 28034}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{230300, 230301, 230302, 230303, 230304, 230305, 230306, 230307, 230308, 230309, 230310, 230311, 230312, 230313, 230314, 230315, 230316, 230317, 230318, 230319}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
