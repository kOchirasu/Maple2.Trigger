namespace Maple2.Trigger._02000301_bf {
    public static class _trap_05 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 210, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 211, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetInteractObject(interactIds: new []{10000513}, state: 1);
                context.SetEffect(triggerIds: new []{606, 604, 610}, visible: false);
                context.SetMesh(triggerIds: new []{3051, 3052, 3053, 3054, 3055, 3056}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4501, 4502, 4503, 4504, 4505, 4506, 4507, 4508, 4509, 4510, 4511, 4512, 4513, 4514, 4515, 4516, 4517, 4518, 4519}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10501})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10502})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10503})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10504})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10505})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000513}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 210, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 211, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetInteractObject(interactIds: new []{10000513}, state: 0);
                context.CreateMonster(spawnIds: new []{2006}, arg2: false);
                context.SetEffect(triggerIds: new []{606, 604, 610}, visible: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetMesh(triggerIds: new []{3051, 3052, 3053, 3054, 3055, 3056}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4501, 4502, 4503, 4504, 4505, 4506, 4507, 4508, 4509, 4510, 4511, 4512, 4513, 4514, 4515, 4516, 4517, 4518, 4519}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2006})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 210, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 211, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2006});
                context.SetMesh(triggerIds: new []{3051, 3052, 3053, 3054, 3055, 3056}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{4501, 4502, 4503, 4504, 4505, 4506, 4507, 4508, 4509, 4510, 4511, 4512, 4513, 4514, 4515, 4516, 4517, 4518, 4519}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
