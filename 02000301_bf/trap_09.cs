namespace Maple2.Trigger._02000301_bf {
    public static class _trap_09 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 218, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 219, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetInteractObject(interactIds: new []{10000516}, state: 1);
                context.SetEffect(triggerIds: new []{609, 604, 610}, visible: false);
                context.SetMesh(triggerIds: new []{3091, 3092, 3093, 3094, 3095, 3096}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916, 4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{109})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10901})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10902})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10903})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10904})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10905})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10906})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10907})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000516}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 218, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 219, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetInteractObject(interactIds: new []{10000516}, state: 0);
                context.CreateMonster(spawnIds: new []{2010}, arg2: false);
                context.SetEffect(triggerIds: new []{609, 604, 610}, visible: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetMesh(triggerIds: new []{3091, 3092, 3093, 3094, 3095, 3096}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916, 4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2010})) {
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetActor(triggerId: 218, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 219, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2010});
                context.SetMesh(triggerIds: new []{3091, 3092, 3093, 3094, 3095, 3096}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916, 4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
