namespace Maple2.Trigger._81000001_item {
    public static class _trap_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000129}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {701, 702, 703}, arg2: false, arg3: 0, arg4: 0);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "129", arg2: 5, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "129")) {
                    context.SetMesh(arg1: new[] {701, 702, 703}, arg2: true, arg3: 0, arg4: 0);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "129");
            }
        }
    }
}