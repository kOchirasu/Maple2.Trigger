namespace Maple2.Trigger._02010026_bf {
    public static class _06_ladder14 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

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
                    return new StateLadderCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation01 : TriggerState {
            internal StateLadderCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 201, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation02 : TriggerState {
            internal StateLadderCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 202, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation03 : TriggerState {
            internal StateLadderCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 203, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation04 : TriggerState {
            internal StateLadderCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 204, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation05 : TriggerState {
            internal StateLadderCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 205, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation06 : TriggerState {
            internal StateLadderCreation06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 206, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateLadderCreation07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation07 : TriggerState {
            internal StateLadderCreation07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 207, arg2: true, arg3: true, arg4: 5);
                context.SetTimer(arg1: "1", arg2: 10, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}