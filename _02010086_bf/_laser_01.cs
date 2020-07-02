namespace Maple2.Trigger._02010086_bf {
    public static class _laser_01 {
        public class State레이저_01_소멸 : TriggerState {
            internal State레이저_01_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 712) == 1) {
                    return new State레이저_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {999});
            }
        }

        private class State레이저_02 : TriggerState {
            internal State레이저_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    return new State레이저_02_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_02_Creation : TriggerState {
            internal State레이저_02_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {998}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 708) == 1) {
                    return new State레이저_03_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_03_Creation : TriggerState {
            internal State레이저_03_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {995}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}