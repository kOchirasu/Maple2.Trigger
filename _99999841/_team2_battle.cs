namespace Maple2.Trigger._99999841 {
    public static class _team2_battle {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 3, value: false);
                context.SetDungeonVariable(varId: 200, value: false);
                context.SetInteractObject(arg1: new[] {10002182}, arg2: 1, arg3: false);
                context.StartCombineSpawn(groupId: new[] {513}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {514}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {515}, isStart: false);
                context.SetUserValue(triggerId: 99990001, key: "Team2Win", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Team2Battle") == 1) {
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

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateA지역1(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new StateB지역1(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateC지역1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역1 : TriggerState {
            internal StateA지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {513}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
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
                context.StartCombineSpawn(groupId: new[] {514}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
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
                context.StartCombineSpawn(groupId: new[] {515}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.GetScoreBoardScore() >= 100) {
                    return new State지역선택2_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택2_1 : TriggerState {
            internal State지역선택2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: 4000, arg4: "9201");
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateB지역2(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateC지역2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택2_2 : TriggerState {
            internal State지역선택2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: 4000, arg4: "9201");
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateA지역2(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateC지역2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택2_3 : TriggerState {
            internal State지역선택2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: 4000, arg4: "9201");
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateA지역2(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateB지역2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역2 : TriggerState {
            internal StateA지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {513}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
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
                context.StartCombineSpawn(groupId: new[] {514}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
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
                context.StartCombineSpawn(groupId: new[] {515}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
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
                context.SetDungeonVariable(varId: 2000, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateB지역3(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateC지역3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택3_2 : TriggerState {
            internal State지역선택3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 2000, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateA지역3(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateC지역3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역선택3_3 : TriggerState {
            internal State지역선택3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 2000, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateA지역3(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new StateB지역3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역3 : TriggerState {
            internal StateA지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {513}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역3 : TriggerState {
            internal StateB지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {514}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역3 : TriggerState {
            internal StateC지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {515}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002182}, arg2: 0)) {
                    return new State시작_보스전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작_보스전 : TriggerState {
            internal State시작_보스전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002179}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002180}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002181}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002182}, arg2: 0, arg3: false);
                context.StartCombineSpawn(groupId: new[] {513}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {514}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {515}, isStart: false);
                context.CreateMonster(arg1: new[] {911}, arg2: false);
                context.SetDungeonVariable(varId: 200, value: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {911})) {
                    return new State성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 3, value: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002179}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002180}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002181}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002182}, arg2: 0, arg3: false);
                context.StartCombineSpawn(groupId: new[] {513}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {514}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {515}, isStart: false);
                context.DestroyMonster(arg1: new[] {911});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}