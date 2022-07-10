namespace Maple2.Trigger._03000056_bf {
    public static class _boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{11000009}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000001, textId: 23000001, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBossSpawn(context);
                }

                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.HideGuideSummary(entityId: 23000001);
                    context.SetInteractObject(interactIds: new []{11000009}, state: 1);
                    context.SetEventUI(arg1: 7, duration: 2000, boxId: 0);
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
