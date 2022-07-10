namespace Maple2.Trigger._52000185_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{2001}, skillId: 99910280, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910280, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                return new StateReady(context);
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{2001}, skillId: 99910280, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910280, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }
    }
}
