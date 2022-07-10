namespace Maple2.Trigger._02000047_bf {
    public static class _02_mob {
        public class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000078}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000078}, arg2: 0)) {
                    return new StateMonster리젠(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster리젠 : TriggerState {
            internal StateMonster리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102});
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State우레우스대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우레우스대사 : TriggerState {
            internal State우레우스대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000047_BF__02_MOB__0$", arg4: 3);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000047_BF__02_MOB__1$", arg4: 3);
                context.SetTimer(timerId: "1", seconds: 3);
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
                    return new State우레우스소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우레우스소멸 : TriggerState {
            internal State우레우스소멸(ITriggerContext context) : base(context) { }

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
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateTriggerReset(context);
                }

                if (context.MonsterInCombat(spawnIds: new []{102})) {
                    return new State우레우스소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{102})) {
                    return new State우레우스소멸(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{102})) {
                    context.DestroyMonster(spawnIds: new []{102});
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
