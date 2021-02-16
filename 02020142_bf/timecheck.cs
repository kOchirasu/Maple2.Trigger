namespace Maple2.Trigger._02020142_bf {
    public static class _timecheck {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State던전시간체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전시간체크 : TriggerState {
            internal State던전시간체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 41, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 42, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 43, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 44, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 45, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 46, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 47, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 48, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 49, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(portalId: 41, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 42, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 43, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 44, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 45, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 46, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 47, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 48, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 49, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}