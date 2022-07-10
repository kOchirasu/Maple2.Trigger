namespace Maple2.Trigger._99999840 {
    public static class _boss_hpcheck {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 210) == true) {
                    return new State메시지1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지1 : TriggerState {
            internal State메시지1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "B팀의Boss 체력이 70% 이하입니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 220) == true) {
                    return new State메시지2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지2 : TriggerState {
            internal State메시지2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "B팀의Boss 체력이 50% 이하입니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 230) == true) {
                    return new State메시지3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지3 : TriggerState {
            internal State메시지3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "B팀의Boss 체력이 30% 이하입니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 240) == true) {
                    return new State메시지4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지4 : TriggerState {
            internal State메시지4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "B팀의Boss 체력이 10% 이하입니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
