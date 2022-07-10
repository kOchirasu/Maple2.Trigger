namespace Maple2.Trigger._03000147_bf {
    public static class _chest {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{11000023}, state: 1);
                context.SetInteractObject(interactIds: new []{11000008, 11000009}, state: 2);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    context.SetInteractObject(interactIds: new []{11000023}, state: 2);
                    return new State1차웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브Wait : TriggerState {
            internal State1차웨이브Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000003, textId: 23000003, duration: 5000);
                context.SetEffect(triggerIds: new []{602, 603}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1차웨이브시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브시작 : TriggerState {
            internal State1차웨이브시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001, 1002})) {
                    return new State2차웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Wait : TriggerState {
            internal State2차웨이브Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차웨이브시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브시작 : TriggerState {
            internal State2차웨이브시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new State3차웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브Wait : TriggerState {
            internal State3차웨이브Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3차웨이브시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브시작 : TriggerState {
            internal State3차웨이브시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{3001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3001})) {
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
                if (context.RandomCondition(rate: 90f)) {
                    context.SetInteractObject(interactIds: new []{11000008}, state: 1);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 10f)) {
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
