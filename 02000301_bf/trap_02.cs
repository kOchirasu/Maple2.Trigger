namespace Maple2.Trigger._02000301_bf {
    public static class _trap_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetEffect(triggerIds: new []{601, 605, 610}, visible: false);
                context.CreateMonster(spawnIds: new []{1001, 1101}, arg2: false);
                context.SetMesh(triggerIds: new []{3021, 3022, 3023, 3024, 3025, 3026, 4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212, 3027, 3028}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10201})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10202})) {
                    return new State경보(context);
                }

                if (context.MonsterDead(spawnIds: new []{1101})) {
                    return new State경보(context);
                }

                if (context.MonsterDead(spawnIds: new []{1001})) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetEffect(triggerIds: new []{601, 605, 610}, visible: true);
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002");
                context.CreateMonster(spawnIds: new []{2003}, arg2: false);
                context.ShowGuideSummary(entityId: 20003002, textId: 20003002);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetConversation(type: 1, spawnId: 1001, script: "$02000301_BF__TRAP_02__1$", arg4: 2);
                context.SetMesh(triggerIds: new []{4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3027, 3028}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    context.HideGuideSummary(entityId: 20003002);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    context.SetMesh(triggerIds: new []{3021, 3022, 3023, 3024, 3025, 3026}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.SetMesh(triggerIds: new []{4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
