using System;

namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000109}, arg2: 1);
                context.SetEffect(arg1: new int[] {201, 202, 203, 204}, arg2: false);
                context.SetMesh(arg1: new int[] {325, 326, 303, 304}, arg2: true);
                context.SetMesh(arg1: new int[] {305, 306, 307, 308}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000109}, arg2: 0)) {
                    context.State = new State개봉박두(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {325, 326, 303, 304}, arg2: false);
                context.CreateMonster(arg1: new int[] {91, 92, 93, 94}, arg2: true);
                context.SetMesh(arg1: new int[] {305, 306, 307, 308}, arg2: true);
                context.SetEffect(arg1: new int[] {201, 202, 203, 204}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {91, 92, 93, 94})) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "401")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}