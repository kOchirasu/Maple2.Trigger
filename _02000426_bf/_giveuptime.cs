using System;

namespace Maple2.Trigger._02000426_bf {
    public static class _giveuptime {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new State타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.SetEventUI(arg1: 1, arg2: "$DUNGEON__GIVEUP__TIME__0$", arg3: new int[] {3000});
                    context.DungeonEnableGiveUp(isEnable: true);
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