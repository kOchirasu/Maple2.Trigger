namespace Maple2.Trigger._02000284_bf {
    public static class _ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 1);
                context.SetMesh(arg1: new[] {314, 315, 316, 317, 318, 319, 320}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000429}, arg2: 0)) {
                    return new StateLadderCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation : TriggerState {
            internal StateLadderCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 0);
                context.SetMesh(arg1: new[] {314, 315, 316, 317, 318, 319, 320}, arg2: true, arg3: 0, arg4: 500, arg5: 0f);
                context.SetTimer(id: "1500", arg2: 1500, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1500")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}