using System;

namespace Maple2.Trigger._02010054_bf {
    public static class _spawn_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000884}, arg2: 2);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetMesh(arg1: new int[] {3127}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {105})) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.CreateMonster(arg1: new int[] {2022}, arg2: false);
                context.SetMesh(arg1: new int[] {3127}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2022})) {
                    context.SetInteractObject(arg1: new int[] {10000884}, arg2: 1);
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