namespace Maple2.Trigger._02020141_bf {
    public static class _interactmesh10014104 {
        public class State최초시작 : TriggerState {
            internal State최초시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003150}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new State탈것_SpawnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_SpawnWait : TriggerState {
            internal State탈것_SpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈것_SpawnCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_SpawnCinematic : TriggerState {
            internal State탈것_SpawnCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{14104}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State탈것_Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_Spawn : TriggerState {
            internal State탈것_Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003150}, state: 1);
                context.DestroyMonster(spawnIds: new []{14104});
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003150}, arg2: 0)) {
                    return new State인터렉트_동작중(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작중 : TriggerState {
            internal State인터렉트_동작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003150}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State탈것_SpawnWait(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003150}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
