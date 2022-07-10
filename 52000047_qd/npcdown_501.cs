namespace Maple2.Trigger._52000047_qd {
    public static class _npcdown_501 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9900, spawnIds: new []{901})) {
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
                if (context.MonsterDead(spawnIds: new []{901})) {
                    return new StateNpcDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDown : TriggerState {
            internal StateNpcDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{511}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{511});
                context.SetUserValue(key: "NpcRemove", value: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
