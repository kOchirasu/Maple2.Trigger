namespace Maple2.Trigger._02000301_bf {
    public static class _trap_09 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 218, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 219, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new[] {10000516}, arg2: 1);
                context.SetEffect(arg1: new[] {609, 604, 610}, arg2: false);
                context.SetMesh(arg1: new[] {3091, 3092, 3093, 3094, 3095, 3096}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916, 4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {109})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10901})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10902})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10903})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10904})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10905})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10906})) {
                    return new State경보(context);
                }

                if (context.UserDetected(arg1: new[] {10907})) {
                    return new State경보(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000516}, arg2: 0)) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 218, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 219, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new[] {10000516}, arg2: 0);
                context.CreateMonster(arg1: new[] {2010}, arg2: false);
                context.SetEffect(arg1: new[] {609, 604, 610}, arg2: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new[] {3091, 3092, 3093, 3094, 3095, 3096}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916, 4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2010})) {
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetActor(arg1: 218, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 219, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2010});
                context.SetMesh(arg1: new[] {3091, 3092, 3093, 3094, 3095, 3096}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916, 4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}