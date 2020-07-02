namespace Maple2.Trigger._02020110_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
                    return new State1번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번방 : TriggerState {
            internal State1번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 120}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 120})) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    return new State2번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번방 : TriggerState {
            internal State2번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102, 103, 104, 105, 106, 107}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102, 103, 104, 105, 106, 107})) {
                    context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                    return new State3번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번방 : TriggerState {
            internal State3번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {108, 109, 110, 111, 112, 113})) {
                    context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                    return new State4번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번방 : TriggerState {
            internal State4번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114, 115, 116, 117, 118, 119}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {114, 115, 116, 117, 118, 119})) {
                    return new State다음블록이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다음블록이동 : TriggerState {
            internal State다음블록이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}