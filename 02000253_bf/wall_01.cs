namespace Maple2.Trigger._02000253_bf {
    public static class _wall_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002}, arg2: true);
                context.SetMesh(arg1: new[] {501, 502, 601, 602, 603}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000437}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000437}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002}, arg2: false);
                context.SetMesh(arg1: new[] {501, 502, 601, 602, 603}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}