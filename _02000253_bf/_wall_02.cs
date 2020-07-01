namespace Maple2.Trigger._02000253_bf {
    public static class _wall_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9003, 9004}, arg2: true);
                context.SetMesh(arg1: new[] {503, 504, 604, 605, 606}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000438}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000438}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9003, 9004}, arg2: false);
                context.SetMesh(arg1: new[] {503, 504, 604, 605, 606}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}