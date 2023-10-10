namespace Maple2.Trigger._61000009_me {
    public static class _3round_effect {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "3Round_Effect") == 1) {
                    return new StateSpawn_Start_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Start_Ready : TriggerState {
            internal StateSpawn_Start_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7999}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSkill_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill_01 : TriggerState {
            internal StateSkill_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{5021}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSkill_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill_02 : TriggerState {
            internal StateSkill_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{5022}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSkill_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill_03 : TriggerState {
            internal StateSkill_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{5023}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSkill_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill_04 : TriggerState {
            internal StateSkill_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{5024}, enabled: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
