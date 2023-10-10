namespace Maple2.Trigger._99999907 {
    public static class _12000011 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000011}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new State반응Wait(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000011}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000011}, arg2: 0)) {
                    return new StateRandomBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomBuff : TriggerState {
            internal StateRandomBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000008, level: 1, arg4: false, arg5: false);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000008, level: 1, arg4: false, arg5: false);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 40)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000008, level: 1, arg4: false, arg5: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
