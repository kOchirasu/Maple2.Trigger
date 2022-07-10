namespace Maple2.Trigger._02000081_in {
    public static class _trigger_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000384}, state: 1);
                context.DestroyMonster(spawnIds: new []{201});
                context.SetMesh(triggerIds: new []{101, 102, 103, 104}, visible: false);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Opened");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000384}, arg2: 0)) {
                    return new State닫히기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닫히기 : TriggerState {
            internal State닫히기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101, 102, 103, 104}, visible: true);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Closed");
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State토무Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무Spawn : TriggerState {
            internal State토무Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 402, spawnIds: new []{202})) {
                    return new State토무대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무대사 : TriggerState {
            internal State토무대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$02000081_IN__TRIGGER_01__0$", arg4: 4);
                context.SetTimer(timerId: "1", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State토무Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무Script2 : TriggerState {
            internal State토무Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$02000081_IN__TRIGGER_01__1$", arg4: 4);
                context.SetTimer(timerId: "1", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State토무Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무Script3 : TriggerState {
            internal State토무Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$02000081_IN__TRIGGER_01__2$", arg4: 2);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State변신(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State변신 : TriggerState {
            internal State변신(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{101, 102, 103, 104}, visible: false);
            }

            public override TriggerState? Execute() {
                return new StateMonsterCombat(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterCombat : TriggerState {
            internal StateMonsterCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new StateWait(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{201})) {
                    return new State토무소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무소멸 : TriggerState {
            internal State토무소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{201})) {
                    context.ResetTimer(timerId: "1");
                }

                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new StateWait(context);
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

                if (context.MonsterInCombat(spawnIds: new []{201})) {
                    return new State토무소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{201})) {
                    return new State토무소멸(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{201})) {
                    context.DestroyMonster(spawnIds: new []{201});
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
