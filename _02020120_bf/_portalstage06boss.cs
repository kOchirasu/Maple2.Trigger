namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage06boss {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage06", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStage6_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_시작 : TriggerState {
            internal StateStage6_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Stage06") == 11) {
                    return new StateStage6_왼쪽_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage06") == 21) {
                    return new StateStage6_가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage06") == 31) {
                    return new StateStage6_오른쪽_가운데진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_왼쪽_가운데진행 : TriggerState {
            internal StateStage6_왼쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6101, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_가운데_가운데진행 : TriggerState {
            internal StateStage6_가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6201, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_오른쪽_가운데진행 : TriggerState {
            internal StateStage6_오른쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6303, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6304, arg2: true, arg3: true, arg4: true);
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