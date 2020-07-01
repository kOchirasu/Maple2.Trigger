using System;

namespace Maple2.Trigger._02000323_bf {
    public static class _bossspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {99}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {99});
            }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}