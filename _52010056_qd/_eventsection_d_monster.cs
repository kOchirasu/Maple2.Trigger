namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_d_monster {
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
                context.CreateMonster(arg1: new[] {501}, arg2: false);
                context.CreateMonster(arg1: new[] {502}, arg2: false);
                context.CreateMonster(arg1: new[] {503}, arg2: false);
                context.CreateMonster(arg1: new[] {504}, arg2: false);
                context.CreateMonster(arg1: new[] {505}, arg2: false);
                context.CreateMonster(arg1: new[] {506}, arg2: false);
                context.CreateMonster(arg1: new[] {507}, arg2: false);
                context.CreateMonster(arg1: new[] {508}, arg2: false);
                context.CreateMonster(arg1: new[] {509}, arg2: false);
                context.CreateMonster(arg1: new[] {510}, arg2: false);
                context.CreateMonster(arg1: new[] {511}, arg2: false);
                context.CreateMonster(arg1: new[] {512}, arg2: false);
                context.CreateMonster(arg1: new[] {513}, arg2: false);
                context.CreateMonster(arg1: new[] {514}, arg2: false);
                context.CreateMonster(arg1: new[] {515}, arg2: false);
                context.CreateMonster(arg1: new[] {516}, arg2: false);
                context.CreateMonster(arg1: new[] {517}, arg2: false);
                context.CreateMonster(arg1: new[] {518}, arg2: false);
                context.CreateMonster(arg1: new[] {519}, arg2: false);
                context.CreateMonster(arg1: new[] {520}, arg2: false);
                context.CreateMonster(arg1: new[] {521}, arg2: false);
                context.CreateMonster(arg1: new[] {522}, arg2: false);
                context.CreateMonster(arg1: new[] {523}, arg2: false);
                context.CreateMonster(arg1: new[] {524}, arg2: false);
                context.CreateMonster(arg1: new[] {525}, arg2: false);
                context.CreateMonster(arg1: new[] {526}, arg2: false);
                context.CreateMonster(arg1: new[] {527}, arg2: false);
                context.CreateMonster(arg1: new[] {528}, arg2: false);
                context.CreateMonster(arg1: new[] {529}, arg2: false);
                context.CreateMonster(arg1: new[] {530}, arg2: false);
                context.CreateMonster(arg1: new[] {531}, arg2: false);
                context.CreateMonster(arg1: new[] {532}, arg2: false);
                context.CreateMonster(arg1: new[] {533}, arg2: false);
                context.CreateMonster(arg1: new[] {534}, arg2: false);
                context.CreateMonster(arg1: new[] {535}, arg2: false);
                context.CreateMonster(arg1: new[] {536}, arg2: false);
                context.CreateMonster(arg1: new[] {537}, arg2: false);
                context.CreateMonster(arg1: new[] {538}, arg2: false);
                context.CreateMonster(arg1: new[] {539}, arg2: false);
                context.CreateMonster(arg1: new[] {540}, arg2: false);
                context.CreateMonster(arg1: new[] {541}, arg2: false);
                context.CreateMonster(arg1: new[] {542}, arg2: false);
                context.CreateMonster(arg1: new[] {543}, arg2: false);
                context.CreateMonster(arg1: new[] {544}, arg2: false);
                context.CreateMonster(arg1: new[] {545}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}