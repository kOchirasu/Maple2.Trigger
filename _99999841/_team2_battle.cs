using System;

namespace Maple2.Trigger._99999841 {
    public static class _team2_battle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 3, value: false);
                context.SetDungeonVariable(varID: 200, value: false);
                context.SetInteractObject(arg1: new int[] {10002182}, arg2: 1, arg3: false);
                context.StartCombineSpawn(groupId: new int[] {513}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {514}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {515}, isStart: "0");
                context.SetUserValue(triggerID: 99990001, key: "Team2Win", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Team2Battle", value: 1)) {
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
                if (context.DungeonVariable(varID: 2, value: true)) {
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
                context.StartCombineSpawn(groupId: new int[] {513}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.StartCombineSpawn(groupId: new int[] {514}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.StartCombineSpawn(groupId: new int[] {515}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }

                if (context.ScoreBoardCompare(compareOp: "GreaterEqual", score: 100)) {
                    context.State = new State지역선택2_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역선택2_1 : TriggerState {
            internal State지역선택2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: new int[] {4000}, arg4: "9201");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: new int[] {4000}, arg4: "9201");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.SetEventUI(arg1: 1, arg2: "추가 병력 등장", arg3: new int[] {4000}, arg4: "9201");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.StartCombineSpawn(groupId: new int[] {513}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.StartCombineSpawn(groupId: new int[] {514}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.StartCombineSpawn(groupId: new int[] {515}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.SetDungeonVariable(varID: 2000, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.SetDungeonVariable(varID: 2000, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.SetDungeonVariable(varID: 2000, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
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
                context.StartCombineSpawn(groupId: new int[] {513}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB지역3 : TriggerState {
            internal StateB지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {514}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC지역3 : TriggerState {
            internal StateC지역3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {515}, isStart: "1");
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002182}, arg2: 0)) {
                    context.State = new State시작_보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_보스전 : TriggerState {
            internal State시작_보스전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002179}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002180}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002181}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002182}, arg2: 0, arg3: false);
                context.StartCombineSpawn(groupId: new int[] {513}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {514}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {515}, isStart: "0");
                context.CreateMonster(arg1: new int[] {911}, arg2: false);
                context.SetDungeonVariable(varID: 200, value: true);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {911})) {
                    context.State = new State성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 3, value: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002179}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002180}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002181}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002182}, arg2: 0, arg3: false);
                context.StartCombineSpawn(groupId: new int[] {513}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {514}, isStart: "0");
                context.StartCombineSpawn(groupId: new int[] {515}, isStart: "0");
                context.DestroyMonster(arg1: new int[] {911});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}