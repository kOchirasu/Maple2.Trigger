namespace Maple2.Trigger._02100004_bf {
    public static class _npc10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State소환Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환Wait : TriggerState {
            internal State소환Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999992, key: "NpcSpawned10", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawn10") == 1) {
                    return new State소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999992, key: "NpcSpawned10", value: 1);
                context.CreateMonster(arg1: new[] {2010}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}