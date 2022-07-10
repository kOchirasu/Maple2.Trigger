namespace Maple2.Trigger._52010059_qd {
    public static class _52010059 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 507, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 508, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 509, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 510, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 511, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 512, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 513, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 514, visible: true, initialSequence: "sf_quest_light_A01_Off");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
