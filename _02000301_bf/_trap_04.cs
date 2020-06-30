using System;

namespace Maple2.Trigger._02000301_bf {
    public static class _trap_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 209, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.SetMesh(arg1: new int[] {3041, 3042, 3043, 3044, 3045, 3046}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {4401, 4402, 4403, 4404, 4405, 4406, 4407, 4408, 4409, 4410, 4411, 4412, 4413, 4414},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3047, 3048}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "104")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10401")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10402")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1102})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1003})) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 209, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004");
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
                context.ShowGuideSummary(entityID: 20003002, textID: 20003002);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000301_BF__TRAP_04__1$", arg4: 2);
                context.SetMesh(
                    arg1: new int[]
                        {4401, 4402, 4403, 4404, 4405, 4406, 4407, 4408, 4409, 4410, 4411, 4412, 4413, 4414},
                    arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new int[] {3047, 3048}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2005})) {
                    context.HideGuideSummary(entityID: 20003002);
                    context.SetEffect(arg1: new int[] {610}, arg2: false);
                    context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 209, arg2: true, arg3: "sf_quest_light_A01_Off");
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
                if (context.MonsterDead(arg1: new int[] {2005})) {
                    context.SetMesh(arg1: new int[] {3041, 3042, 3043, 3044, 3045, 3046}, arg2: false, arg3: 0, arg4: 0,
                        arg5: 5f);
                    context.SetMesh(
                        arg1: new int[]
                            {4401, 4402, 4403, 4404, 4405, 4406, 4407, 4408, 4409, 4410, 4411, 4412, 4413, 4414},
                        arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}