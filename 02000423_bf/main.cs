namespace Maple2.Trigger._02000423_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateDefaultSetting시작(context);
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting시작 : TriggerState {
            internal StateDefaultSetting시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PortalHidden") == 1) {
                    return new StateBoss사냥후PortalCreation(context);
                }

                if (context.NpcDetected(boxId: 101, spawnIds: new []{100})) {
                    return new StatePortalHide(context);
                }

                if (!context.NpcDetected(boxId: 101, spawnIds: new []{100})) {
                    return new State디폴트PortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디폴트PortalCreation : TriggerState {
            internal State디폴트PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 14, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal다시체크Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss사냥후PortalCreation : TriggerState {
            internal StateBoss사냥후PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 14, visible: true, enabled: true, minimapVisible: true);
                context.SetUserValue(key: "PortalHidden", value: 0);
                context.ShowGuideSummary(entityId: 20043001, textId: 20043001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePortal다시체크Wait이전(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20043001);
            }
        }

        private class StatePortalHide : TriggerState {
            internal StatePortalHide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return new StatePortal다시체크Wait(context);
            }

            public override void OnExit() { }
        }

        private class StatePortal다시체크Wait이전 : TriggerState {
            internal StatePortal다시체크Wait이전(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal다시체크Wait : TriggerState {
            internal StatePortal다시체크Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
