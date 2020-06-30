using System;

namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new State벽면처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050},
                    arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}