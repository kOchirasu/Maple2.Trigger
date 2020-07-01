namespace Maple2.Trigger._52010059_qd {
    public static class _52010059 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204}, arg2: false);
                context.SetActor(arg1: 501, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 502, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 503, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 504, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 505, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 506, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 507, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 508, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 509, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 510, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 511, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 512, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 513, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 514, arg2: true, arg3: "sf_quest_light_A01_Off");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}