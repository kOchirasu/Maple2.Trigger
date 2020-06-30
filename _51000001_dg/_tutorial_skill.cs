using System;

namespace Maple2.Trigger._51000001_dg {
    public static class _tutorial_skill {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "100")) {
                    context.State = new State지역랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지역랜덤 : TriggerState {
            internal State지역랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: "100")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateA지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateB지역(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "10001")) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "10002")) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: "100")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 40f)) {
                    context.AddBuff(arg1: new int[] {199}, arg2: 49179051, arg3: 1, arg4: false, arg5: false);
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.AddBuff(arg1: new int[] {199}, arg2: 70000085, arg3: 1, arg5: false);
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.AddBuff(arg1: new int[] {199}, arg2: 49179061, arg3: 1, arg4: false, arg5: false);
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.AddBuff(arg1: new int[] {199}, arg2: 49179071, arg3: 1, arg4: false, arg5: false);
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작대기중(context);
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