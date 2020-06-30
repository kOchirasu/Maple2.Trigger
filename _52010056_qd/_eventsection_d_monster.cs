using System;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_d_monster {
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
                context.CreateMonster(arg1: new int[] {501}, arg2: false);
                context.CreateMonster(arg1: new int[] {502}, arg2: false);
                context.CreateMonster(arg1: new int[] {503}, arg2: false);
                context.CreateMonster(arg1: new int[] {504}, arg2: false);
                context.CreateMonster(arg1: new int[] {505}, arg2: false);
                context.CreateMonster(arg1: new int[] {506}, arg2: false);
                context.CreateMonster(arg1: new int[] {507}, arg2: false);
                context.CreateMonster(arg1: new int[] {508}, arg2: false);
                context.CreateMonster(arg1: new int[] {509}, arg2: false);
                context.CreateMonster(arg1: new int[] {510}, arg2: false);
                context.CreateMonster(arg1: new int[] {511}, arg2: false);
                context.CreateMonster(arg1: new int[] {512}, arg2: false);
                context.CreateMonster(arg1: new int[] {513}, arg2: false);
                context.CreateMonster(arg1: new int[] {514}, arg2: false);
                context.CreateMonster(arg1: new int[] {515}, arg2: false);
                context.CreateMonster(arg1: new int[] {516}, arg2: false);
                context.CreateMonster(arg1: new int[] {517}, arg2: false);
                context.CreateMonster(arg1: new int[] {518}, arg2: false);
                context.CreateMonster(arg1: new int[] {519}, arg2: false);
                context.CreateMonster(arg1: new int[] {520}, arg2: false);
                context.CreateMonster(arg1: new int[] {521}, arg2: false);
                context.CreateMonster(arg1: new int[] {522}, arg2: false);
                context.CreateMonster(arg1: new int[] {523}, arg2: false);
                context.CreateMonster(arg1: new int[] {524}, arg2: false);
                context.CreateMonster(arg1: new int[] {525}, arg2: false);
                context.CreateMonster(arg1: new int[] {526}, arg2: false);
                context.CreateMonster(arg1: new int[] {527}, arg2: false);
                context.CreateMonster(arg1: new int[] {528}, arg2: false);
                context.CreateMonster(arg1: new int[] {529}, arg2: false);
                context.CreateMonster(arg1: new int[] {530}, arg2: false);
                context.CreateMonster(arg1: new int[] {531}, arg2: false);
                context.CreateMonster(arg1: new int[] {532}, arg2: false);
                context.CreateMonster(arg1: new int[] {533}, arg2: false);
                context.CreateMonster(arg1: new int[] {534}, arg2: false);
                context.CreateMonster(arg1: new int[] {535}, arg2: false);
                context.CreateMonster(arg1: new int[] {536}, arg2: false);
                context.CreateMonster(arg1: new int[] {537}, arg2: false);
                context.CreateMonster(arg1: new int[] {538}, arg2: false);
                context.CreateMonster(arg1: new int[] {539}, arg2: false);
                context.CreateMonster(arg1: new int[] {540}, arg2: false);
                context.CreateMonster(arg1: new int[] {541}, arg2: false);
                context.CreateMonster(arg1: new int[] {542}, arg2: false);
                context.CreateMonster(arg1: new int[] {543}, arg2: false);
                context.CreateMonster(arg1: new int[] {544}, arg2: false);
                context.CreateMonster(arg1: new int[] {545}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}