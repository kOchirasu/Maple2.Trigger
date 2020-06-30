using System;

namespace Maple2.Trigger._61000006_me {
    public static class _trigger_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레버(context);

        private class State레버 : TriggerState {
            internal State레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000223}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000214}, arg2: 1);
                context.SetMesh(arg1: new int[] {307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319},
                    arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000223}, arg2: 0)) {
                    context.State = new State다리01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리01 : TriggerState {
            internal State다리01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(arg1: new int[] {307, 308}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State다리02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리02 : TriggerState {
            internal State다리02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.SetMesh(arg1: new int[] {309, 310, 311}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State다리03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리03 : TriggerState {
            internal State다리03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetMesh(arg1: new int[] {312, 313, 314}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State다리04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리04 : TriggerState {
            internal State다리04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 1);
                context.SetMesh(arg1: new int[] {315, 316, 317}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State다리05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리05 : TriggerState {
            internal State다리05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
                context.SetMesh(arg1: new int[] {318, 319}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State다리06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리06 : TriggerState {
            internal State다리06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State레버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}