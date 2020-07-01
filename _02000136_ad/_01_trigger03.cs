namespace Maple2.Trigger._02000136_ad {
    public static class _01_trigger03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {804}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000068}, arg2: 1);
                context.SetMesh(arg1: new[] {15}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000068}, arg2: 0)) {
                    return new State발판등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판등장 : TriggerState {
            internal State발판등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {15}, arg2: true);
                context.SetEffect(arg1: new[] {804}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}