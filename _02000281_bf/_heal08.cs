namespace Maple2.Trigger._02000281_bf {
    public static class _heal08 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {708}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000247}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000247}, arg2: 0)) {
                    return new State스킬작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬작동 : TriggerState {
            internal State스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {708}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetSkill(arg1: new[] {708}, arg2: false);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "29", arg2: 29);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "29")) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}