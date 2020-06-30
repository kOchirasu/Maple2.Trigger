using System;

namespace Maple2.Trigger._02000301_bf {
    public static class _trap_08 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 216, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 217, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new int[] {10000515}, arg2: 1);
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetMesh(arg1: new int[] {3081, 3082, 3083, 3084, 3085, 3086}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        4801, 4802, 4803, 4804, 4805, 4806, 4807, 4808, 4809, 4810, 4811, 4812, 4813, 4814, 4815, 4816,
                        4817, 4818
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "108")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10801")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10802")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10803")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10804")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10805")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: "10806")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000515}, arg2: 0)) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 216, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 217, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new int[] {10000515}, arg2: 0);
                context.CreateMonster(arg1: new int[] {2009}, arg2: false);
                context.SetEffect(arg1: new int[] {608}, arg2: true);
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.ShowGuideSummary(entityID: 20003001, textID: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new int[] {3081, 3082, 3083, 3084, 3085, 3086}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        4801, 4802, 4803, 4804, 4805, 4806, 4807, 4808, 4809, 4810, 4811, 4812, 4813, 4814, 4815, 4816,
                        4817, 4818
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2009})) {
                    context.HideGuideSummary(entityID: 20003001);
                    context.SetEffect(arg1: new int[] {610}, arg2: false);
                    context.SetActor(arg1: 216, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 217, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2009});
                context.SetMesh(arg1: new int[] {3081, 3082, 3083, 3084, 3085, 3086}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetMesh(
                    arg1: new int[] {
                        4801, 4802, 4803, 4804, 4805, 4806, 4807, 4808, 4809, 4810, 4811, 4812, 4813, 4814, 4815, 4816,
                        4817, 4818
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}