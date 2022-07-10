namespace Maple2.Trigger._02000293_bf {
    public static class _door04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1008, visible: false, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999997})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1008, visible: false, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000530, 10000521}, arg2: 0)) {
                    return new StateTrigger02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02시작 : TriggerState {
            internal StateTrigger02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1008, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{2035}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateTrigger03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger03시작 : TriggerState {
            internal StateTrigger03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
                context.SetActor(triggerId: 1008, visible: false, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
