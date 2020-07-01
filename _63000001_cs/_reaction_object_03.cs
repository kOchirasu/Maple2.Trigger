namespace Maple2.Trigger._63000001_cs {
    public static class _reaction_object_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {5001})) {
                    return new State채집가능(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State채집가능 : TriggerState {
            internal State채집가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {603}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {603}, arg2: 2)) {
                    context.CreateItem(arg1: new[] {1003});
                    return new State채집완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State채집완료 : TriggerState {
            internal State채집완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 30, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}