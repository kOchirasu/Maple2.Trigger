namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage04 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage04", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStage4_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_시작 : TriggerState {
            internal StateStage4_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Stage04") == 11) {
                    return new StateStage4_왼쪽_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage04") == 12) {
                    return new StateStage4_왼쪽_왼쪽가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage04") == 21) {
                    return new StateStage4_가운데_왼쪽가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage04") == 22) {
                    return new StateStage4_가운데_오른쪽가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage04") == 31) {
                    return new StateStage4_오른쪽_오른쪽가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage04") == 32) {
                    return new StateStage4_오른쪽_오른쪽진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_왼쪽_왼쪽진행 : TriggerState {
            internal StateStage4_왼쪽_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4101, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_왼쪽_왼쪽가운데진행 : TriggerState {
            internal StateStage4_왼쪽_왼쪽가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4102, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_가운데_왼쪽가운데진행 : TriggerState {
            internal StateStage4_가운데_왼쪽가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4201, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_가운데_오른쪽가운데진행 : TriggerState {
            internal StateStage4_가운데_오른쪽가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4202, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_오른쪽_오른쪽가운데진행 : TriggerState {
            internal StateStage4_오른쪽_오른쪽가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4301, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_오른쪽_오른쪽진행 : TriggerState {
            internal StateStage4_오른쪽_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4302, arg2: true, arg3: true, arg4: true);
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