namespace Maple2.Trigger._02010051_bf {
    public static class _portal01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{835, 6000, 6001, 6002, 6003}, visible: false);
                context.SetMesh(triggerIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013, 11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026, 11027, 11028}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000835}, state: 1);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9010})) {
                    return new State입장Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장Delay01 : TriggerState {
            internal State입장Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateGuidePrepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuidePrepare01 : TriggerState {
            internal StateGuidePrepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105101, textId: 20105101, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000835}, arg2: 0)) {
                    return new StatePortalEnable01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable01 : TriggerState {
            internal StatePortalEnable01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 1);
                context.SetEffect(triggerIds: new []{835, 6001}, visible: true);
                context.SetMesh(triggerIds: new []{1101, 1102, 1103, 1104, 1105, 1106}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013, 11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026, 11027, 11028}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StatePortalEnable02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable02 : TriggerState {
            internal StatePortalEnable02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 21, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000836}, arg2: 0)) {
                    return new StatePortalDisable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalDisable : TriggerState {
            internal StatePortalDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{1101, 1102, 1103, 1104, 1105, 1106}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{6001}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
