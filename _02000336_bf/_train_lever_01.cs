using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8111, 8112, 8113, 8114}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000896}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000896}, arg2: 0)) {
                    context.State = new State작동_01(context);
                    return;
                }

                if (context.CountUsers(arg1: 708, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 113, textID: 20003363, duration: 3000);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000896}, arg2: 0)) {
                    context.State = new State작동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8111, 8112, 8113, 8114}, arg2: true, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new int[] {8101, 8102, 8103, 8104}, arg2: false, arg4: 300, arg5: 10f);
                context.SetEffect(arg1: new int[] {7010}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State작동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 106, textID: 20003362, duration: 3000);
                context.SetMesh(arg1: new int[] {8050, 8051, 8052, 8053, 8054}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new int[] {5806}, arg2: true);
                context.SetMesh(arg1: new int[] {8055}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new int[] {8111, 8112, 8113, 8114}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}