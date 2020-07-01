namespace Maple2.Trigger._02000486_bf {
    public static class _104_clear {
        public class State끝1 : TriggerState {
            internal State끝1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9901})) {
                    return new State끝2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 900) <= 0.5f && context.GetNpcHpRate(spawnPointId: 901) <= 0.5f) {
                    return new State끝3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝3 : TriggerState {
            internal State끝3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {900}, arg2: 50002505, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {901}, arg2: 50002505, arg3: 1, arg4: true, arg5: false);
                context.SetSkill(arg1: new[] {1000049}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}