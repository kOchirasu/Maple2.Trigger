using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _train_open {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {16014, 16015, 16016}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000805}, arg2: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 706, arg2: 1)) {
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
                context.ShowGuideSummary(entityID: 113, textID: 20003363);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000805}, arg2: 0)) {
                    context.State = new State작동_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 113);
            }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {16011, 16012, 16013}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new int[] {16014, 16015, 16016}, arg2: true, arg4: 300, arg5: 10f);
                context.SetEffect(arg1: new int[] {7013}, arg2: true);
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
                context.SetSkill(arg1: new int[] {5802}, arg2: true);
                context.SetMesh(arg1: new int[] {16001}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new int[] {16014, 16015, 16016}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new int[] {16000}, arg2: false, arg4: 50, arg5: 1f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new State작동_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_03 : TriggerState {
            internal State작동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {305, 306, 307, 308}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}