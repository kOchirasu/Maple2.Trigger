using System;

namespace Maple2.Trigger._02010052_bf {
    public static class _invisiblewall03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        20300, 20301, 20302, 20303, 20304, 20305, 20306, 20307, 20308, 20309, 20310, 20311, 20312,
                        20313, 20314, 20315, 20316, 20317, 20318, 20319, 20320, 20321, 20322, 20323, 20324, 20325,
                        20326, 20327, 20328, 20329, 20330
                    }, arg2: true, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 712, arg2: 1)) {
                    context.State = new State벽면처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        20300, 20301, 20302, 20303, 20304, 20305, 20306, 20307, 20308, 20309, 20310, 20311, 20312,
                        20313, 20314, 20315, 20316, 20317, 20318, 20319, 20320, 20321, 20322, 20323, 20324, 20325,
                        20326, 20327, 20328, 20329, 20330
                    }, arg2: false, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 712, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}