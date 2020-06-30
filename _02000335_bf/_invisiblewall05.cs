using System;

namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall05 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 707, arg2: 1)) {
                    context.State = new State벽면처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {7061, 7062, 7063, 7064, 7065, 7066, 7067, 7068, 7069, 7070},
                    arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}