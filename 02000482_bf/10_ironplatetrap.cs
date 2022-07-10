namespace Maple2.Trigger._02000482_bf {
    public static class _10_ironplatetrap {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3410, 3411, 3412, 3413}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103}, visible: false);
                context.DestroyMonster(spawnIds: new []{201, 301});
                context.SetInteractObject(interactIds: new []{10002027}, state: 0, arg4: false);
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
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLeverOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverOn : TriggerState {
            internal StateLeverOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002027}, state: 1);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002027}, arg2: 0)) {
                    return new StateTrapOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrapOn : TriggerState {
            internal StateTrapOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 301}, arg2: false);
                context.SetMesh(triggerIds: new []{3410, 3411, 3412, 3413}, visible: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103}, visible: false);
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
                context.DestroyMonster(spawnIds: new []{201, 301});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
