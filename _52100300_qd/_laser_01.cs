namespace Maple2.Trigger._52100300_qd {
    public static class _laser_01 {
        public class State레이저_01_생성 : TriggerState {
            internal State레이저_01_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Laser") == 1) {
                    context.CreateMonster(arg1: new[] {902}, arg2: true);
                    context.State = new State레이저_01_소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_01_소멸 : TriggerState {
            internal State레이저_01_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103})) {
                    context.DestroyMonster(arg1: new[] {902});
                    context.State = new State레이저_02_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_02_생성 : TriggerState {
            internal State레이저_02_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 711) == 1) {
                    context.CreateMonster(arg1: new[] {711}, arg2: true);
                    context.State = new State레이저_02_소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_02_소멸 : TriggerState {
            internal State레이저_02_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 712) == 1) {
                    context.DestroyMonster(arg1: new[] {711});
                    context.State = new State레이저_03_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_03_생성 : TriggerState {
            internal State레이저_03_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 712) == 1) {
                    context.CreateMonster(arg1: new[] {712}, arg2: true);
                    context.State = new State레이저_03_소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_03_소멸 : TriggerState {
            internal State레이저_03_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 713) == 1) {
                    context.DestroyMonster(arg1: new[] {712});
                    context.CreateMonster(arg1: new[] {713}, arg2: true);
                    context.State = new State레이저_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_04 : TriggerState {
            internal State레이저_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Laser") == 0) {
                    context.DestroyMonster(arg1: new[] {713});
                }
            }

            public override void OnExit() { }
        }
    }
}