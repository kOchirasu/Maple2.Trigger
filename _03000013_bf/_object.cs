using System;

namespace Maple2.Trigger._03000013_bf {
    public static class _object {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000008}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {11000009}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 23000004, textID: 23000004, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State몬스터생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.HideGuideSummary(entityID: 23000004);
                    context.SetEventUI(arg1: 7, arg3: new int[] {2000}, arg4: "0");
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
                    context.SetInteractObject(arg1: new int[] {11000008}, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.SetInteractObject(arg1: new int[] {11000009}, arg2: 1);
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