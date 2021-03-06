namespace Maple2.Trigger._02000304_bf {
    public static class _minion_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {113})) {
                    context.CreateMonster(arg1: new[] {1005, 1006}, arg2: false);
                    return new StateEnd체크(context);
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1005, 1006})) {
                    return new StateWaitTime(context);
                }

                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.DestroyMonster(arg1: new[] {1005, 1006});
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000304, arg2: 10, arg3: 113);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}