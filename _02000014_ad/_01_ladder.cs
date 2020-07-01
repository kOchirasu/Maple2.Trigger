namespace Maple2.Trigger._02000014_ad {
    public static class _01_ladder {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000066}, arg2: 0)) {
                    context.State = new State사다리생성101(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성101 : TriggerState {
            internal State사다리생성101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {201, 202}, arg2: true);
                context.SetLadder(arg1: 101, arg2: true, arg3: true);
                context.SetLadder(arg1: 102, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성102(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성102 : TriggerState {
            internal State사다리생성102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {211, 212}, arg2: true);
                context.SetLadder(arg1: 111, arg2: true, arg3: true);
                context.SetLadder(arg1: 112, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성111(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성111 : TriggerState {
            internal State사다리생성111(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {221, 222}, arg2: true);
                context.SetLadder(arg1: 121, arg2: true, arg3: true);
                context.SetLadder(arg1: 122, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성112(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성112 : TriggerState {
            internal State사다리생성112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {231, 232}, arg2: true);
                context.SetLadder(arg1: 131, arg2: true, arg3: true);
                context.SetLadder(arg1: 132, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성121(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성121 : TriggerState {
            internal State사다리생성121(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {241, 242}, arg2: true);
                context.SetLadder(arg1: 141, arg2: true, arg3: true);
                context.SetLadder(arg1: 142, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성122 : TriggerState {
            internal State사다리생성122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 122, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성131(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성131 : TriggerState {
            internal State사다리생성131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 131, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성132(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성132 : TriggerState {
            internal State사다리생성132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 132, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성141(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성141 : TriggerState {
            internal State사다리생성141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 141, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State사다리생성142(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성142 : TriggerState {
            internal State사다리생성142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 142, arg2: true, arg3: true);
                context.SetTimer(arg1: "1", arg2: 120);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}