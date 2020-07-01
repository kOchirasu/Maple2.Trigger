namespace Maple2.Trigger._65010006_bd {
    public static class _debuff {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크 : TriggerState {
            internal State체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State디버프(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디버프 : TriggerState {
            internal State디버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {102}, arg2: 70000040, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}