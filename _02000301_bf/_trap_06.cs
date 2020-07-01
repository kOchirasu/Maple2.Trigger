namespace Maple2.Trigger._02000301_bf {
    public static class _trap_06 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 212, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 213, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new[] {10000514}, arg2: 1);
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetEffect(arg1: new[] {610}, arg2: false);
                context.SetMesh(arg1: new[] {3061, 3062, 3063, 3064, 3065, 3066}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {4601, 4602, 4603, 4604, 4605, 4606, 4607, 4608, 4609, 4610, 4611, 4612, 4613, 4614},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10601})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10602})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10603})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10604})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10605})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000514}, arg2: 0)) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 212, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 213, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new[] {10000514}, arg2: 0);
                context.CreateMonster(arg1: new[] {2007}, arg2: false);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetEffect(arg1: new[] {610}, arg2: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new[] {3061, 3062, 3063, 3064, 3065, 3066}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {4601, 4602, 4603, 4604, 4605, 4606, 4607, 4608, 4609, 4610, 4611, 4612, 4613, 4614},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2007})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetActor(arg1: 212, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 213, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2007});
                context.SetMesh(arg1: new[] {3061, 3062, 3063, 3064, 3065, 3066}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetMesh(
                    arg1: new[]
                        {4601, 4602, 4603, 4604, 4605, 4606, 4607, 4608, 4609, 4610, 4611, 4612, 4613, 4614},
                    arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}