namespace Maple2.Trigger._61000004_me {
    public static class _trap_05 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000130}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000130}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {801, 802, 803, 804, 805, 806}, arg2: false, arg3: 0, arg4: 0);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "130", arg2: 5, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "130")) {
                    context.SetMesh(arg1: new[] {801, 802, 803, 804, 805, 806}, arg2: true, arg3: 0, arg4: 0);
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "130");
            }
        }
    }
}