using System;

namespace Maple2.Trigger._02020030_bf {
    public static class _100001_timeevent_triggervalue {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MelodyOn", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "MelodyOn", value: 1)) {
                    context.State = new StatePuzzleOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePuzzleOn : TriggerState {
            internal StatePuzzleOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MelodyOn", value: 0);
                context.SetUserValue(triggerID: 11000, key: "TimeEventOn", value: 1);
            }

            public override void Execute() {
                if (context.WaitSecondsUserValue(key: "TimeEventLifeTime")) {
                    context.State = new StatePuzzleOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePuzzleOff : TriggerState {
            internal StatePuzzleOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 11000, key: "TimeEventOn", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}