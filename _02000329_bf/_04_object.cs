using System;

namespace Maple2.Trigger._02000329_bf {
    public static class _04_object {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State오브젝트_04(context);

        private class State오브젝트_04 : TriggerState {
            internal State오브젝트_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1105, 1106, 1107, 1108})) {
                    context.State = new State오브젝트_04_작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트_04_작동 : TriggerState {
            internal State오브젝트_04_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {104})) {
                    context.State = new State오브젝트_04_작동_메세지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트_04_작동_메세지 : TriggerState {
            internal State오브젝트_04_작동_메세지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}