namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_18 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {318}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {118})) {
                    return new StateSetup18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup18 : TriggerState {
            internal StateSetup18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {318}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {118})) {
                    return new StateSetup18끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup18끝 : TriggerState {
            internal StateSetup18끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "418", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "418")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}