namespace Maple2.Trigger._02020061_bf {
    public static class _boss_invincible_off {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BombPhase") == 2) {
                    context.State = new State무적해제안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무적해제안내 : TriggerState {
            internal State무적해제안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9002}, arg2: 70002371, arg3: 1, arg5: false);
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__BOSS_INVINCIBLE_OFF__0$", arg3: 5000);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossClear") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}