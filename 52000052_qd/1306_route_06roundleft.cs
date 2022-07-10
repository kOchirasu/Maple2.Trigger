namespace Maple2.Trigger._52000052_qd {
    public static class _1306_route_06roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{18061, 18062}, visible: true);
                context.SetEffect(triggerIds: new []{5006}, visible: false);
                context.SetMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625, 330600, 330601, 330602, 330603, 330604, 330605, 330606, 330607, 330608, 330609, 330610, 330611, 330612, 330613, 330614, 330615, 330616, 330617, 330618, 330619, 330620, 330621, 330622, 330623, 330624, 330625}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, visible: false, meshCount: 26, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, visible: true, meshCount: 7, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, visible: false, meshCount: 26, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5006}, visible: true);
                context.SetMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330600, 330601, 330602, 330603, 330604, 330605, 330606, 330607, 330608, 330609, 330610, 330611, 330612, 330613, 330614, 330615, 330616, 330617, 330618, 330619, 330620, 330621, 330622, 330623, 330624, 330625}, visible: true, meshCount: 26, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18061, 18062}, visible: false);
                context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{130600, 130601, 130602, 130603, 130604, 130605, 130606, 130607, 130608, 130609, 130610, 130611, 130612, 130613, 130614, 130615, 130616, 130617, 130618, 130619, 130620, 130621, 130622, 130623, 130624, 130625}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
