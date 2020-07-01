namespace Maple2.Trigger._02000325_bf {
    public static class _heal02 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {702}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000740}, arg2: 0)) {
                    return new State스킬작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬작동 : TriggerState {
            internal State스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {702}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {612}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetSkill(arg1: new[] {702}, arg2: false);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.SetInteractObject(arg1: new[] {10000740}, arg2: 2);
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}