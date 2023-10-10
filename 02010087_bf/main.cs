namespace Maple2.Trigger._02010087_bf {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{7301, 7302, 7303, 7304, 7305}, visible: false);
                context.SetEffect(triggerIds: new []{7310}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new State폭발01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발01 : TriggerState {
            internal State폭발01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7301}, visible: true);
                context.SetSkill(triggerIds: new []{8301}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State폭발02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발02 : TriggerState {
            internal State폭발02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7302}, visible: true);
                context.SetSkill(triggerIds: new []{8302}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State폭발03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발03 : TriggerState {
            internal State폭발03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7303, 7304}, visible: true);
                context.SetSkill(triggerIds: new []{8303, 8304}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State폭발04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발04 : TriggerState {
            internal State폭발04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7305}, visible: true);
                context.SetSkill(triggerIds: new []{8305}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State폭발04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
