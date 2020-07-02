namespace Maple2.Trigger._02020141_bf {
    public static class _interactmesh10014109 {
        public class State최초시작 : TriggerState {
            internal State최초시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003152}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State탈것_Appear대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_Appear대기 : TriggerState {
            internal State탈것_Appear대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈것_SpawnCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_SpawnCinematic : TriggerState {
            internal State탈것_SpawnCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {914109}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State탈것_Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_Appear : TriggerState {
            internal State탈것_Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003152}, arg2: 1);
                context.DestroyMonster(arg1: new[] {914109});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003152}, arg2: 0)) {
                    return new State인터렉트_동작중(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작중 : TriggerState {
            internal State인터렉트_동작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003152}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State탈것_Appear대기(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003152}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}