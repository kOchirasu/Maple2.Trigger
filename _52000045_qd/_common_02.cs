namespace Maple2.Trigger._52000045_qd {
    public static class _common_02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {301})) {
                    context.State = new Statenpc_exit_01(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {302})) {
                    context.State = new Statenpc_exit_02(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {303})) {
                    context.State = new Statenpc_exit_03(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {304})) {
                    context.State = new Statenpc_exit_04(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {305})) {
                    context.State = new Statenpc_exit_05(context);
                    return;
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {306})) {
                    context.State = new Statenpc_exit_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_01 : TriggerState {
            internal Statenpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301});
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
                context.DestroyMonster(arg1: new[] {302});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_03 : TriggerState {
            internal Statenpc_exit_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {303});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_04 : TriggerState {
            internal Statenpc_exit_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {304});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_05 : TriggerState {
            internal Statenpc_exit_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {305});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_exit_06 : TriggerState {
            internal Statenpc_exit_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {306});
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