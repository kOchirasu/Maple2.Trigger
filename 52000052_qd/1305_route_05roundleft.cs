namespace Maple2.Trigger._52000052_qd {
    public static class _1305_route_05roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4011}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{18051, 18052}, visible: true);
                context.SetEffect(triggerIds: new []{5005}, visible: false);
                context.SetMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519, 330500, 330501, 330502, 330503, 330504, 330505, 330506, 330507, 330508, 330509, 330510, 330511, 330512, 330513, 330514, 330515, 330516, 330517, 330518, 330519}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateStartDazzling01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzling01 : TriggerState {
            internal StateStartDazzling01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

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
                context.SetRandomMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519}, visible: true, meshCount: 6, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519}, visible: true, meshCount: 6, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519}, visible: false, meshCount: 20, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.SetMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330500, 330501, 330502, 330503, 330504, 330505, 330506, 330507, 330508, 330509, 330510, 330511, 330512, 330513, 330514, 330515, 330516, 330517, 330518, 330519}, visible: true, meshCount: 20, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18051, 18052}, visible: false);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4011}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{130500, 130501, 130502, 130503, 130504, 130505, 130506, 130507, 130508, 130509, 130510, 130511, 130512, 130513, 130514, 130515, 130516, 130517, 130518, 130519}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
