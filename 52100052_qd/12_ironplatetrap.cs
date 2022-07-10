namespace Maple2.Trigger._52100052_qd {
    public static class _12_ironplatetrap {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3430, 3431, 3432, 3433}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303}, visible: false);
                context.DestroyMonster(spawnIds: new []{203, 303});
                context.SetInteractObject(interactIds: new []{10002082}, state: 0, arg4: false);
                context.SetUserValue(key: "TrapOn", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TrapOn") == 1) {
                    return new StateLeverOnDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverOnDelay : TriggerState {
            internal StateLeverOnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLeverOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverOn : TriggerState {
            internal StateLeverOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002082}, state: 1);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002082}, arg2: 0)) {
                    return new StateTrapOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrapOn : TriggerState {
            internal StateTrapOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{203, 303}, arg2: false);
                context.SetMesh(triggerIds: new []{3430, 3431, 3432, 3433}, visible: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{203, 303});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
