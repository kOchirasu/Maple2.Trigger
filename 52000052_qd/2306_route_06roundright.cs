namespace Maple2.Trigger._52000052_qd {
    public static class _2306_route_06roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4014}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{28061, 28062}, visible: true);
                context.SetMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619, 430600, 430601, 430602, 430603, 430604, 430605, 430606, 430607, 430608, 430609, 430610, 430611, 430612, 430613, 430614, 430615, 430616, 430617, 430618, 430619}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619}, visible: true, meshCount: 6, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619}, visible: true, meshCount: 6, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5006}, visible: true);
                context.SetMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{430600, 430601, 430602, 430603, 430604, 430605, 430606, 430607, 430608, 430609, 430610, 430611, 430612, 430613, 430614, 430615, 430616, 430617, 430618, 430619}, visible: true, meshCount: 20, arg4: 0, delay: 50);
                context.SetAgent(triggerIds: new []{28061, 28062}, visible: false);
                context.SetPortal(portalId: 14, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4014}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{230600, 230601, 230602, 230603, 230604, 230605, 230606, 230607, 230608, 230609, 230610, 230611, 230612, 230613, 230614, 230615, 230616, 230617, 230618, 230619}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
