using System;

namespace Maple2.Trigger._02000486_bf {
    public static class _104_clear {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State끝1(context);

        private class State끝1 : TriggerState {
            internal State끝1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9901})) {
                    context.State = new State끝2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcHp(spawnPointId: 900, compare: "lowerEqual", value: 5, isRelative: "true")
                    && context.CheckNpcHp(spawnPointId: 901, compare: "lowerEqual", value: 5, isRelative: "true")) {
                    context.State = new State끝3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝3 : TriggerState {
            internal State끝3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {900}, arg2: 50002505, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new int[] {901}, arg2: 50002505, arg3: 1, arg4: true, arg5: false);
                context.SetSkill(arg1: new int[] {1000049}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) { }
            }

            public override void OnExit() { }
        }
    }
}