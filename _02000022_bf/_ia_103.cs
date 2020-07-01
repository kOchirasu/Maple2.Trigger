namespace Maple2.Trigger._02000022_bf {
    public static class _ia_103 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 103, arg2: false, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                return new State오브젝트반응(context);
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000092}, arg2: 0)) {
                    return new State개구리보이기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개구리보이기 : TriggerState {
            internal State개구리보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 103, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000092}, arg2: 1)) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 103, arg2: false, arg3: "Idle_A");
            }
        }
    }
}