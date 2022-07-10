namespace Maple2.Trigger._02020013_bf {
    public static class _100001_timeevent_triggervalue {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MelodyOn", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MelodyOn") == 1) {
                    return new StatePuzzleOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePuzzleOn : TriggerState {
            internal StatePuzzleOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MelodyOn", value: 0);
                context.SetUserValue(triggerId: 11000, key: "TimeEventOn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(context.GetUserValue(key: "TimeEventLifeTime"))) {
                    return new StatePuzzleOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePuzzleOff : TriggerState {
            internal StatePuzzleOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11000, key: "TimeEventOn", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
