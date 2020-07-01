namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_c_monster {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: false);
                context.CreateMonster(arg1: new[] {402}, arg2: false);
                context.CreateMonster(arg1: new[] {403}, arg2: false);
                context.CreateMonster(arg1: new[] {404}, arg2: false);
                context.CreateMonster(arg1: new[] {405}, arg2: false);
                context.CreateMonster(arg1: new[] {406}, arg2: false);
                context.CreateMonster(arg1: new[] {407}, arg2: false);
                context.CreateMonster(arg1: new[] {408}, arg2: false);
                context.CreateMonster(arg1: new[] {409}, arg2: false);
                context.CreateMonster(arg1: new[] {410}, arg2: false);
                context.CreateMonster(arg1: new[] {411}, arg2: false);
                context.CreateMonster(arg1: new[] {412}, arg2: false);
                context.CreateMonster(arg1: new[] {413}, arg2: false);
                context.CreateMonster(arg1: new[] {414}, arg2: false);
                context.CreateMonster(arg1: new[] {415}, arg2: false);
                context.CreateMonster(arg1: new[] {416}, arg2: false);
                context.CreateMonster(arg1: new[] {417}, arg2: false);
                context.CreateMonster(arg1: new[] {418}, arg2: false);
                context.CreateMonster(arg1: new[] {419}, arg2: false);
                context.CreateMonster(arg1: new[] {420}, arg2: false);
                context.CreateMonster(arg1: new[] {421}, arg2: false);
                context.CreateMonster(arg1: new[] {422}, arg2: false);
                context.CreateMonster(arg1: new[] {423}, arg2: false);
                context.CreateMonster(arg1: new[] {424}, arg2: false);
                context.CreateMonster(arg1: new[] {425}, arg2: false);
                context.CreateMonster(arg1: new[] {426}, arg2: false);
                context.CreateMonster(arg1: new[] {427}, arg2: false);
                context.CreateMonster(arg1: new[] {428}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}