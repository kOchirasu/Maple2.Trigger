namespace Maple2.Trigger._63000040_cs {
    public static class _common {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {101})) {
                    context.State = new Statenpc_exit_01(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {103})) {
                    context.State = new Statenpc_exit_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_01 : TriggerState {
            internal Statenpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_02 : TriggerState {
            internal Statenpc_exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}