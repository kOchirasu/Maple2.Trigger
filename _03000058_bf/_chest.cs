namespace Maple2.Trigger._03000058_bf {
    public static class _chest {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000023}, arg2: 1);
                context.SetInteractObject(arg1: new[] {11000008, 11000009}, arg2: 2);
                context.SetEffect(arg1: new[] {601, 602, 603, 604}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.SetInteractObject(arg1: new[] {11000023}, arg2: 2);
                    return new State1차웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브대기 : TriggerState {
            internal State1차웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 23000003, textId: 23000003, duration: 5000);
                context.SetEffect(arg1: new[] {602, 603}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {1001, 1002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1001, 1002})) {
                    return new State2차웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브대기 : TriggerState {
            internal State2차웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State3차웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브대기 : TriggerState {
            internal State3차웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {3001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {3001})) {
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