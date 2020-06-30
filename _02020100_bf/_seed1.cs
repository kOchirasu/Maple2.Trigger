using System;

namespace Maple2.Trigger._02020100_bf {
    public static class _seed1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "Seed1interact", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed1start", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1302}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new int[] {10002109}, arg2: 1, arg3: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed1start", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002109}, arg2: 0)) {
                    context.State = new State씨앗1_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗1_대기 : TriggerState {
            internal State씨앗1_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10002109}, arg2: 0, arg3: true);
                context.SetUserValue(triggerID: 99990001, key: "Seed1interact", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed1start", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxID: 0, additionalEffectID: 70002109, level: true)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002109}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}