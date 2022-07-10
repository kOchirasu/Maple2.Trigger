namespace Maple2.Trigger._52020009_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8001}, visible: false);
                context.SetInteractObject(interactIds: new []{10001266}, state: 0);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006}, visible: false);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200020}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200020}, questStates: new byte[]{2})) {
                    return new StateMeshOff(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200020}, questStates: new byte[]{3})) {
                    return new StateMeshOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006}, visible: true);
                context.SetMesh(triggerIds: new []{8001}, visible: true);
                context.AddBalloonTalk(spawnId: 0, msg: "!", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206, 207})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001266}, state: 1);
                context.SetMesh(triggerIds: new []{8001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000449}, arg2: 0)) {
                    return new StateMeshOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeshOff : TriggerState {
            internal StateMeshOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200020}, questStates: new byte[]{1})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
