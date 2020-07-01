namespace Maple2.Trigger._02020141_bf {
    public static class _interactmesh10014109 {
        public class State최초시작 : TriggerState {
            internal State최초시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003152}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State탈것_등장대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_등장대기 : TriggerState {
            internal State탈것_등장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈것_등장연출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_등장연출 : TriggerState {
            internal State탈것_등장연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {914109}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State탈것_등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_등장 : TriggerState {
            internal State탈것_등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003152}, arg2: 1);
                context.DestroyMonster(arg1: new[] {914109});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003152}, arg2: 0)) {
                    return new State인터렉트_동작중(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new State종료(context);
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
                    return new State탈것_등장대기(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

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