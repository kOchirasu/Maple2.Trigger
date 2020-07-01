namespace Maple2.Trigger._02000471_bf {
    public static class _elite_04 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "10002022clear") != 1 && context.GetUserValue(key: "SpawnCheck") == 1) {
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
                if (context.GetUserValue(key: "Buff") == 1) {
                    context.State = new Statebuff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff : TriggerState {
            internal Statebuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1999}, arg2: 70002031, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {304}, arg2: 70002031, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}