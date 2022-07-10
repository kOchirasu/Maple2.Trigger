namespace Maple2.Trigger._99999840 {
    public static class _team1_battle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 2, value: false);
                context.SetDungeonVariable(varId: 100, value: false);
                context.SetInteractObject(interactIds: new []{10002178}, state: 1, arg3: false);
                context.StartCombineSpawn(groupId: new []{510}, isStart: false);
                context.StartCombineSpawn(groupId: new []{511}, isStart: false);
                context.StartCombineSpawn(groupId: new []{512}, isStart: false);
                context.SetUserValue(triggerId: 99990001, key: "Team1Win", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Team1Battle") == 1) {
                    return new State지역선택1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택1 : TriggerState {
            internal State지역선택1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ScoreBoardCreate(maxScore: 240);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new StateA지역1(context);
                }

                if (context.RandomCondition(rate: 34f)) {
                    return new StateB지역1(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new StateC지역1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역1 : TriggerState {
            internal StateA지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{510}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.GetScoreBoardScore() >= 100) {
                    return new State지역선택2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역1 : TriggerState {
            internal StateB지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{511}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.GetScoreBoardScore() >= 100) {
                    return new State지역선택2_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역1 : TriggerState {
            internal StateC지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{512}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.GetScoreBoardScore() >= 100) {
                    return new State지역선택2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택2_1 : TriggerState {
            internal State지역선택2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "추가 병력 Appear", duration: 4000, boxId: 9101);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateB지역2(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateC지역2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택2_2 : TriggerState {
            internal State지역선택2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "추가 병력 Appear", duration: 4000, boxId: 9101);
                context.SetTimer(timerId: "2", seconds: 60, clearAtZero: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateA지역2(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateC지역2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택2_3 : TriggerState {
            internal State지역선택2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "추가 병력 Appear", duration: 4000, boxId: 9101);
                context.SetTimer(timerId: "2", seconds: 60, clearAtZero: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateA지역2(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateB지역2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역2 : TriggerState {
            internal StateA지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{510}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.GetScoreBoardScore() >= 240) {
                    context.ScoreBoardRemove();
                    return new State지역선택3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역2 : TriggerState {
            internal StateB지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{511}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.GetScoreBoardScore() >= 240) {
                    context.ScoreBoardRemove();
                    return new State지역선택3_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역2 : TriggerState {
            internal StateC지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{512}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.GetScoreBoardScore() >= 240) {
                    context.ScoreBoardRemove();
                    return new State지역선택3_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택3_1 : TriggerState {
            internal State지역선택3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1000, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateB지역3(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateC지역3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택3_2 : TriggerState {
            internal State지역선택3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1000, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateA지역3(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateC지역3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택3_3 : TriggerState {
            internal State지역선택3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1000, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateA지역3(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateB지역3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역3 : TriggerState {
            internal StateA지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{510}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역3 : TriggerState {
            internal StateB지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{511}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역3 : TriggerState {
            internal StateC지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{512}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002178}, arg2: 0)) {
                    return new StateStart_Boss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_Boss : TriggerState {
            internal StateStart_Boss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002175}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002176}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002177}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002178}, state: 0, arg3: false);
                context.StartCombineSpawn(groupId: new []{510}, isStart: false);
                context.StartCombineSpawn(groupId: new []{511}, isStart: false);
                context.StartCombineSpawn(groupId: new []{512}, isStart: false);
                context.CreateMonster(spawnIds: new []{901}, arg2: false);
                context.SetDungeonVariable(varId: 100, value: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{901})) {
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 2, value: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002175}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002176}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002177}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002178}, state: 0, arg3: false);
                context.StartCombineSpawn(groupId: new []{510}, isStart: false);
                context.StartCombineSpawn(groupId: new []{511}, isStart: false);
                context.StartCombineSpawn(groupId: new []{512}, isStart: false);
                context.DestroyMonster(spawnIds: new []{901});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
