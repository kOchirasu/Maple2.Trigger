namespace Maple2.Trigger._02010026_bf {
    public static class _06_ladder14 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000909}, arg2: 1);
                context.SetLadder(arg1: 201, arg2: false, arg3: false);
                context.SetLadder(arg1: 202, arg2: false, arg3: false);
                context.SetLadder(arg1: 203, arg2: false, arg3: false);
                context.SetLadder(arg1: 204, arg2: false, arg3: false);
                context.SetLadder(arg1: 205, arg2: false, arg3: false);
                context.SetLadder(arg1: 206, arg2: false, arg3: false);
                context.SetLadder(arg1: 207, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000909}, arg2: 0)) {
                    return new State사다리생성01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성01 : TriggerState {
            internal State사다리생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 201, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State사다리생성02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성02 : TriggerState {
            internal State사다리생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 202, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State사다리생성03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성03 : TriggerState {
            internal State사다리생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 203, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State사다리생성04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성04 : TriggerState {
            internal State사다리생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 204, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State사다리생성05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성05 : TriggerState {
            internal State사다리생성05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 205, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State사다리생성06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성06 : TriggerState {
            internal State사다리생성06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 206, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State사다리생성07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리생성07 : TriggerState {
            internal State사다리생성07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 207, arg2: true, arg3: true, arg4: 5);
                context.SetTimer(arg1: "1", arg2: 10, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}