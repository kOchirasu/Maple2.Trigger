namespace Maple2.Trigger._99999840 {
    public static class _pc_move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State애디셔널체크 : TriggerState {
            internal State애디셔널체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 9001, additionalEffectId: 70002541, level: 1)) {
                    return new State유저이동확률(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동확률 : TriggerState {
            internal State유저이동확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new State유저이동1(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new State유저이동2(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new State유저이동3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동1 : TriggerState {
            internal State유저이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999841, arg2: 2, arg3: 9202);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class State유저이동2 : TriggerState {
            internal State유저이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999841, arg2: 3, arg3: 9202);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class State유저이동3 : TriggerState {
            internal State유저이동3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999841, arg2: 4, arg3: 9202);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                return new StateWait(context);
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