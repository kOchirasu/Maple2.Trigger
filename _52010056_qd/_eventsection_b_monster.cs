using System;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_b_monster {
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
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.CreateMonster(arg1: new int[] {302}, arg2: true);
                context.CreateMonster(arg1: new int[] {303}, arg2: true);
                context.CreateMonster(arg1: new int[] {304}, arg2: true);
                context.CreateMonster(arg1: new int[] {305}, arg2: true);
                context.CreateMonster(arg1: new int[] {306}, arg2: true);
                context.CreateMonster(arg1: new int[] {307}, arg2: true);
                context.CreateMonster(arg1: new int[] {308}, arg2: true);
                context.CreateMonster(arg1: new int[] {309}, arg2: true);
                context.CreateMonster(arg1: new int[] {310}, arg2: true);
                context.CreateMonster(arg1: new int[] {311}, arg2: true);
                context.CreateMonster(arg1: new int[] {312}, arg2: true);
                context.CreateMonster(arg1: new int[] {313}, arg2: true);
                context.CreateMonster(arg1: new int[] {314}, arg2: true);
                context.CreateMonster(arg1: new int[] {315}, arg2: true);
                context.CreateMonster(arg1: new int[] {316}, arg2: true);
                context.CreateMonster(arg1: new int[] {317}, arg2: true);
                context.CreateMonster(arg1: new int[] {318}, arg2: true);
                context.CreateMonster(arg1: new int[] {319}, arg2: true);
                context.CreateMonster(arg1: new int[] {320}, arg2: true);
                context.CreateMonster(arg1: new int[] {321}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}