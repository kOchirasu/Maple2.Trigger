namespace Maple2.Trigger._99999840 {
    public static class _boss_message {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 200) == true) {
                    context.State = new State메시지1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지1 : TriggerState {
            internal State메시지1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "B팀의 보스가 등장했습니다!", arg3: 4000);
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

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}