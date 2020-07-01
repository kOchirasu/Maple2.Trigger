using System;

namespace Maple2.Trigger._02000486_bf {
    public static class _107_text {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State유저감지(context);

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9901})) {
                    context.State = new State알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcHp(spawnPointId: 900, compare: "lowerEqual", value: 30, isRelative: "true")
                    || context.CheckNpcHp(spawnPointId: 901, compare: "lowerEqual", value: 30, isRelative: "true")) {
                    context.State = new State텍스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State텍스트 : TriggerState {
            internal State텍스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000486_BF__107_TEXT__0$", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (true) { }
            }

            public override void OnExit() { }
        }
    }
}