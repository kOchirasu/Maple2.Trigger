namespace Maple2.Trigger._02000284_bf {
    public static class _ladder {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 1);
                context.SetMesh(arg1: new[] {314, 315, 316, 317, 318, 319, 320}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000429}, arg2: 0)) {
                    context.State = new State사다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성 : TriggerState {
            internal State사다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 0);
                context.SetMesh(arg1: new[] {314, 315, 316, 317, 318, 319, 320}, arg2: true, arg3: 0, arg4: 500,
                    arg5: 0f);
                context.SetTimer(arg1: "1500", arg2: 1500, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1500")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}