namespace Maple2.Trigger._52000052_qd {
    public static class _2311_route_11roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{28111, 28112}, visible: true);
                context.SetMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111, 431100, 431101, 431102, 431103, 431104, 431105, 431106, 431107, 431108, 431109, 431110, 431111}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, visible: true, meshCount: 4, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, visible: false, meshCount: 12, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, visible: true, meshCount: 4, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, visible: false, meshCount: 12, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5011}, visible: true);
                context.SetMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{431100, 431101, 431102, 431103, 431104, 431105, 431106, 431107, 431108, 431109, 431110, 431111}, visible: true, meshCount: 12, arg4: 0, delay: 50);
                context.SetAgent(triggerIds: new []{28111, 28112}, visible: false);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{231100, 231101, 231102, 231103, 231104, 231105, 231106, 231107, 231108, 231109, 231110, 231111}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
