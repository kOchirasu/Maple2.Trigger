namespace Maple2.Trigger._02000337_bf {
    public static class _main {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetEffect(arg1: new[] {7301, 7302, 7303, 7304, 7305}, arg2: false);
                context.SetEffect(arg1: new[] {7310}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new State폭발01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발01 : TriggerState {
            internal State폭발01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7301}, arg2: true);
                context.SetSkill(arg1: new[] {8301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State폭발02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발02 : TriggerState {
            internal State폭발02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7302}, arg2: true);
                context.SetSkill(arg1: new[] {8302}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State폭발03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발03 : TriggerState {
            internal State폭발03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7303, 7304}, arg2: true);
                context.SetSkill(arg1: new[] {8303, 8304}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State폭발04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발04 : TriggerState {
            internal State폭발04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7305}, arg2: true);
                context.SetSkill(arg1: new[] {8305}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State폭발04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}