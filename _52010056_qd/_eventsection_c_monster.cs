using System;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_c_monster {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2003")) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {401}, arg2: false);
                context.CreateMonster(arg1: new int[] {402}, arg2: false);
                context.CreateMonster(arg1: new int[] {403}, arg2: false);
                context.CreateMonster(arg1: new int[] {404}, arg2: false);
                context.CreateMonster(arg1: new int[] {405}, arg2: false);
                context.CreateMonster(arg1: new int[] {406}, arg2: false);
                context.CreateMonster(arg1: new int[] {407}, arg2: false);
                context.CreateMonster(arg1: new int[] {408}, arg2: false);
                context.CreateMonster(arg1: new int[] {409}, arg2: false);
                context.CreateMonster(arg1: new int[] {410}, arg2: false);
                context.CreateMonster(arg1: new int[] {411}, arg2: false);
                context.CreateMonster(arg1: new int[] {412}, arg2: false);
                context.CreateMonster(arg1: new int[] {413}, arg2: false);
                context.CreateMonster(arg1: new int[] {414}, arg2: false);
                context.CreateMonster(arg1: new int[] {415}, arg2: false);
                context.CreateMonster(arg1: new int[] {416}, arg2: false);
                context.CreateMonster(arg1: new int[] {417}, arg2: false);
                context.CreateMonster(arg1: new int[] {418}, arg2: false);
                context.CreateMonster(arg1: new int[] {419}, arg2: false);
                context.CreateMonster(arg1: new int[] {420}, arg2: false);
                context.CreateMonster(arg1: new int[] {421}, arg2: false);
                context.CreateMonster(arg1: new int[] {422}, arg2: false);
                context.CreateMonster(arg1: new int[] {423}, arg2: false);
                context.CreateMonster(arg1: new int[] {424}, arg2: false);
                context.CreateMonster(arg1: new int[] {425}, arg2: false);
                context.CreateMonster(arg1: new int[] {426}, arg2: false);
                context.CreateMonster(arg1: new int[] {427}, arg2: false);
                context.CreateMonster(arg1: new int[] {428}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}