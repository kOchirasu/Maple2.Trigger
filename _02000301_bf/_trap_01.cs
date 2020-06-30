using System;

namespace Maple2.Trigger._02000301_bf {
    public static class _trap_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new int[] {10000511}, arg2: 1);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetMesh(arg1: new int[] {3011, 3012, 3013, 3014, 3015, 3016}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {4101, 4102, 4103, 4104}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000511}, arg2: 0)) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new int[] {10000511}, arg2: 0);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: true);
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetEffect(arg1: new int[] {605}, arg2: true);
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.ShowGuideSummary(entityID: 20003001, textID: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new int[] {3011, 3012, 3013, 3014, 3015, 3016}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {4101, 4102, 4103, 4104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2002})) {
                    context.HideGuideSummary(entityID: 20003001);
                    context.SetEffect(arg1: new int[] {610}, arg2: false);
                    context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2002});
                context.SetMesh(arg1: new int[] {3011, 3012, 3013, 3014, 3015, 3016}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetMesh(arg1: new int[] {4101, 4102, 4103, 4104}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}