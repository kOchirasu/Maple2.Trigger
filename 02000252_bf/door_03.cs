namespace Maple2.Trigger._02000252_bf {
    public static class _door_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{173, 174}, visible: true);
                context.SetEffect(triggerIds: new []{8035, 8036}, visible: true);
                context.SetInteractObject(interactIds: new []{10000404}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000404}, arg2: 0)) {
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
                context.SetMesh(triggerIds: new []{173, 174}, visible: false);
                context.SetEffect(triggerIds: new []{8035, 8036}, visible: false);
                context.CreateMonster(spawnIds: new []{1013}, arg2: true);
                context.SetConversation(type: 1, spawnId: 1013, script: "$02000252_BF__DOOR_03__0$", arg4: 2);
                context.MoveNpc(spawnId: 1013, patrolName: "MS2PatrolData_6");
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
                context.DestroyMonster(spawnIds: new []{1013});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
