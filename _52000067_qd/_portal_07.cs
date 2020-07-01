namespace Maple2.Trigger._52000067_qd {
    public static class _portal_07 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    context.State = new Stateportal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal : TriggerState {
            internal Stateportal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {807}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {807})) {
                    context.State = new Stateportal_off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_off : TriggerState {
            internal Stateportal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7016}, arg2: false);
                context.SetEffect(arg1: new[] {7116}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}