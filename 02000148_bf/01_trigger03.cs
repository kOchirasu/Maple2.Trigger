namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000171}, state: 1);
                context.SetEffect(triggerIds: new []{209, 210, 211, 212}, visible: false);
                context.SetMesh(triggerIds: new []{317, 318, 319, 320}, visible: true);
                context.SetMesh(triggerIds: new []{321, 322, 323, 324}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000171}, arg2: 0)) {
                    return new State개봉박두(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{317, 318, 319, 320}, visible: false);
                context.CreateMonster(spawnIds: new []{99, 100, 101, 102}, arg2: true);
                context.SetMesh(triggerIds: new []{321, 322, 323, 324}, visible: true);
                context.SetEffect(triggerIds: new []{209, 210, 211, 212}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99, 100, 101, 102})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{403})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
