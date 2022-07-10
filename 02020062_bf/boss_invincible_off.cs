namespace Maple2.Trigger._02020062_bf {
    public static class _boss_invincible_off {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BombPhase") == 2) {
                    return new State무적해제안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무적해제안내 : TriggerState {
            internal State무적해제안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9002}, skillId: 70002371, level: 1, arg5: false);
                context.SetEventUI(arg1: 1, script: "$02020062_BF__BOSS_INVINCIBLE_OFF__0$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossClear") == 1) {
                    return new StateEnd(context);
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
