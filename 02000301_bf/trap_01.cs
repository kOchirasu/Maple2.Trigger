namespace Maple2.Trigger._02000301_bf {
    public static class _trap_01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetInteractObject(interactIds: new []{10000511}, state: 1);
                context.SetEffect(triggerIds: new []{603, 604, 605, 610}, visible: false);
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4101, 4102, 4103, 4104}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000511}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetInteractObject(interactIds: new []{10000511}, state: 0);
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
                context.SetEffect(triggerIds: new []{603, 604, 605, 610}, visible: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4101, 4102, 4103, 4104}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2002});
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{4101, 4102, 4103, 4104}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
