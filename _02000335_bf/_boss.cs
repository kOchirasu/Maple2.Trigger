using System;

namespace Maple2.Trigger._02000335_bf {
    public static class _boss {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 991, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 992, isEnable: false);
                context.SetMesh(arg1: new int[] {6311, 6312, 6313, 6314, 6315}, arg2: true, arg4: 1, arg5: 1f);
                context.SetEffect(arg1: new int[] {6921}, arg2: false);
                context.CreateMonster(arg1: new int[] {149}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 710, arg2: 1)) {
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
                context.ShowGuideSummary(entityID: 105, textID: 20003361);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {149})) {
                    context.State = new State화물문_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 105);
            }
        }

        private class State화물문_개방 : TriggerState {
            internal State화물문_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 992, isEnable: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 106, textID: 20003362);
                context.SetMesh(arg1: new int[] {7991, 7992, 7993}, arg2: false, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State화물문_개방_종료(context);
                    return;
                }

                if (context.CountUsers(arg1: 711, arg2: 1)) {
                    context.State = new State보스등장연출_00(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 106);
            }
        }

        private class State화물문_개방_종료 : TriggerState {
            internal State화물문_개방_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 711, arg2: 1)) {
                    context.State = new State보스등장연출_00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출_00 : TriggerState {
            internal State보스등장연출_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000335_BF__BOSS__0$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {6921}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State보스등장연출_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출_01 : TriggerState {
            internal State보스등장연출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {141, 142, 143, 144, 145, 146, 147, 148});
                context.SetSkill(arg1: new int[] {5801}, arg2: true);
                context.SetSkill(arg1: new int[] {5802}, arg2: true);
                context.SetEffect(arg1: new int[] {6911}, arg2: true);
                context.SetEffect(arg1: new int[] {6912}, arg2: true);
                context.CreateMonster(arg1: new int[] {199}, arg2: false);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_1003");
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State보스등장연출_02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출_02 : TriggerState {
            internal State보스등장연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {5803}, arg2: true);
                context.SetSkill(arg1: new int[] {5804}, arg2: true);
                context.SetEffect(arg1: new int[] {6913}, arg2: true);
                context.SetEffect(arg1: new int[] {6914}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State보스등장연출_03(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출_03 : TriggerState {
            internal State보스등장연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {5805}, arg2: true);
                context.SetSkill(arg1: new int[] {5806}, arg2: true);
                context.SetEffect(arg1: new int[] {6915}, arg2: true);
                context.SetEffect(arg1: new int[] {6916}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new State포탈_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈_개방 : TriggerState {
            internal State포탈_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 112, textID: 40009);
                context.SetMesh(arg1: new int[] {6311, 6312, 6313, 6314, 6315}, arg2: false, arg4: 0, arg5: 10f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 112);
            }
        }
    }
}