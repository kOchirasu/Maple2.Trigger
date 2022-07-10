namespace Maple2.Trigger._99999841 {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1, value: false);
                context.SetUserValue(triggerId: 99990002, key: "Team2Battle", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990015, key: "Start", value: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "잠시 후 경기가 시작됩니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1, value: true);
                context.SetEventUI(arg1: 1, script: @"경기 시작!\n당신은 B팀입니다.", duration: 3000);
                context.SetUserValue(triggerId: 99990002, key: "Team2Battle", value: 1);
                context.SetUserValue(triggerId: 99990003, key: "Start", value: 1);
                context.SetUserValue(triggerId: 99990004, key: "Start", value: 1);
                context.SetUserValue(triggerId: 99990005, key: "Start", value: 1);
                context.SetUserValue(triggerId: 99990015, key: "Start", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: @"검은 군단을 해치우고 자원을 획득하세요.\n획득한 자원을 20개 모아서Boss를 불러내세요.\n한번에 최대 9개의 자원을 들 수 있습니다.", duration: 4000);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "A팀이 승리했습니다!", duration: 4000);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateB팀승리 : TriggerState {
            internal StateB팀승리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "B팀이 승리했습니다!", duration: 4000);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Team2Battle", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Start", value: 0);
                context.SetInteractObject(interactIds: new []{10002179}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002180}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002181}, state: 0, arg3: false);
                context.SetInteractObject(interactIds: new []{10002182}, state: 0, arg3: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
