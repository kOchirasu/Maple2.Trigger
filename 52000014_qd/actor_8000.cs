namespace Maple2.Trigger._52000014_qd {
    public static class _actor_8000 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8100}, arg2: false);
                context.DestroyMonster(arg1: new[] {800, 801});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State약화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State약화01 : TriggerState {
            internal State약화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {800}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교체01 : TriggerState {
            internal State교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.DestroyMonster(arg1: new[] {800});
                context.CreateMonster(arg1: new[] {801}, arg2: false);
                context.MoveNpc(arg1: 801, arg2: "MS2PatrolData_801");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State일어남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어남01 : TriggerState {
            internal State일어남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State포효01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포효01 : TriggerState {
            internal State포효01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 5);
                context.SetEffect(arg1: new[] {8100}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd01 : TriggerState {
            internal StateEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8100}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}