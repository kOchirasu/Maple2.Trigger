using System;

namespace Maple2.Trigger._02020100_bf {
    public static class _seed3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "EliteClear", value: 0);
                context.SetUserValue(triggerID: 99990001, key: "Seed3interact", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed3start", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {229});
                context.SetMesh(arg1: new int[] {1304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new int[] {10002111}, arg2: 1, arg3: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed3start", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002111}, arg2: 0)) {
                    context.State = new State씨앗3_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗3_심기 : TriggerState {
            internal State씨앗3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "Seed3interact", value: 1);
                context.SetMesh(arg1: new int[] {1304}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10002122}, arg2: 1, arg3: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed3start", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002122}, arg2: 0)) {
                    context.State = new State씨앗3_중보(context);
                    return;
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxID: 0, additionalEffectID: 70002109, level: true)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗3_중보 : TriggerState {
            internal State씨앗3_중보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1404, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.DestroyMonster(arg1: new int[] {121, 122, 123, 124});
                context.CreateMonster(arg1: new int[] {229}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {229})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "EliteClear", value: 1);
                context.SetInteractObject(arg1: new int[] {10002111}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}