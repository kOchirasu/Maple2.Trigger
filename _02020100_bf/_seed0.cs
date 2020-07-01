namespace Maple2.Trigger._02020100_bf {
    public static class _seed0 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Seed0interact", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Seed0start") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1301}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002115}, arg2: 1, arg3: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Seed0start") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002115}, arg2: 0)) {
                    context.State = new State씨앗0_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗0_대기 : TriggerState {
            internal State씨앗0_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002115}, arg2: 0, arg3: true);
                context.SetUserValue(triggerId: 99990001, key: "Seed0interact", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Seed0start") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 0, additionalEffectId: 70002109, level: true)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002115}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}