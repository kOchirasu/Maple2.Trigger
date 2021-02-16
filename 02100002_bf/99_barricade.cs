namespace Maple2.Trigger._02100002_bf {
    public static class _99_barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PortalOn", value: 0);
                context.SetUserValue(key: "MissionStart", value: 0);
                context.SetUserValue(key: "DungeonClear", value: 0);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    return new StatePortalOnDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOnDelay : TriggerState {
            internal StatePortalOnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 21, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MissionStart") == 1) {
                    return new StateCountDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCountDown : TriggerState {
            internal StateCountDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02100002_BF__99_BARRICADE__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateShutDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShutDown : TriggerState {
            internal StateShutDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    return new StateRelease(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRelease : TriggerState {
            internal StateRelease(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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