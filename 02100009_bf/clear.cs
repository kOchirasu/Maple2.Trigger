namespace Maple2.Trigger._02100009_bf {
    public static class _clear {
        public class State끝1 : TriggerState {
            internal State끝1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1000049}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State끝2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 100000001) <= 0.5f && context.GetNpcHpRate(spawnId: 100000002) <= 0.5f) {
                    return new State끝3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝3 : TriggerState {
            internal State끝3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{100000002}, skillId: 50000217, level: 1, arg4: true, arg5: false);
                context.SetSkill(triggerIds: new []{1000049}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
