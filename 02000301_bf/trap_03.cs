namespace Maple2.Trigger._02000301_bf {
    public static class _trap_03 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetInteractObject(interactIds: new []{10000512}, state: 1);
                context.SetEffect(triggerIds: new []{605, 601, 604, 610}, visible: false);
                context.SetMesh(triggerIds: new []{3031, 3032, 3033, 3034, 3035, 3036}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4301, 4302, 4303, 4304, 4305, 4306}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10301})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10302})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10303})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10304})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10305})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000512}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetInteractObject(interactIds: new []{10000512}, state: 0);
                context.CreateMonster(spawnIds: new []{2004}, arg2: false);
                context.SetEffect(triggerIds: new []{605, 601, 604, 610}, visible: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetMesh(triggerIds: new []{3031, 3032, 3033, 3034, 3035, 3036}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4301, 4302, 4303, 4304, 4305, 4306}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2004})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2004});
                context.SetMesh(triggerIds: new []{3031, 3032, 3033, 3034, 3035, 3036}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{4301, 4302, 4303, 4304, 4305, 4306}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
