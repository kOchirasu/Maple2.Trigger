namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage06boss {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage06", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State스테이지6_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지6_시작 : TriggerState {
            internal State스테이지6_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Stage06") == 11) {
                    context.State = new State스테이지6_왼쪽_가운데진행(context);
                    return;
                }

                if (context.GetUserValue(key: "Stage06") == 21) {
                    context.State = new State스테이지6_가운데_가운데진행(context);
                    return;
                }

                if (context.GetUserValue(key: "Stage06") == 31) {
                    context.State = new State스테이지6_오른쪽_가운데진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지6_왼쪽_가운데진행 : TriggerState {
            internal State스테이지6_왼쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6101, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지6_가운데_가운데진행 : TriggerState {
            internal State스테이지6_가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6201, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지6_오른쪽_가운데진행 : TriggerState {
            internal State스테이지6_오른쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6303, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6304, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State혹시모를_던전리셋신호_대기 : TriggerState {
            internal State혹시모를_던전리셋신호_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}