using System;

namespace Maple2.Trigger._52020024_qd {
    public static class _52020024_finalphase {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "FinalPhase", value: 1)) {
                    context.State = new State스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {131, 132, 133, 134, 135, 136}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State스폰(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {131, 132, 133, 134, 135, 136})) {
                    context.State = new State스폰(context);
                    return;
                }

                if (context.UserValue(key: "FinalPhase", value: 2)) {
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