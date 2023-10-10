namespace Maple2.Trigger._03000021_bf {
    public static class _object {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{11000008, 11000009}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000004, textId: 23000004, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateMobCreation(context);
                }

                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.HideGuideSummary(entityId: 23000004);
                    context.SetEventUI(arg1: 7, duration: 2000, boxId: 0);
                    return new State상자확률(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상자확률 : TriggerState {
            internal State상자확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 90)) {
                    context.SetInteractObject(interactIds: new []{11000008}, state: 1);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    context.SetInteractObject(interactIds: new []{11000009}, state: 1);
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
