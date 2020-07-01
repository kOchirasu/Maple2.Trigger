namespace Maple2.Trigger._52000185_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 99910280, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910280, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 99910280, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 99910280, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateIdle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}