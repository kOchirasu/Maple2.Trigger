namespace Maple2.Trigger._03000054_bf {
    public static class _elite {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000008, 11000009}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
                    return new StateEliteSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEliteSpawn : TriggerState {
            internal StateEliteSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000002, textId: 23000002, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEliteSpawn(context);
                }

                if (context.MonsterDead(arg1: new[] {1001, 1002, 1003})) {
                    context.HideGuideSummary(entityId: 23000002);
                    context.SetEventUI(arg1: 7, arg3: 2000, arg4: "0");
                    return new State상자확률(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상자확률 : TriggerState {
            internal State상자확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 90f)) {
                    context.SetInteractObject(arg1: new[] {11000008}, arg2: 1);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.SetInteractObject(arg1: new[] {11000009}, arg2: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}