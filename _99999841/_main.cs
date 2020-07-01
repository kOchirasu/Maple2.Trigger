namespace Maple2.Trigger._99999841 {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1, value: false);
                context.SetUserValue(triggerId: 99990002, key: "Team2Battle", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990015, key: "Start", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) == 3) {
                    return new State세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세팅 : TriggerState {
            internal State세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "잠시 후 경기가 시작됩니다.", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1, value: true);
                context.SetEventUI(arg1: 1, arg2: @"경기 시작!\n당신은 B팀입니다.", arg3: 3000);
                context.SetUserValue(triggerId: 99990002, key: "Team2Battle", value: 1);
                context.SetUserValue(triggerId: 99990003, key: "Start", value: 1);
                context.SetUserValue(triggerId: 99990004, key: "Start", value: 1);
                context.SetUserValue(triggerId: 99990005, key: "Start", value: 1);
                context.SetUserValue(triggerId: 99990015, key: "Start", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메시지1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지1 : TriggerState {
            internal State메시지1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"검은 군단을 해치우고 자원을 획득하세요.\n획득한 자원을 20개 모아서 보스를 불러내세요.\n한번에 최대 9개의 자원을 들 수 있습니다.", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateA팀승리(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateB팀승리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA팀승리 : TriggerState {
            internal StateA팀승리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "A팀이 승리했습니다!", arg3: 4000);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class StateB팀승리 : TriggerState {
            internal StateB팀승리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "B팀이 승리했습니다!", arg3: 4000);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Team2Battle", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Start", value: 0);
                context.SetInteractObject(arg1: new[] {10002179}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002180}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002181}, arg2: 0, arg3: false);
                context.SetInteractObject(arg1: new[] {10002182}, arg2: 0, arg3: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}