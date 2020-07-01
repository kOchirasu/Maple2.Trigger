namespace Maple2.Trigger._52000047_qd {
    public static class _npcdown_500 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9900, arg2: new[] {900})) {
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
                if (context.MonsterDead(arg1: new[] {900})) {
                    context.State = new StateNpcDown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcDown : TriggerState {
            internal StateNpcDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {510}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "NpcRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {510});
                context.SetUserValue(key: "NpcRemove", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}