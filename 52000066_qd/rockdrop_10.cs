namespace Maple2.Trigger._52000066_qd {
    public static class _rockdrop_10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{8000, 8001}, enabled: false);
                context.SetEffect(triggerIds: new []{7000, 7001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateRockDrop01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockDrop01 : TriggerState {
            internal StateRockDrop01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateRockDrop02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockDrop02 : TriggerState {
            internal StateRockDrop02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{8000}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateRockDrop11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockDrop11 : TriggerState {
            internal StateRockDrop11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateRockDrop12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockDrop12 : TriggerState {
            internal StateRockDrop12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{8001}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateRockDrop21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockDrop21 : TriggerState {
            internal StateRockDrop21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateRockDrop22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockDrop22 : TriggerState {
            internal StateRockDrop22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{8000}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{8000, 8001}, enabled: false);
                context.SetEffect(triggerIds: new []{7000, 7001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRockDrop01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
