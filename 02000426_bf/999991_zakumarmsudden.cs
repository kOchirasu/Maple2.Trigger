namespace Maple2.Trigger._02000426_bf {
    public static class _999991_zakumarmsudden {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SummonZakumArmRegenCheck", value: 0);
                context.SetUserValue(key: "SummonZakumArmMany", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateWait중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait중 : TriggerState {
            internal StateWait중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SummonZakumArmRegenCheck") == 1) {
                    return new State자쿰몸통InvincibilityBuff로직_WaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통InvincibilityBuff로직_WaitStart : TriggerState {
            internal State자쿰몸통InvincibilityBuff로직_WaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자쿰몸통InvincibilityBuff로직_작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통InvincibilityBuff로직_작동 : TriggerState {
            internal State자쿰몸통InvincibilityBuff로직_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{2011}, skillId: 50000265, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{2012}, skillId: 50000265, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SummonZakumArmMany") == 0) {
                    return new State자쿰몸통InvincibilityBuff_RemoveWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통InvincibilityBuff_RemoveWait : TriggerState {
            internal State자쿰몸통InvincibilityBuff_RemoveWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State자쿰몸통InvincibilityBuff_Remove작업(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통InvincibilityBuff_Remove작업 : TriggerState {
            internal State자쿰몸통InvincibilityBuff_Remove작업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnId: 2011, additionalEffectId: 50000265);
                context.NpcRemoveAdditionalEffect(spawnId: 2012, additionalEffectId: 50000265);
                context.SetUserValue(key: "SummonZakumArmRegenCheck", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateWait중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
