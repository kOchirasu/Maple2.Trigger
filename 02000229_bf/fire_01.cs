namespace Maple2.Trigger._02000229_bf {
    public static class _fire_01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000051}, state: 1);
                context.SetEffect(triggerIds: new []{501}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000051}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateDelay(context);
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{501}, visible: true);
                context.CreateMonster(spawnIds: new []{101});
            }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$02000229_BF__FIRE_01__0$", arg4: 2);
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateDelay2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{501}, visible: false);
                context.DestroyMonster(spawnIds: new []{101});
            }
        }

        private class StateDelay2 : TriggerState {
            internal StateDelay2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
