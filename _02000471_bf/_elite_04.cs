using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _elite_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserValue(key: "10002022clear", value: 1)
                    && context.UserValue(key: "SpawnCheck", value: 1)) {
                    context.State = new Statespawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statespawn : TriggerState {
            internal Statespawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Buff", value: 1)) {
                    context.State = new Statebuff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff : TriggerState {
            internal Statebuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {1999}, arg2: 70002031, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new int[] {304}, arg2: 70002031, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}