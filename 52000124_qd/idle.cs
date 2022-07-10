namespace Maple2.Trigger._52000124_qd {
    public static class _idle {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100140, 60100141, 60100142, 60100143, 60100144, 60100145, 60100146, 60100147, 60100148, 60100149, 60100150, 60100151, 60100152, 60100153, 60100154, 60100155}, questStates: new byte[]{1})) {
                    return new StateDel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDel : TriggerState {
            internal StateDel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201, 202});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
