namespace Maple2.Trigger._02000301_bf {
    public static class _trap_07 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 214, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 215, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetEffect(triggerIds: new []{601, 610}, visible: false);
                context.CreateMonster(spawnIds: new []{1005, 1103}, arg2: false);
                context.SetMesh(triggerIds: new []{3071, 3072, 3073, 3074, 3075, 3076, 4701, 4702, 4703, 4704, 4705, 4706, 4707, 4708, 4709, 4710, 4711, 4712, 4713, 3077, 3078}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{107})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10701})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10702})) {
                    return new State경보(context);
                }

                if (context.UserDetected(boxIds: new []{10703})) {
                    return new State경보(context);
                }

                if (context.MonsterDead(spawnIds: new []{1103})) {
                    return new State경보(context);
                }

                if (context.MonsterDead(spawnIds: new []{1005})) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 214, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 215, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetEffect(triggerIds: new []{601, 610}, visible: true);
                context.CreateMonster(spawnIds: new []{1006}, arg2: false);
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_1006");
                context.CreateMonster(spawnIds: new []{2008}, arg2: false);
                context.ShowGuideSummary(entityId: 20003002, textId: 20003002);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetConversation(type: 1, spawnId: 1005, script: "$02000301_BF__TRAP_07__1$", arg4: 2);
                context.SetMesh(triggerIds: new []{4701, 4702, 4703, 4704, 4705, 4706, 4707, 4708, 4709, 4710, 4711, 4712, 4713}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3077, 3078}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2008})) {
                    context.HideGuideSummary(entityId: 20003002);
                    context.SetEffect(triggerIds: new []{610}, visible: false);
                    context.SetActor(triggerId: 214, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 215, visible: true, initialSequence: "sf_quest_light_A01_Off");
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
                if (context.MonsterDead(spawnIds: new []{2008})) {
                    context.SetMesh(triggerIds: new []{3071, 3072, 3073, 3074, 3075, 3076}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.SetMesh(triggerIds: new []{4701, 4702, 4703, 4704, 4705, 4706, 4707, 4708, 4709, 4710, 4711, 4712, 4713}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
