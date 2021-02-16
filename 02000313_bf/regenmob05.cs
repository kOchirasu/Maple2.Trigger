namespace Maple2.Trigger._02000313_bf {
    public static class _regenmob05 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 13, arg2: new[] {91})) {
                    return new State소환몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환몹Spawn : TriggerState {
            internal State소환몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 104});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103, 104})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1");
            }
        }
    }
}