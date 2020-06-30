using System;

namespace Maple2.Trigger._99999840 {
    public static class _team1_battle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 2, value: false);
                context.SetDungeonVariable(varID: 100, value: false);
                context.SetInteractObject(arg1: new int[] {10002178}, arg2: 1, arg3: false);
                context.StartCombineSpawn(groupId: new int[] {510}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {511}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {512}, isStart: "0");
                context.SetUserValue(triggerID: 99990001, key: "Team1Win", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Team1Battle", value: 1)) {
                    context.State = new State지역선택1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택1 : TriggerState {
            internal State지역선택1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ScoreBoardCreate(maxScore: 240);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateA지역1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new StateB지역1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateC지역1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA지역1 : TriggerState {
            internal StateA지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {510}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 100)) {
                    context.State = new State지역선택2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB지역1 : TriggerState {
            internal StateB지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {511}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 100)) {
                    context.State = new State지역선택2_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC지역1 : TriggerState {
            internal StateC지역1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {512}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 100)) {
                    context.State = new State지역선택2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택2_1 : TriggerState {
            internal State지역선택2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: new int[] {4000}, arg4: "9101");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateB지역2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateC지역2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택2_2 : TriggerState {
            internal State지역선택2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: new int[] {4000}, arg4: "9101");
                context.SetTimer(arg1: "2", arg2: 60, arg3: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateA지역2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateC지역2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택2_3 : TriggerState {
            internal State지역선택2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: new int[] {4000}, arg4: "9101");
                context.SetTimer(arg1: "2", arg2: 60, arg3: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateA지역2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateB지역2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA지역2 : TriggerState {
            internal StateA지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {510}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 240)) {
                    context.ScoreBoardRemove();
                    context.State = new State지역선택3_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB지역2 : TriggerState {
            internal StateB지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {511}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 240)) {
                    context.ScoreBoardRemove();
                    context.State = new State지역선택3_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC지역2 : TriggerState {
            internal StateC지역2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {512}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 240)) {
                    context.ScoreBoardRemove();
                    context.State = new State지역선택3_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택3_1 : TriggerState {
            internal State지역선택3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 1000, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateB지역3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateC지역3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택3_2 : TriggerState {
            internal State지역선택3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 1000, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateA지역3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateC지역3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택3_3 : TriggerState {
            internal State지역선택3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 1000, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateA지역3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateB지역3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA지역3 : TriggerState {
            internal StateA지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {510}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB지역3 : TriggerState {
            internal StateB지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {511}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC지역3 : TriggerState {
            internal StateC지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {512}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002178}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_보스전 : TriggerState {
            internal State시작_보스전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002175}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002176}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002177}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002178}, arg2: 0, arg3: false);
                context.StartCombineSpawn(groupId: new int[] {510}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {511}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {512}, isStart: "0");
                context.CreateMonster(arg1: new int[] {901}, arg2: false);
                context.SetDungeonVariable(varID: 100, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {901})) {
                    context.State = new State성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 2, value: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002175}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002176}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002177}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002178}, arg2: 0, arg3: false);
                context.StartCombineSpawn(groupId: new int[] {510}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {511}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {512}, isStart: "0");
                context.DestroyMonster(arg1: new int[] {901});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}