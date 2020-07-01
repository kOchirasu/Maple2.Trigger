namespace Maple2.Trigger._02100009_bf {
    public static class _text {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 100000001) <= 0.5f || context.GetNpcHpRate(spawnPointId: 100000002) <= 0.5f) {
                    return new State알림_2(context);
                }

                if (context.MonsterDead(arg1: new[] {100000001}) && context.MonsterDead(arg1: new[] {100000002})) {
                    return new State완료알림(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "10000");
            }
        }

        private class State알림_2 : TriggerState {
            internal State알림_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State알림_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "$02100009_BF__resurrection_2__0$", arg3: 4000);
            }
        }

        private class State알림_3 : TriggerState {
            internal State알림_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State알림(context);
                }

                if (context.MonsterDead(arg1: new[] {100000001}) && context.MonsterDead(arg1: new[] {100000002})) {
                    return new State완료알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료알림 : TriggerState {
            internal State완료알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}