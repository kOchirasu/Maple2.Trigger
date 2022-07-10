using System.Numerics;

namespace Maple2.Trigger._52100106_qd {
    public static class _52100106 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{91000880}, questStates: new byte[]{3})) {
                    return new State들킴(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{91000890}, questStates: new byte[]{2})) {
                    return new State들킴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들킴 : TriggerState {
            internal State들킴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(diffuseColor: new Vector3(41f, 21f, 18f), specularColor: new Vector3(130f, 130f, 130f));
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 211, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 212, visible: true, initialSequence: "sf_quest_light_A01_On");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
