using System;

namespace Maple2.Trigger._02010051_bf {
    public static class _eventtimer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9003")) {
                    context.State = new State시간체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시간체크 : TriggerState {
            internal State시간체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "timercheck", value: 1)) {
                    context.State = new State업적이벤트(context);
                    return;
                }

                if (context.WaitTick(waitTick: 240000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State업적이벤트 : TriggerState {
            internal State업적이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9003, arg2: "trigger", arg3: "CaboTimeEvent");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State업적이벤트(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
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