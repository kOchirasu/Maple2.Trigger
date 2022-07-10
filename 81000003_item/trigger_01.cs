namespace Maple2.Trigger._81000003_item {
    public static class _trigger_01 {
        public class StateLever : TriggerState {
            internal StateLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000223, 10000214}, state: 1);
                context.SetMesh(triggerIds: new []{307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000223}, arg2: 0)) {
                    return new State다리01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리01 : TriggerState {
            internal State다리01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetMesh(triggerIds: new []{307, 308}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State다리02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리02 : TriggerState {
            internal State다리02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
                context.SetMesh(triggerIds: new []{309, 310, 311}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State다리03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리03 : TriggerState {
            internal State다리03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 1);
                context.SetMesh(triggerIds: new []{312, 313, 314}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State다리04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리04 : TriggerState {
            internal State다리04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 1);
                context.SetMesh(triggerIds: new []{315, 316, 317}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State다리05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리05 : TriggerState {
            internal State다리05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 1);
                context.SetMesh(triggerIds: new []{318, 319}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State다리06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리06 : TriggerState {
            internal State다리06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
