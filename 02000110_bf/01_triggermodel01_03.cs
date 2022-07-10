namespace Maple2.Trigger._02000110_bf {
    public static class _01_triggermodel01_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000065}, state: 1);
                context.SetActor(triggerId: 12, visible: true, initialSequence: "Closed");
                context.SetEffect(triggerIds: new []{203}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000065}, arg2: 0)) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 12, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
                context.SetEffect(triggerIds: new []{203}, visible: true);
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
                if (context.MonsterDead(spawnIds: new []{103})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{103})) {
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
                if (context.MonsterInCombat(spawnIds: new []{103})) {
                    context.ResetTimer(timerId: "1");
                }

                if (context.MonsterDead(spawnIds: new []{103})) {
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

                if (context.MonsterInCombat(spawnIds: new []{103})) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103});
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
