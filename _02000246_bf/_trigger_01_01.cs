namespace Maple2.Trigger._02000246_bf {
    public static class _trigger_01_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {201})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609})) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}