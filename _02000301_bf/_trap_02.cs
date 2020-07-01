namespace Maple2.Trigger._02000301_bf {
    public static class _trap_02 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetEffect(arg1: new[] {601, 605, 610}, arg2: false);
                context.CreateMonster(arg1: new[] {1001, 1101}, arg2: false);
                context.SetMesh(arg1: new[] {3021, 3022, 3023, 3024, 3025, 3026, 4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212, 3027, 3028}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10201})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10202})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1101})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetEffect(arg1: new[] {601, 605, 610}, arg2: true);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002");
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
                context.ShowGuideSummary(entityId: 20003002, textId: 20003002);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000301_BF__TRAP_02__1$", arg4: 2);
                context.SetMesh(arg1: new[] {4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3027, 3028}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2003})) {
                    context.HideGuideSummary(entityId: 20003002);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2003})) {
                    context.SetMesh(arg1: new[] {3021, 3022, 3023, 3024, 3025, 3026}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.SetMesh(arg1: new[] {4201, 4202, 4203, 4204, 4205, 4206, 4207, 4208, 4209, 4210, 4211, 4212}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}