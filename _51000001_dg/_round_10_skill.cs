using System;

namespace Maple2.Trigger._51000001_dg {
    public static class _round_10_skill {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {31001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {110})) {
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
                if (!context.UserDetected(arg1: new int[] {110})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new int[] {31001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateA지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new int[] {31002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateB지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new int[] {31003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateC지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new int[] {31004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateD지역(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new int[] {31005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateE지역(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11001})) {
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
                if (context.UserDetected(arg1: new int[] {11002})) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11003})) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateD지역 : TriggerState {
            internal StateD지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11004})) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateE지역 : TriggerState {
            internal StateE지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11005})) {
                    context.State = new State스킬랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "random_buff_box");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {110})) {
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
                context.SetMesh(arg1: new int[] {31001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
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