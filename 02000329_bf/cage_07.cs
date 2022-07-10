namespace Maple2.Trigger._02000329_bf {
    public static class _cage_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6807}, visible: false);
                context.SetActor(triggerId: 207, visible: true, initialSequence: "Closed");
                context.CreateMonster(spawnIds: new []{1007, 1107}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1107})) {
                    return new State닭Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닭Creation : TriggerState {
            internal State닭Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 207, visible: true, initialSequence: "Opened");
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{607}, visible: false);
                context.SetEffect(triggerIds: new []{6807}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State닭이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닭이동 : TriggerState {
            internal State닭이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007");
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State닭소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닭소멸 : TriggerState {
            internal State닭소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1007});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
