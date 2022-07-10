namespace Maple2.Trigger._02000301_bf {
    public static class _trap_08 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 216, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 217, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetInteractObject(interactIds: new []{10000515}, state: 1);
                context.SetEffect(triggerIds: new []{608, 604, 610}, visible: false);
                context.SetMesh(triggerIds: new []{3081, 3082, 3083, 3084, 3085, 3086}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4801, 4802, 4803, 4804, 4805, 4806, 4807, 4808, 4809, 4810, 4811, 4812, 4813, 4814, 4815, 4816, 4817, 4818}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{108})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10801})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10802})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10803})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10804})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10805})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10806})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000515}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 216, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 217, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetInteractObject(interactIds: new []{10000515}, state: 0);
                context.CreateMonster(spawnIds: new []{2009}, arg2: false);
                context.SetEffect(triggerIds: new []{608, 604, 610}, visible: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetMesh(triggerIds: new []{3081, 3082, 3083, 3084, 3085, 3086}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4801, 4802, 4803, 4804, 4805, 4806, 4807, 4808, 4809, 4810, 4811, 4812, 4813, 4814, 4815, 4816, 4817, 4818}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2009})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 216, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 217, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2009});
                context.SetMesh(triggerIds: new []{3081, 3082, 3083, 3084, 3085, 3086}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{4801, 4802, 4803, 4804, 4805, 4806, 4807, 4808, 4809, 4810, 4811, 4812, 4813, 4814, 4815, 4816, 4817, 4818}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
