namespace Maple2.Trigger._02000441_bf {
    public static class _anchor_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1500, 1501, 1502, 1503, 1504}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 10f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001097}, arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1500, 1501, 1502, 1503, 1504}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}