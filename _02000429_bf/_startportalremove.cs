namespace Maple2.Trigger._02000429_bf {
    public static class _startportalremove {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new State시작지점포탈_우선생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작지점포탈_우선생성 : TriggerState {
            internal State시작지점포탈_우선생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 40000)) {
                    return new State시작지점포탈제거_직전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작지점포탈제거_직전 : TriggerState {
            internal State시작지점포탈제거_직전(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 770) == 1) {
                    return new State시작지점포탈_제거알림메시지생성(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new State시작지점포탈제거_실행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작지점포탈_제거알림메시지생성 : TriggerState {
            internal State시작지점포탈_제거알림메시지생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000428_BF__BARRICADE__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State시작지점포탈제거_실행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작지점포탈제거_실행 : TriggerState {
            internal State시작지점포탈제거_실행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}