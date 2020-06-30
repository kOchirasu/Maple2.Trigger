using System;

namespace Maple2.Trigger._02010051_bf {
    public static class _soundeffect05 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기01(context);

        private class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetEffect(arg1: new int[] {900}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new State음성연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State음성연출 : TriggerState {
            internal State음성연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetEffect(arg1: new int[] {900}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기02 : TriggerState {
            internal State대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "10000")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {900}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}