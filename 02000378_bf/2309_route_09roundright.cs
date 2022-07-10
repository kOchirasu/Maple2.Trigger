namespace Maple2.Trigger._02000378_bf {
    public static class _2309_route_09roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 16, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4016}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{28091, 28092}, visible: true);
                context.SetMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909, 430900, 430901, 430902, 430903, 430904, 430905, 430906, 430907, 430908, 430909}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909}, visible: true, meshCount: 3, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909}, visible: false, meshCount: 10, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909}, visible: true, meshCount: 3, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909}, visible: false, meshCount: 10, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5009}, visible: true);
                context.SetMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{430900, 430901, 430902, 430903, 430904, 430905, 430906, 430907, 430908, 430909}, visible: true, meshCount: 10, arg4: 0, delay: 50);
                context.SetAgent(triggerIds: new []{28091, 28092}, visible: false);
                context.SetPortal(portalId: 16, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4016}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{230900, 230901, 230902, 230903, 230904, 230905, 230906, 230907, 230908, 230909}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
