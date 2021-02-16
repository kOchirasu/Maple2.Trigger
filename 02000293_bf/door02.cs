namespace Maple2.Trigger._02000293_bf {
    public static class _door02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1002, arg2: false, arg3: "Closed");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {999998})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1002, arg2: false, arg3: "Closed");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000524, 10000505}, arg2: 0)) {
                    return new StateTrigger02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02시작 : TriggerState {
            internal StateTrigger02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1002, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {2029}, arg2: true);
                context.SetTimer(id: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateTrigger03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger03시작 : TriggerState {
            internal StateTrigger03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
                context.SetActor(arg1: 1002, arg2: false, arg3: "Closed");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}