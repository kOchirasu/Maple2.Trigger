namespace Maple2.Trigger._02000486_bf {
    public static class _101_buff {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {900})) {
                    return new State타임(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타임 : TriggerState {
            internal State타임(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900}) || context.MonsterDead(arg1: new[] {901})) {
                    // return new StateMove01(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_종료 : TriggerState {
            internal StateBuff_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}