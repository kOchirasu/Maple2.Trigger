namespace Maple2.Trigger._99999883 {
    public static class _testtrigger5_anyone {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{901});
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCheckAnyOne(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnyOne : TriggerState {
            internal StateCheckAnyOne(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000) || context.MonsterDead(spawnIds: new []{901})) {
                    return new StateQuitDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuitDelay : TriggerState {
            internal StateQuitDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{901});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
