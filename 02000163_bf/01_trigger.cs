namespace Maple2.Trigger._02000163_bf {
    public static class _01_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101});
                context.SetEffect(triggerIds: new []{201, 202, 203, 204}, visible: true);
                context.SetInteractObject(interactIds: new []{10000079}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000079}, arg2: 0)) {
                    context.DestroyMonster(spawnIds: new []{101});
                    context.SetEffect(triggerIds: new []{201, 202, 203, 204}, visible: false);
                    return new State매킨Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨Creation : TriggerState {
            internal State매킨Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102});
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State매킨대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨대사 : TriggerState {
            internal State매킨대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000163_BF__01_TRIGGER__0$", arg4: 3);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_102");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 301, spawnIds: new []{102})) {
                    return new State매킨이동302(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨이동302 : TriggerState {
            internal State매킨이동302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{201}, triggerId: 0, itemId: 10000079);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State매킨이동304(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨이동304 : TriggerState {
            internal State매킨이동304(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 304, spawnIds: new []{102})) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetTimer(timerId: "1", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
