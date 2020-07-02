namespace Maple2.Trigger._02020300_bf {
    public static class _laser_01 {
        public class State레이저_01_Creation : TriggerState {
            internal State레이저_01_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Laser") == 1) {
                    context.CreateMonster(arg1: new[] {902}, arg2: true);
                    return new State레이저_01_소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_01_소멸 : TriggerState {
            internal State레이저_01_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103})) {
                    context.DestroyMonster(arg1: new[] {902});
                    return new State레이저_02_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_02_Creation : TriggerState {
            internal State레이저_02_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 711) == 1) {
                    context.CreateMonster(arg1: new[] {711}, arg2: true);
                    return new State레이저_02_소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_02_소멸 : TriggerState {
            internal State레이저_02_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 712) == 1) {
                    context.DestroyMonster(arg1: new[] {711});
                    return new State레이저_03_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_03_Creation : TriggerState {
            internal State레이저_03_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 712) == 1) {
                    context.CreateMonster(arg1: new[] {712}, arg2: true);
                    return new State레이저_03_소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_03_소멸 : TriggerState {
            internal State레이저_03_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 713) == 1) {
                    context.DestroyMonster(arg1: new[] {712});
                    context.CreateMonster(arg1: new[] {713}, arg2: true);
                    return new State레이저_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_04 : TriggerState {
            internal State레이저_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Laser") == 0) {
                    context.DestroyMonster(arg1: new[] {713});
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}