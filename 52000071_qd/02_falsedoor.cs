namespace Maple2.Trigger._52000071_qd {
    public static class _02_falsedoor {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001104}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001104}, arg2: 0)) {
                    return new StateMobSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn : TriggerState {
            internal StateMobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{902}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
