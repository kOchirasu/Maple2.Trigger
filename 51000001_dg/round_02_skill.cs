namespace Maple2.Trigger._51000001_dg {
    public static class _round_02_skill {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3201, 3202, 3203}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State지역Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역Random : TriggerState {
            internal State지역Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{102})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    context.SetMesh(triggerIds: new []{3201}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateA지역(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    context.SetMesh(triggerIds: new []{3202}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateB지역(context);
                }

                if (context.RandomCondition(rate: 34f)) {
                    context.SetMesh(triggerIds: new []{3203}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateC지역(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10201})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10202})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10203})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "random_buff_box");
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{102})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 40f)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 49179051, level: 1, arg4: false, arg5: false);
                    return new StateWaitTime(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000085, level: 1, arg5: false);
                    return new StateWaitTime(context);
                }

                if (context.RandomCondition(rate: 15f)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 49179061, level: 1, arg4: false, arg5: false);
                    return new StateWaitTime(context);
                }

                if (context.RandomCondition(rate: 15f)) {
                    context.AddBuff(boxIds: new []{199}, skillId: 49179071, level: 1, arg4: false, arg5: false);
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3201, 3202, 3203}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
