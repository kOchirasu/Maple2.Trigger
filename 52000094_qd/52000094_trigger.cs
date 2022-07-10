namespace Maple2.Trigger._52000094_qd {
    public static class _52000094_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3003, 3004}, visible: false);
                context.DestroyMonster(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{50100500}, questStates: new byte[]{1})) {
                    return new State20002275진행중일때(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{20002275}, questStates: new byte[]{1})) {
                    return new State20002275진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002275진행중일때 : TriggerState {
            internal State20002275진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009})) {
                    return new State20002275진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
