namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{4201, 4202}, visible: false);
                context.SetMesh(triggerIds: new []{1200, 1201}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 2200, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 2201, visible: true, initialSequence: "Closed");
                context.SetAgent(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405, 406, 407, 408}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405, 406, 407, 408})) {
                    return new State문열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1200, 1201}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{4201, 4202}, visible: true);
                context.SetActor(triggerId: 2200, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 2201, visible: true, initialSequence: "Opened");
                context.SetAgent(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208}, visible: false);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
