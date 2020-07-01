namespace Maple2.Trigger._02100004_bf {
    public static class _randomspawner {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RoundStart") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤스폰 : TriggerState {
            internal State랜덤스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 0);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크01(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크02(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크03(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크04(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크05(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크06(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크08(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크09(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크10(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크11(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크12(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State중복체크13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크01 : TriggerState {
            internal State중복체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned01") == 0) {
                    context.SetUserValue(triggerId: 999101, key: "NpcSpawn01", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned01") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크02 : TriggerState {
            internal State중복체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned02") == 0) {
                    context.SetUserValue(triggerId: 999102, key: "NpcSpawn02", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned02") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크03 : TriggerState {
            internal State중복체크03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned03") == 0) {
                    context.SetUserValue(triggerId: 999103, key: "NpcSpawn03", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned03") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크04 : TriggerState {
            internal State중복체크04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned04") == 0) {
                    context.SetUserValue(triggerId: 999104, key: "NpcSpawn04", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned04") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크05 : TriggerState {
            internal State중복체크05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned05") == 0) {
                    context.SetUserValue(triggerId: 999105, key: "NpcSpawn05", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned05") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크06 : TriggerState {
            internal State중복체크06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned06") == 0) {
                    context.SetUserValue(triggerId: 999106, key: "NpcSpawn06", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned06") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크08 : TriggerState {
            internal State중복체크08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned08") == 0) {
                    context.SetUserValue(triggerId: 999108, key: "NpcSpawn08", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned08") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크09 : TriggerState {
            internal State중복체크09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned09") == 0) {
                    context.SetUserValue(triggerId: 999109, key: "NpcSpawn09", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned09") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크10 : TriggerState {
            internal State중복체크10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned10") == 0) {
                    context.SetUserValue(triggerId: 999110, key: "NpcSpawn10", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned10") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크11 : TriggerState {
            internal State중복체크11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned11") == 0) {
                    context.SetUserValue(triggerId: 999111, key: "NpcSpawn11", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned11") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크12 : TriggerState {
            internal State중복체크12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned12") == 0) {
                    context.SetUserValue(triggerId: 999112, key: "NpcSpawn12", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned12") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중복체크13 : TriggerState {
            internal State중복체크13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcSpawned13") == 0) {
                    context.SetUserValue(triggerId: 999113, key: "NpcSpawn13", value: 1);
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "NpcSpawned13") == 1) {
                    return new State랜덤스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}