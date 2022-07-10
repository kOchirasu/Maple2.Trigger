namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000170}, state: 1);
                context.SetEffect(triggerIds: new []{205, 206, 207, 208}, visible: false);
                context.SetMesh(triggerIds: new []{309, 310, 311, 312}, visible: true);
                context.SetMesh(triggerIds: new []{313, 314, 315, 316}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000170}, arg2: 0)) {
                    return new State개봉박두(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{309, 310, 311, 312}, visible: false);
                context.CreateMonster(spawnIds: new []{95, 96, 97, 98}, arg2: true);
                context.SetMesh(triggerIds: new []{313, 314, 315, 316}, visible: true);
                context.SetEffect(triggerIds: new []{205, 206, 207, 208}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{95, 96, 97, 98})) {
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
                if (!context.UserDetected(boxIds: new []{402})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
