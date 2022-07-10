namespace Maple2.Trigger._02000293_bf {
    public static class _door01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1001, visible: false, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999998})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1001, visible: false, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000523, 10000504}, arg2: 0)) {
                    return new StateTrigger02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02시작 : TriggerState {
            internal StateTrigger02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{2028}, arg2: true);
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
                context.SetActor(triggerId: 1001, visible: false, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
