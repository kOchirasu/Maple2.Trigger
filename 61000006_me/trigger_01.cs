namespace Maple2.Trigger._61000006_me {
    public static class _trigger_01 {
        public class StateLever : TriggerState {
            internal StateLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000223, 10000214}, arg2: 1);
                context.SetMesh(arg1: new[] {307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000223}, arg2: 0)) {
                    return new State다리01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리01 : TriggerState {
            internal State다리01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetMesh(arg1: new[] {307, 308}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State다리02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리02 : TriggerState {
            internal State다리02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 1);
                context.SetMesh(arg1: new[] {309, 310, 311}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State다리03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리03 : TriggerState {
            internal State다리03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 1);
                context.SetMesh(arg1: new[] {312, 313, 314}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State다리04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리04 : TriggerState {
            internal State다리04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "4", arg2: 1);
                context.SetMesh(arg1: new[] {315, 316, 317}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State다리05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리05 : TriggerState {
            internal State다리05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 1);
                context.SetMesh(arg1: new[] {318, 319}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State다리06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리06 : TriggerState {
            internal State다리06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "6", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new StateLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}