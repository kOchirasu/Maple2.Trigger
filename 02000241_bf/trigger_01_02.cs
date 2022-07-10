namespace Maple2.Trigger._02000241_bf {
    public static class _trigger_01_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{701, 702}, visible: true);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "Closed");
                context.DestroyMonster(spawnIds: new []{601, 602, 603, 604, 605, 606});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{401})) {
                    return new State버튼눌림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{601, 602}, arg2: false);
                context.MoveNpc(spawnId: 601, patrolName: "MS2PatrolData_601");
                context.MoveNpc(spawnId: 602, patrolName: "MS2PatrolData_602");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
