namespace Maple2.Trigger._02000329_bf {
    public static class _bossbattle_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {611}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000759}, arg2: 2);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 211, arg2: true, arg3: "Closed");
                context.CreateMonster(arg1: new[] {1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018}, arg2: false);
                context.SetEffect(arg1: new[] {6811}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {5001})) {
                    return new State보스소환(context);
                }

                if (context.MonsterDead(arg1: new[] {5001, 5002})) {
                    return new State닭장열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환 : TriggerState {
            internal State보스소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 109, textId: 20000070);
                context.SetSkip(arg1: "보스전투시작");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {5001, 5002})) {
                    return new State닭장열기(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State보스전투시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State보스전투시작 : TriggerState {
            internal State보스전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {5001, 5002})) {
                    return new State닭장열기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 109);
            }
        }

        private class State닭장열기 : TriggerState {
            internal State닭장열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {611}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000759}, arg2: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 103, textId: 20000050);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000759}, arg2: 0)) {
                    return new State보스전투끝(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 103);
            }
        }

        private class State보스전투끝 : TriggerState {
            internal State보스전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {611}, arg2: false);
                context.SetEffect(arg1: new[] {6811}, arg2: true);
                context.SetTimer(arg1: "6", arg2: 6);
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetActor(arg1: 211, arg2: true, arg3: "Opened");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State닭장오픈(context);
                }

                return null;
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}