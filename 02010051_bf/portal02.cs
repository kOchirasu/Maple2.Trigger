namespace Maple2.Trigger._02010051_bf {
    public static class _portal02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 30, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 31, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{836, 6000, 6001, 6002, 6003}, visible: false);
                context.SetMesh(triggerIds: new []{1201, 1202, 1203, 1204, 1205, 1206, 12001, 12002, 12003, 12004, 12005, 12006, 12007, 12008, 12009, 12010, 12011, 12012, 12013, 12014, 12015, 12016, 12017, 12018, 12019, 12020, 12021, 12022, 12023, 12024, 12025, 12026, 12027, 12028}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000836}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9011})) {
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
                if (context.ObjectInteracted(interactIds: new []{10000836}, arg2: 0)) {
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
                context.SetEffect(triggerIds: new []{836, 6002}, visible: true);
                context.SetMesh(triggerIds: new []{1201, 1202, 1203, 1204, 1205, 1206}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{12001, 12002, 12003, 12004, 12005, 12006, 12007, 12008, 12009, 12010, 12011, 12012, 12013, 12014, 12015, 12016, 12017, 12018, 12019, 12020, 12021, 12022, 12023, 12024, 12025, 12026, 12027, 12028}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetPortal(portalId: 30, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 31, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000837}, arg2: 0)) {
                    return new StatePortalDisable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalDisable : TriggerState {
            internal StatePortalDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 30, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 31, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{1201, 1202, 1203, 1204, 1205, 1206}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{6002}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
