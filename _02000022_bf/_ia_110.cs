namespace Maple2.Trigger._02000022_bf {
    public static class _ia_110 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 110, arg2: false, arg3: "Idle_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000099}, arg2: 0)) {
                    context.State = new State개구리보이기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State개구리보이기 : TriggerState {
            internal State개구리보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 110, arg2: true, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000099}, arg2: 1)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 110, arg2: false, arg3: "Idle_A");
            }
        }
    }
}