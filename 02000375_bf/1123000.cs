namespace Maple2.Trigger._02000375_bf {
    public static class _1123000 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3400}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_off");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SecondPhaseEnd") == 1) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3400}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
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
