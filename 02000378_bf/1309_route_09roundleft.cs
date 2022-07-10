namespace Maple2.Trigger._02000378_bf {
    public static class _1309_route_09roundleft {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 15, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4015}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{18091, 18092}, visible: true);
                context.SetEffect(triggerIds: new []{5009}, visible: false);
                context.SetMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911, 330900, 330901, 330902, 330903, 330904, 330905, 330906, 330907, 330908, 330909, 330910, 330911}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetRandomMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911}, visible: true, meshCount: 4, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911}, visible: false, meshCount: 12, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911}, visible: true, meshCount: 4, arg4: 100, delay: 500);
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
                context.SetRandomMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911}, visible: false, meshCount: 12, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5009}, visible: true);
                context.SetMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{330900, 330901, 330902, 330903, 330904, 330905, 330906, 330907, 330908, 330909, 330910, 330911}, visible: true, meshCount: 12, arg4: 100, delay: 50);
                context.SetAgent(triggerIds: new []{18091, 18092}, visible: false);
                context.SetPortal(portalId: 15, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4015}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{130900, 130901, 130902, 130903, 130904, 130905, 130906, 130907, 130908, 130909, 130910, 130911}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
