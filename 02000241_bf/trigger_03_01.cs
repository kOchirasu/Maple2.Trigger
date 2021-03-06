namespace Maple2.Trigger._02000241_bf {
    public static class _trigger_03_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {705, 706}, arg2: false);
                context.DestroyMonster(arg1: new[] {622, 623, 624, 625, 626, 627, 628, 629, 630});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {203})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {622, 623, 624, 625, 626, 627, 628, 629, 630}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {622, 623, 624, 625, 626, 627, 628, 629, 630})) {
                    context.HideGuideSummary(entityId: 110);
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}