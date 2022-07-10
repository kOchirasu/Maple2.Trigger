namespace Maple2.Trigger._02000110_bf {
    public static class _01_triggermodel01_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000064}, state: 1);
                context.SetActor(triggerId: 11, visible: true, initialSequence: "Closed");
                context.SetEffect(triggerIds: new []{202}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000064}, arg2: 0)) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 11, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.SetEffect(triggerIds: new []{202}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMonsterCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterCombat : TriggerState {
            internal StateMonsterCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{102})) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{102})) {
                    context.ResetTimer(timerId: "1");
                }

                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new StateWaitDestroy(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDestroy : TriggerState {
            internal StateWaitDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateTriggerReset(context);
                }

                if (context.MonsterInCombat(spawnIds: new []{102})) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetTimer(timerId: "2", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "2");
            }
        }
    }
}
