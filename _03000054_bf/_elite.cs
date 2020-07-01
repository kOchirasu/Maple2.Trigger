namespace Maple2.Trigger._03000054_bf {
    public static class _elite {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000008, 11000009}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
                    context.State = new State엘리트등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트등장 : TriggerState {
            internal State엘리트등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000002, textId: 23000002, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State엘리트등장(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1001, 1002, 1003})) {
                    context.HideGuideSummary(entityId: 23000002);
                    context.SetEventUI(arg1: 7, arg3: 2000, arg4: "0");
                    context.State = new State상자확률(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상자확률 : TriggerState {
            internal State상자확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 90f)) {
                    context.SetInteractObject(arg1: new[] {11000008}, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.SetInteractObject(arg1: new[] {11000009}, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}