namespace Maple2.Trigger._99999840 {
    public static class _badmob_message {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 911) == true) {
                    return new State쫄몹1(context);
                }

                if (context.GetDungeonVariable(id: 912) == true) {
                    return new State쫄몹2(context);
                }

                if (context.GetDungeonVariable(id: 913) == true) {
                    return new State쫄몹3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쫄몹1 : TriggerState {
            internal State쫄몹1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: @"방해쫄몹1이 생성되었습니다.\n모두 처치하기 전까지는 자원을 넣을 수 없습니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쫄몹2 : TriggerState {
            internal State쫄몹2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: @"방해쫄몹2가 생성되었습니다.\n모두 처치하기 전까지는 자원을 넣을 수 없습니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쫄몹3 : TriggerState {
            internal State쫄몹3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: @"방해쫄몹3이 생성되었습니다.\n모두 처치하기 전까지는 자원을 넣을 수 없습니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWait(context);
                }

                return null;
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
