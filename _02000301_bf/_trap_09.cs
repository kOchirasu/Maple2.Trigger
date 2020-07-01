using System;

namespace Maple2.Trigger._02000301_bf {
    public static class _trap_09 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 218, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 219, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new int[] {10000516}, arg2: 1);
                context.SetEffect(arg1: new int[] {609}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetMesh(arg1: new int[] {3091, 3092, 3093, 3094, 3095, 3096}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916,
                        4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {109})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10901})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10902})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10903})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10904})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10905})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10906})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {10907})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000516}, arg2: 0)) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 218, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 219, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new int[] {10000516}, arg2: 0);
                context.CreateMonster(arg1: new int[] {2010}, arg2: false);
                context.SetEffect(arg1: new int[] {609}, arg2: true);
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.ShowGuideSummary(entityID: 20003001, textID: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new int[] {3091, 3092, 3093, 3094, 3095, 3096}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916,
                        4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2010})) {
                    context.SetEffect(arg1: new int[] {610}, arg2: false);
                    context.HideGuideSummary(entityID: 20003001);
                    context.SetActor(arg1: 218, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 219, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2010});
                context.SetMesh(arg1: new int[] {3091, 3092, 3093, 3094, 3095, 3096}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetMesh(
                    arg1: new int[] {
                        4901, 4902, 4903, 4904, 4905, 4906, 4907, 4908, 4909, 4910, 4911, 4912, 4913, 4914, 4915, 4916,
                        4917, 4918, 4919, 4920, 4921, 4922, 4923, 4924, 4925, 4926, 4927, 4928, 4929
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}