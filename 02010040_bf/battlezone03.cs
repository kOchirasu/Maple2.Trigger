namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{4301, 4302, 4303}, visible: false);
                context.SetMesh(triggerIds: new []{1300, 1301, 1302}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 2300, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 2301, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 2302, visible: true, initialSequence: "Closed");
                context.SetAgent(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9300})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{501, 502, 601, 602, 701, 702}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{501, 502, 601, 602, 701, 702})) {
                    return new State문열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1300, 1301, 1302}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{4301, 4302, 4303}, visible: true);
                context.SetActor(triggerId: 2300, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 2301, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 2302, visible: true, initialSequence: "Opened");
                context.SetAgent(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312}, visible: false);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
