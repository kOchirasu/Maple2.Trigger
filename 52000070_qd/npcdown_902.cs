namespace Maple2.Trigger._52000070_qd {
    public static class _npcdown_902 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9900, spawnIds: new []{902})) {
                    return new StateNpcFight(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcFight : TriggerState {
            internal StateNpcFight(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new StateNpcDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDown : TriggerState {
            internal StateNpcDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{302}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
