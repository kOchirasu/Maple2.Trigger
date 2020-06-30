using System;

namespace Maple2.Trigger._02000420_bf {
    public static class _barricade {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {301}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {99})) {
                    // context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}