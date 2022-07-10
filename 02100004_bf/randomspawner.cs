namespace Maple2.Trigger._02100004_bf {
    public static class _randomspawner {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RoundStart") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomSpawn : TriggerState {
            internal StateRandomSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck01(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck02(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck03(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck04(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck05(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck06(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck08(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck09(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck10(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck11(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck12(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateOverlapCheck13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck01 : TriggerState {
            internal StateOverlapCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned01") == 0) {
                    context.SetUserValue(triggerId: 999101, key: "NpcSpawn01", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned01") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck02 : TriggerState {
            internal StateOverlapCheck02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned02") == 0) {
                    context.SetUserValue(triggerId: 999102, key: "NpcSpawn02", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned02") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck03 : TriggerState {
            internal StateOverlapCheck03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned03") == 0) {
                    context.SetUserValue(triggerId: 999103, key: "NpcSpawn03", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned03") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck04 : TriggerState {
            internal StateOverlapCheck04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned04") == 0) {
                    context.SetUserValue(triggerId: 999104, key: "NpcSpawn04", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned04") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck05 : TriggerState {
            internal StateOverlapCheck05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned05") == 0) {
                    context.SetUserValue(triggerId: 999105, key: "NpcSpawn05", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned05") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck06 : TriggerState {
            internal StateOverlapCheck06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned06") == 0) {
                    context.SetUserValue(triggerId: 999106, key: "NpcSpawn06", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned06") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck08 : TriggerState {
            internal StateOverlapCheck08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned08") == 0) {
                    context.SetUserValue(triggerId: 999108, key: "NpcSpawn08", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned08") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck09 : TriggerState {
            internal StateOverlapCheck09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned09") == 0) {
                    context.SetUserValue(triggerId: 999109, key: "NpcSpawn09", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned09") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck10 : TriggerState {
            internal StateOverlapCheck10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned10") == 0) {
                    context.SetUserValue(triggerId: 999110, key: "NpcSpawn10", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned10") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck11 : TriggerState {
            internal StateOverlapCheck11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned11") == 0) {
                    context.SetUserValue(triggerId: 999111, key: "NpcSpawn11", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned11") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck12 : TriggerState {
            internal StateOverlapCheck12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned12") == 0) {
                    context.SetUserValue(triggerId: 999112, key: "NpcSpawn12", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned12") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOverlapCheck13 : TriggerState {
            internal StateOverlapCheck13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NpcSpawned13") == 0) {
                    context.SetUserValue(triggerId: 999113, key: "NpcSpawn13", value: 1);
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "NpcSpawned13") == 1) {
                    return new StateRandomSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
