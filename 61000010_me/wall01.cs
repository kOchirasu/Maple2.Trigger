namespace Maple2.Trigger._61000010_me {
    public static class _wall01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000042}, state: 1);
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000042}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCoolTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCoolTime : TriggerState {
            internal StateCoolTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
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
