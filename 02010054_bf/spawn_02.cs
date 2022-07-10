namespace Maple2.Trigger._02010054_bf {
    public static class _spawn_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000885}, state: 2);
                context.SetEffect(triggerIds: new []{611}, visible: false);
                context.SetMesh(triggerIds: new []{3128}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{611}, visible: true);
                context.SetMesh(triggerIds: new []{3128}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(spawnIds: new []{2023}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2023})) {
                    context.SetInteractObject(interactIds: new []{10000885}, state: 1);
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
