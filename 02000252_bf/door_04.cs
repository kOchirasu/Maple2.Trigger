namespace Maple2.Trigger._02000252_bf {
    public static class _door_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{175, 176}, visible: true);
                context.SetEffect(triggerIds: new []{8037, 8038}, visible: true);
                context.SetInteractObject(interactIds: new []{10000405}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000405}, arg2: 0)) {
                    return new State열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetMesh(triggerIds: new []{175, 176}, visible: false);
                context.SetEffect(triggerIds: new []{8037, 8038}, visible: false);
                context.CreateMonster(spawnIds: new []{1014}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1014, script: "$02000252_BF__DOOR_04__0$", arg4: 2);
                context.MoveNpc(spawnId: 1014, patrolName: "MS2PatrolData_6");
                context.CreateItem(spawnIds: new []{1022});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삭제 : TriggerState {
            internal State삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1014});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
