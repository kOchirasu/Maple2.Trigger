using System;

namespace Maple2.Trigger._02000311_bf {
    public static class _buff_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Buff_02", value: 1)) {
                    context.State = new StateBuff_02_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBuff_02_Ready : TriggerState {
            internal StateBuff_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {702})) {
                    context.State = new StateBuff_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBuff_02 : TriggerState {
            internal StateBuff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {702})) {
                    context.State = new StateBuff_02_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBuff_02_Start : TriggerState {
            internal StateBuff_02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {702}, arg2: 50003006, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBuff_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}