namespace Maple2.Trigger._02000355_bf {
    public static class _actor09 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{609}, visible: false);
                context.SetActor(triggerId: 209, visible: true, initialSequence: "Damg_B");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1901})) {
                    return new StateMonster소환Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환Wait : TriggerState {
            internal StateMonster소환Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{609}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State더미해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State더미해제 : TriggerState {
            internal State더미해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 209, visible: false, initialSequence: "Damg_B");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2009})) {
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
