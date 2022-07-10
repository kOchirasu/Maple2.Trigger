namespace Maple2.Trigger._02000252_bf {
    public static class _door_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{169, 170}, visible: true);
                context.SetEffect(triggerIds: new []{8031, 8032}, visible: true);
                context.SetInteractObject(interactIds: new []{10000401}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000401}, arg2: 0)) {
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
                context.SetEffect(triggerIds: new []{8031, 8032}, visible: false);
                context.SetMesh(triggerIds: new []{169, 170}, visible: false);
                context.CreateMonster(spawnIds: new []{1012}, arg2: true);
                context.SetConversation(type: 1, spawnId: 1012, script: "$02000252_BF__DOOR_01__0$", arg4: 2);
                context.MoveNpc(spawnId: 1012, patrolName: "MS2PatrolData_3");
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
                context.DestroyMonster(spawnIds: new []{1012});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
