namespace Maple2.Trigger._52000094_qd {
    public static class _52000094_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3003, 3004}, arg2: false);
                context.DestroyMonster(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {50100500}, arg3: new byte[] {1})) {
                    return new State20002275진행중일때(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {20002275}, arg3: new byte[] {1})) {
                    return new State20002275진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002275진행중일때 : TriggerState {
            internal State20002275진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009})) {
                    return new State20002275진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}