namespace Maple2.Trigger._52010060_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001}, jobCode: 0)) {
                    return new State크림슨발록Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Spawn : TriggerState {
            internal State크림슨발록Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
