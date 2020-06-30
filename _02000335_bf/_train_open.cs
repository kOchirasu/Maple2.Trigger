using System;

namespace Maple2.Trigger._02000335_bf {
    public static class _train_open {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6920}, arg2: false);
                context.SetMesh(arg1: new int[] {6091, 6092, 6093}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000786}, arg2: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 709, arg2: 1)) {
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
                if (context.ObjectInteracted(arg1: new int[] {10000786}, arg2: 0)) {
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
                context.SetEffect(arg1: new int[] {6922}, arg2: true);
                context.SetMesh(arg1: new int[] {6081, 6082, 6083}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new int[] {6091, 6092, 6093}, arg2: true, arg4: 300, arg5: 10f);
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
                context.SetMesh(arg1: new int[] {6099, 6076}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new int[] {6091, 6092, 6093}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new int[] {6000}, arg2: false, arg4: 50, arg5: 1f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벽제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽제거 : TriggerState {
            internal State벽제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6920}, arg2: true);
                context.SetSkill(arg1: new int[] {5807}, arg2: true);
                context.SetSkill(arg1: new int[] {5808}, arg2: true);
                context.SetSkill(arg1: new int[] {5809}, arg2: true);
                context.SetMesh(arg1: new int[] {7071, 7072, 7073, 7074}, arg2: false, arg4: 15, arg5: 8f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
                    context.State = new State몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {113}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State관문_01_조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_01_조건 : TriggerState {
            internal State관문_01_조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 105, textID: 20003361);
                context.CreateMonster(arg1: new int[] {115, 116, 137, 139}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {113})) {
                    context.State = new State관문_01_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 105);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 106, textID: 20003362);
                context.SetMesh(arg1: new int[] {6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218}, arg2: false, arg4: 0,
                    arg5: 10f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State관문_01_개방_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 106);
            }
        }

        private class State관문_01_개방_02 : TriggerState {
            internal State관문_01_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}