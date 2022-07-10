namespace Maple2.Trigger._52000067_qd {
    public static class _portal_03 {
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
                context.CreateMonster(spawnIds: new []{801}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{801})) {
                    return new StatePortal_off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_off : TriggerState {
            internal StatePortal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 108, script: "$52000067_QD__PORTAL_03__0$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 115, script: "$52000067_QD__PORTAL_03__1$", arg4: 3, arg5: 1);
                context.SetEffect(triggerIds: new []{7012}, visible: false);
                context.SetEffect(triggerIds: new []{7112}, visible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
