using System;

namespace Maple2.Trigger._02000401_bf {
    public static class _cannon_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {694}, arg2: false);
                context.SetMesh(arg1: new int[] {3904}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "cannon04", value: 1)) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2904}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2904})) {
                    context.SetEffect(arg1: new int[] {694}, arg2: true);
                    context.SetMesh(arg1: new int[] {3904}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}