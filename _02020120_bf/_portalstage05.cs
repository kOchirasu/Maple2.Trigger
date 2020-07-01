namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage05 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage05", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State스테이지5_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_시작 : TriggerState {
            internal State스테이지5_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Stage05") == 11) {
                    return new State스테이지5_왼쪽_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 21) {
                    return new State스테이지5_왼쪽가운데_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 22) {
                    return new State스테이지5_왼쪽가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 31) {
                    return new State스테이지5_오른쪽가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 32) {
                    return new State스테이지5_오른쪽가운데_오른쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 41) {
                    return new State스테이지5_오른쪽_오른쪽진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_왼쪽_왼쪽진행 : TriggerState {
            internal State스테이지5_왼쪽_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5102, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_왼쪽가운데_왼쪽진행 : TriggerState {
            internal State스테이지5_왼쪽가운데_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5202, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5203, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_왼쪽가운데_가운데진행 : TriggerState {
            internal State스테이지5_왼쪽가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5204, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5205, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5206, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_오른쪽가운데_가운데진행 : TriggerState {
            internal State스테이지5_오른쪽가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5302, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_오른쪽가운데_오른쪽진행 : TriggerState {
            internal State스테이지5_오른쪽가운데_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5303, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5304, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스테이지5_오른쪽_오른쪽진행 : TriggerState {
            internal State스테이지5_오른쪽_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5401, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State혹시모를_던전리셋신호_대기 : TriggerState {
            internal State혹시모를_던전리셋신호_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}