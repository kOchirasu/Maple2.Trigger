using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _08_cheerupskill {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "CheerUpTimer", value: 1)) {
                    context.State = new StateCheerUpTimer_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheerUpTimer_20 : TriggerState {
            internal StateCheerUpTimer_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    context.State = new StateGiveCheerUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGiveCheerUp : TriggerState {
            internal StateGiveCheerUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9001}, arg2: 70000086, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheerUpTimer", value: 0);
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}