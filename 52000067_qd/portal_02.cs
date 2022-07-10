namespace Maple2.Trigger._52000067_qd {
    public static class _portal_02 {
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
                context.CreateMonster(spawnIds: new []{805}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{805})) {
                    return new StatePortal_off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_off : TriggerState {
            internal StatePortal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 114, script: "$52000067_QD__PORTAL_02__0$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 109, script: "$52000067_QD__PORTAL_02__1$", arg4: 3, arg5: 1);
                context.SetEffect(triggerIds: new []{7011}, visible: false);
                context.SetEffect(triggerIds: new []{7111}, visible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
