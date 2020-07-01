using System;

namespace Maple2.Trigger._02000329_bf {
    public static class _bossbattle_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000759}, arg2: 2);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 211, arg2: true, arg3: "Closed");
                context.CreateMonster(arg1: new int[] {1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018}, arg2: false);
                context.SetEffect(arg1: new int[] {6811}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {5001})) {
                    context.State = new State보스소환(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {5001, 5002})) {
                    context.State = new State닭장열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환 : TriggerState {
            internal State보스소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 109, textID: 20000070);
                context.SetSkip(arg1: "보스전투시작");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {5001, 5002})) {
                    context.State = new State닭장열기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State보스전투시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State보스전투시작 : TriggerState {
            internal State보스전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {5001, 5002})) {
                    context.State = new State닭장열기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 109);
            }
        }

        private class State닭장열기 : TriggerState {
            internal State닭장열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {611}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000759}, arg2: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 103, textID: 20000050);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000759}, arg2: 0)) {
                    context.State = new State보스전투끝(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 103);
            }
        }

        private class State보스전투끝 : TriggerState {
            internal State보스전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {6811}, arg2: true);
                context.SetTimer(arg1: "6", arg2: 6);
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetActor(arg1: 211, arg2: true, arg3: "Opened");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State닭장오픈(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 106, arg2: "trigger", arg3: "ClearSavetheChicken");
            }
        }

        private class State닭장오픈 : TriggerState {
            internal State닭장오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DungeonClear();
                context.MoveNpc(arg1: 1011, arg2: "MS2PatrolData_1010");
                context.MoveNpc(arg1: 1012, arg2: "MS2PatrolData_1009");
                context.MoveNpc(arg1: 1013, arg2: "MS2PatrolData_1008");
                context.MoveNpc(arg1: 1014, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 1015, arg2: "MS2PatrolData_1006");
                context.MoveNpc(arg1: 1016, arg2: "MS2PatrolData_1005");
                context.MoveNpc(arg1: 1017, arg2: "MS2PatrolData_1004");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}