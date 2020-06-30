using System;

namespace Maple2.Trigger._02000329_bf {
    public static class _03_object {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State오브젝트_03(context);

        private class State오브젝트_03 : TriggerState {
            internal State오브젝트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1103, 1104})) {
                    context.State = new State오브젝트_03_작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트_03_작동 : TriggerState {
            internal State오브젝트_03_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
                    context.State = new State오브젝트_03_작동_메세지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트_03_작동_메세지 : TriggerState {
            internal State오브젝트_03_작동_메세지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}