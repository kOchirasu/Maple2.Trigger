namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_03_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000301}, arg2: 1);
                context.SetMesh(arg1: new[] {705, 706}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000301}, arg2: 0)) {
                    return new State개봉(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉 : TriggerState {
            internal State개봉(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {705, 706}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}