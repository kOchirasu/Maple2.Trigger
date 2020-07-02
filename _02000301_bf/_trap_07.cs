namespace Maple2.Trigger._02000301_bf {
    public static class _trap_07 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 214, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 215, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetEffect(arg1: new[] {601, 610}, arg2: false);
                context.CreateMonster(arg1: new[] {1005, 1103}, arg2: false);
                context.SetMesh(arg1: new[] {3071, 3072, 3073, 3074, 3075, 3076, 4701, 4702, 4703, 4704, 4705, 4706, 4707, 4708, 4709, 4710, 4711, 4712, 4713, 3077, 3078}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10701})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10702})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10703})) {
                    return new State경보(context);
                }

                if (context.MonsterDead(arg1: new[] {1103})) {
                    return new State경보(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 214, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 215, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetEffect(arg1: new[] {601, 610}, arg2: true);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006");
                context.CreateMonster(arg1: new[] {2008}, arg2: false);
                context.ShowGuideSummary(entityId: 20003002, textId: 20003002);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetConversation(arg1: 1, arg2: 1005, arg3: "$02000301_BF__TRAP_07__1$", arg4: 2);
                context.SetMesh(arg1: new[] {4701, 4702, 4703, 4704, 4705, 4706, 4707, 4708, 4709, 4710, 4711, 4712, 4713}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3077, 3078}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2008})) {
                    context.HideGuideSummary(entityId: 20003002);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetActor(arg1: 214, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 215, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2008})) {
                    context.SetMesh(arg1: new[] {3071, 3072, 3073, 3074, 3075, 3076}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.SetMesh(arg1: new[] {4701, 4702, 4703, 4704, 4705, 4706, 4707, 4708, 4709, 4710, 4711, 4712, 4713}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}