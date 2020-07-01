namespace Maple2.Trigger._03000036_bf {
    public static class _chest {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000023}, arg2: 1);
                context.SetInteractObject(arg1: new[] {11000008}, arg2: 2);
                context.SetInteractObject(arg1: new[] {11000009}, arg2: 2);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetEffect(arg1: new[] {604}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.SetInteractObject(arg1: new[] {11000023}, arg2: 2);
                    context.State = new State1차웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차웨이브대기 : TriggerState {
            internal State1차웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000003, textId: 23000003, duration: 5000);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1차웨이브시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차웨이브시작 : TriggerState {
            internal State1차웨이브시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1001, 1002})) {
                    context.State = new State2차웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브대기 : TriggerState {
            internal State2차웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차웨이브시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브시작 : TriggerState {
            internal State2차웨이브시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State3차웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차웨이브대기 : TriggerState {
            internal State3차웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State3차웨이브시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차웨이브시작 : TriggerState {
            internal State3차웨이브시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {3001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {3001})) {
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