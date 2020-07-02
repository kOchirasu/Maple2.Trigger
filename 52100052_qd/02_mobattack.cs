namespace Maple2.Trigger._52100052_qd {
    public static class _02_mobattack {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002, 5003}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005}, arg2: true);
                context.DestroyMonster(arg1: new[] {910, 911, 920, 921, 930, 931});
                context.SetUserValue(key: "MobSpawn", value: 0);
                context.SetUserValue(key: "MobAttack", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawn") == 1) {
                    return new StateMobSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {910, 911, 920, 921, 930, 931}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobAttack") == 1) {
                    return new StateMobAttackDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobAttackDelay : TriggerState {
            internal StateMobAttackDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateMobAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobAttack01 : TriggerState {
            internal StateMobAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMobAttack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobAttack02 : TriggerState {
            internal StateMobAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8002, 8003}, arg2: false);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMobAttack03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobAttack03 : TriggerState {
            internal StateMobAttack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8004, 8005}, arg2: false);
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {5003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {910, 911, 920, 921, 930, 931, 901, 902, 903})) {
                    return new StateMobClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobClear : TriggerState {
            internal StateMobClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "MobClear", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}