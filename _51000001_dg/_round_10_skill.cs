namespace Maple2.Trigger._51000001_dg {
    public static class _round_10_skill {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {31001, 31002, 31003, 31004, 31005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {110})) {
                    return new State지역랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역랜덤 : TriggerState {
            internal State지역랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {110})) {
                    return new State종료(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {31001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateA지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {31002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateB지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {31003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateC지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {31004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateD지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {31005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateE지역(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11001})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11002})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11003})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateD지역 : TriggerState {
            internal StateD지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11004})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateE지역 : TriggerState {
            internal StateE지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11005})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "random_buff_box");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {110})) {
                    return new State종료(context);
                }

                if (context.RandomCondition(arg1: 40f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179051, arg3: 1, arg4: false, arg5: false);
                    return new State대기시간(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000085, arg3: 1, arg5: false);
                    return new State대기시간(context);
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179061, arg3: 1, arg4: false, arg5: false);
                    return new State대기시간(context);
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179071, arg3: 1, arg4: false, arg5: false);
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {31001, 31002, 31003, 31004, 31005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}