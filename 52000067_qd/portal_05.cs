namespace Maple2.Trigger._52000067_qd {
    public static class _portal_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StatePortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal : TriggerState {
            internal StatePortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{802}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{802})) {
                    return new StatePortal_off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_off : TriggerState {
            internal StatePortal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7014}, visible: false);
                context.SetEffect(triggerIds: new []{7114}, visible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
