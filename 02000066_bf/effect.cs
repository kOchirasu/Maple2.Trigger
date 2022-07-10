namespace Maple2.Trigger._02000066_bf {
    public static class _effect {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{99})) {
                    return new State이펙트Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Creation : TriggerState {
            internal State이펙트Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State이펙트소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트소멸 : TriggerState {
            internal State이펙트소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "15", seconds: 15);
                context.SetEffect(triggerIds: new []{6001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
