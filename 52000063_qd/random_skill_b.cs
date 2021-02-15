namespace Maple2.Trigger._52000063_qd {
    public static class _random_skill_b {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604, 605, 606}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "gameStart") == 1) {
                    return new State감지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지Wait : TriggerState {
            internal State감지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604, 605, 606}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {112})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604, 605, 606}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 80f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000008, arg3: 1, arg4: false, arg5: false);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000009, arg3: 1, arg4: false, arg5: false);
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