namespace Maple2.Trigger._52000070_qd {
    public static class _npcdown_904 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9900, arg2: new[] {904})) {
                    context.State = new StateNpcFight(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcFight : TriggerState {
            internal StateNpcFight(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {904})) {
                    context.State = new StateNpcDown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcDown : TriggerState {
            internal StateNpcDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {304}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}