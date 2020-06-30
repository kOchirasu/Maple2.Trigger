using System;

namespace Maple2.Trigger._03000088_bf {
    public static class _boss {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000009}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 23000001, textID: 23000001, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State보스등장(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.HideGuideSummary(entityID: 23000001);
                    context.SetInteractObject(arg1: new int[] {11000009}, arg2: 1);
                    context.SetEventUI(arg1: 7, arg3: new int[] {2000}, arg4: "0");
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