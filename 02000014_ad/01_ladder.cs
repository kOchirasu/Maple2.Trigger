namespace Maple2.Trigger._02000014_ad {
    public static class _01_ladder {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000066}, arg2: 1);
                context.SetEffect(arg1: new[] {201, 202, 211, 212, 221, 222, 231, 232, 241, 242}, arg2: false);
                context.SetLadder(arg1: 101, arg2: false, arg3: false);
                context.SetLadder(arg1: 102, arg2: false, arg3: false);
                context.SetLadder(arg1: 111, arg2: false, arg3: false);
                context.SetLadder(arg1: 112, arg2: false, arg3: false);
                context.SetLadder(arg1: 121, arg2: false, arg3: false);
                context.SetLadder(arg1: 122, arg2: false, arg3: false);
                context.SetLadder(arg1: 131, arg2: false, arg3: false);
                context.SetLadder(arg1: 132, arg2: false, arg3: false);
                context.SetLadder(arg1: 141, arg2: false, arg3: false);
                context.SetLadder(arg1: 142, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000066}, arg2: 0)) {
                    return new StateLadderCreation101(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation101 : TriggerState {
            internal StateLadderCreation101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {201, 202}, arg2: true);
                context.SetLadder(arg1: 101, arg2: true, arg3: true);
                context.SetLadder(arg1: 102, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation102(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation102 : TriggerState {
            internal StateLadderCreation102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {211, 212}, arg2: true);
                context.SetLadder(arg1: 111, arg2: true, arg3: true);
                context.SetLadder(arg1: 112, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation111(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation111 : TriggerState {
            internal StateLadderCreation111(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {221, 222}, arg2: true);
                context.SetLadder(arg1: 121, arg2: true, arg3: true);
                context.SetLadder(arg1: 122, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation112(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation112 : TriggerState {
            internal StateLadderCreation112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {231, 232}, arg2: true);
                context.SetLadder(arg1: 131, arg2: true, arg3: true);
                context.SetLadder(arg1: 132, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation121(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation121 : TriggerState {
            internal StateLadderCreation121(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {241, 242}, arg2: true);
                context.SetLadder(arg1: 141, arg2: true, arg3: true);
                context.SetLadder(arg1: 142, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation122 : TriggerState {
            internal StateLadderCreation122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 122, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation131(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation131 : TriggerState {
            internal StateLadderCreation131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 131, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation132(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation132 : TriggerState {
            internal StateLadderCreation132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 132, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation141(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation141 : TriggerState {
            internal StateLadderCreation141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 141, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateLadderCreation142(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation142 : TriggerState {
            internal StateLadderCreation142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 142, arg2: true, arg3: true);
                context.SetTimer(id: "1", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}