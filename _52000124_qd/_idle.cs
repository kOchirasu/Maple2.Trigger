namespace Maple2.Trigger._52000124_qd {
    public static class _idle {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100140, 60100141, 60100142, 60100143, 60100144, 60100145, 60100146, 60100147, 60100148, 60100149, 60100150, 60100151, 60100152, 60100153, 60100154, 60100155}, arg3: new byte[] {1})) {
                    return new Statedel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statedel : TriggerState {
            internal Statedel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 202});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}