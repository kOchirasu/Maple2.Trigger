namespace Maple2.Trigger._02000432_bf {
    public static class _buff_1 {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{2001})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{2001}, skillId: 40501001, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDead : TriggerState {
            internal StateDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateDead_BuffRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDead_BuffRemove : TriggerState {
            internal StateDead_BuffRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{2002}, skillId: 40501005, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
