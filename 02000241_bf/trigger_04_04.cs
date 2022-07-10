namespace Maple2.Trigger._02000241_bf {
    public static class _trigger_04_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{307}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{707, 708}, visible: true);
                context.SetMesh(triggerIds: new []{309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324}, visible: false);
                context.SetActor(triggerId: 507, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 508, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 509, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 510, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 511, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 512, visible: true, initialSequence: "Closed");
                context.DestroyMonster(spawnIds: new []{607, 608, 609, 610, 611, 612});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{407})) {
                    return new State버튼눌림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{307}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 511, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 512, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{611, 612}, arg2: false);
                context.MoveNpc(spawnId: 611, patrolName: "MS2PatrolData_611");
                context.MoveNpc(spawnId: 612, patrolName: "MS2PatrolData_612");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
