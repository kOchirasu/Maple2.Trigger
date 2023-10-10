namespace Maple2.Trigger._02000551_bf {
    public static class _startportal {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateDefaultSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting : TriggerState {
            internal StateDefaultSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{8101, 8102, 8103, 8104, 8105}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.DungeonEnableGiveUp(enabled: true);
                context.SetEventUI(arg1: 1, script: "$02020140_BF__BARRICADE__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure종료(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure종료(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new StatePortalHide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalHide : TriggerState {
            internal StatePortalHide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure종료(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure종료 : TriggerState {
            internal StateDungeonFailure종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
