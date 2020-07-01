namespace Maple2.Trigger._02000471_bf {
    public static class _elite_03 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "10002021clear") != 1 && context.GetUserValue(key: "SpawnCheck") == 1) {
                    return new Statespawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespawn : TriggerState {
            internal Statespawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Buff") == 1) {
                    return new Statebuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statebuff : TriggerState {
            internal Statebuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1999}, arg2: 70002021, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {303}, arg2: 70002021, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}