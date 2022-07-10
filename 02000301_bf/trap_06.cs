namespace Maple2.Trigger._02000301_bf {
    public static class _trap_06 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 212, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 213, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetInteractObject(interactIds: new []{10000514}, state: 1);
                context.SetEffect(triggerIds: new []{607, 604, 610}, visible: false);
                context.SetMesh(triggerIds: new []{3061, 3062, 3063, 3064, 3065, 3066}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4601, 4602, 4603, 4604, 4605, 4606, 4607, 4608, 4609, 4610, 4611, 4612, 4613, 4614}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10601})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10602})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10603})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10604})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10605})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000514}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 212, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 213, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetInteractObject(interactIds: new []{10000514}, state: 0);
                context.CreateMonster(spawnIds: new []{2007}, arg2: false);
                context.SetEffect(triggerIds: new []{607, 604, 610}, visible: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetMesh(triggerIds: new []{3061, 3062, 3063, 3064, 3065, 3066}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4601, 4602, 4603, 4604, 4605, 4606, 4607, 4608, 4609, 4610, 4611, 4612, 4613, 4614}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2007})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 212, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 213, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2007});
                context.SetMesh(triggerIds: new []{3061, 3062, 3063, 3064, 3065, 3066}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{4601, 4602, 4603, 4604, 4605, 4606, 4607, 4608, 4609, 4610, 4611, 4612, 4613, 4614}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
