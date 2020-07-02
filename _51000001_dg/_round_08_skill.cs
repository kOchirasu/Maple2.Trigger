namespace Maple2.Trigger._51000001_dg {
    public static class _round_08_skill {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {108})) {
                    return new State지역Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역Random : TriggerState {
            internal State지역Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {108})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {3801}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateA지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {3802}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateB지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {3803}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateC지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {3804}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateD지역(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.SetMesh(arg1: new[] {3805}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
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
                if (context.UserDetected(arg1: new[] {10801})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10802})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10803})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateD지역 : TriggerState {
            internal StateD지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10804})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateE지역 : TriggerState {
            internal StateE지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10805})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "random_buff_box");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {108})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 40f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179051, arg3: 1, arg4: false, arg5: false);
                    return new StateWaitTime(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000085, arg3: 1, arg5: false);
                    return new StateWaitTime(context);
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179061, arg3: 1, arg4: false, arg5: false);
                    return new StateWaitTime(context);
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179071, arg3: 1, arg4: false, arg5: false);
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateWaitStart(context);
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