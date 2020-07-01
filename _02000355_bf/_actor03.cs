using System;

namespace Maple2.Trigger._02000355_bf {
    public static class _actor03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetActor(arg1: 203, arg2: true, arg3: "Damg_B");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1301})) {
                    context.State = new State몬스터소환대기(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {1302})) {
                    context.State = new State몬스터소환대기(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {1303})) {
                    context.State = new State몬스터소환대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환대기 : TriggerState {
            internal State몬스터소환대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State더미해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State더미해제 : TriggerState {
            internal State더미해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 203, arg2: false, arg3: "Damg_B");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2003})) {
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