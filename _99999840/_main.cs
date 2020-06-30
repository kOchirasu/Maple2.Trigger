using System;

namespace Maple2.Trigger._99999840 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990002, key: "Team1Battle", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "Start", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "Start", value: 0);
                context.SetUserValue(triggerID: 99990005, key: "Start", value: 0);
                context.SetUserValue(triggerID: 99990015, key: "Start", value: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9001, arg2: 6, arg3: "Equal")) {
                    context.State = new State세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세팅 : TriggerState {
            internal State세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 99999841, arg2: 1, arg3: 9001, arg4: 3);
                context.SetEventUI(arg1: 1, arg2: "잠시 후 경기가 시작됩니다.", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 1, value: true)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"경기 시작!\n당신은 A팀입니다.", arg3: new int[] {3000});
                context.SetUserValue(triggerID: 99990002, key: "Team1Battle", value: 1);
                context.SetUserValue(triggerID: 99990003, key: "Start", value: 1);
                context.SetUserValue(triggerID: 99990004, key: "Start", value: 1);
                context.SetUserValue(triggerID: 99990005, key: "Start", value: 1);
                context.SetUserValue(triggerID: 99990015, key: "Start", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State메시지1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지1 : TriggerState {
            internal State메시지1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1,
                    arg2: @"검은 군단을 해치우고 자원을 획득하세요.\n획득한 자원을 20개 모아서 보스를 불러내세요.\n한번에 최대 9개의 자원을 들 수 있습니다.",
                    arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 2, value: true)) {
                    context.State = new StateA팀승리(context);
                    return;
                }

                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new StateB팀승리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA팀승리 : TriggerState {
            internal StateA팀승리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "A팀이 승리했습니다!", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB팀승리 : TriggerState {
            internal StateB팀승리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "B팀이 승리했습니다!", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990002, key: "Team1Battle", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "Start", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "Start", value: 0);
                context.SetUserValue(triggerID: 99990005, key: "Start", value: 0);
                context.SetInteractObject(arg1: new int[] {10002175}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002176}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002177}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new int[] {10002178}, arg2: 0, arg3: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}