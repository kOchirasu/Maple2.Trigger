namespace Maple2.Trigger._02000551_bf {
    public static class _portalspeedracingmode {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateTeleportationPortalHide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportationPortalHide : TriggerState {
            internal StateTeleportationPortalHide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 12000, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3000, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6000, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9000, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12201, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12202, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4501, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4502, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7801, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7802, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10111, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10112, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13003, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13006, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13009, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13012, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13121, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13031, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13061, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13091, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpeedRacingMode") == 1) {
                    return new StateTeleportationPortalSpawn(context);
                }

                if (context.GetUserValue(key: "SpeedRacingMode") == 2) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportationPortalSpawn : TriggerState {
            internal StateTeleportationPortalSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 12000, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3000, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6000, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 9000, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12202, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4501, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4502, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7801, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7802, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10111, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10112, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13003, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13006, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13009, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13012, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13121, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13031, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13061, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13091, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpeedRacingMode") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTeleportationPortalHide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3800)) {
                    return new StateTeleportationPortalSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}