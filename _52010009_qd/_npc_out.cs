using System;

namespace Maple2.Trigger._52010009_qd {
    public static class _npc_out {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new int[] {111})) {
                    context.State = new Statenpc_out(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new int[] {112})) {
                    context.State = new Statenpc_out(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new int[] {113})) {
                    context.State = new Statenpc_out(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_out : TriggerState {
            internal Statenpc_out(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {111, 112, 113});
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}