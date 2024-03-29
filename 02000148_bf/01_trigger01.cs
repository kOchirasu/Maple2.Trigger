namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000109}, state: 1);
                context.SetEffect(triggerIds: new []{201, 202, 203, 204}, visible: false);
                context.SetMesh(triggerIds: new []{325, 326, 303, 304}, visible: true);
                context.SetMesh(triggerIds: new []{305, 306, 307, 308}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000109}, arg2: 0)) {
                    return new State개봉박두(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{325, 326, 303, 304}, visible: false);
                context.CreateMonster(spawnIds: new []{91, 92, 93, 94}, arg2: true);
                context.SetMesh(triggerIds: new []{305, 306, 307, 308}, visible: true);
                context.SetEffect(triggerIds: new []{201, 202, 203, 204}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91, 92, 93, 94})) {
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
                if (!context.UserDetected(boxIds: new []{401})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
