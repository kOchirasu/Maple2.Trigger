using System;

namespace Maple2.Trigger._02020112_bf {
    public static class _safezone2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990017, key: "Safe", value: 0);
                context.SetInteractObject(arg1: new int[] {10002118}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "903")) {
                    context.State = new State안전장치_활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안전장치_활성화 : TriggerState {
            internal State안전장치_활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.SetInteractObject(arg1: new int[] {10002118}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002118}, arg2: 0)) {
                    context.State = new State안전장치_작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안전장치_작동 : TriggerState {
            internal State안전장치_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__SAFEZONE2__0$", arg3: new int[] {5000});
                context.SetUserValue(triggerID: 99990017, key: "Safe", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}