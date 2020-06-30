using System;

namespace Maple2.Trigger._02000252_bf {
    public static class _bigdoor_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {165, 166, 167, 168}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000406}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000406}, arg2: 0)) {
                    context.State = new State열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {9001}, arg2: 998);
                context.SetMesh(arg1: new int[] {165, 166, 167, 168}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}