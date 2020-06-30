using System;

namespace Maple2.Trigger._99999841 {
    public static class _debuffmob {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 811, value: false);
                context.SetDungeonVariable(varID: 812, value: false);
                context.SetDungeonVariable(varID: 813, value: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "Start", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 60);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State랜덤확률(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤확률 : TriggerState {
            internal State랜덤확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"디버프 몬스터가 생성되었습니다.\n몬스터를 처치하면 상대팀에 디버프를 겁니다.",
                    arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateA지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new StateB지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateC지역(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {801}, arg2: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {801})) {
                    context.SetEventUI(arg1: 1, arg2: "상대팀에 이동속도 감소 디버프를 겁니다.", arg3: new int[] {5000});
                    context.SetDungeonVariable(varID: 811, value: true);
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {802}, arg2: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {802})) {
                    context.SetEventUI(arg1: 1, arg2: "상대팀에 공격력 감소 디버프를 겁니다.", arg3: new int[] {5000});
                    context.SetDungeonVariable(varID: 812, value: true);
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {803}, arg2: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {803})) {
                    context.SetEventUI(arg1: 1, arg2: "상대팀에 체력 감소 디버프를 겁니다.", arg3: new int[] {5000});
                    context.SetDungeonVariable(varID: 813, value: true);
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.SetDungeonVariable(varID: 811, value: false);
                    context.SetDungeonVariable(varID: 812, value: false);
                    context.SetDungeonVariable(varID: 813, value: false);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}