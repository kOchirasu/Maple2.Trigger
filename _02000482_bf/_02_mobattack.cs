using System;

namespace Maple2.Trigger._02000482_bf {
    public static class _02_mobattack {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: "8000,8001", arg2: true);
                context.SetAgent(arg1: "8002,8003", arg2: true);
                context.SetAgent(arg1: "8004,8005", arg2: true);
                context.DestroyMonster(arg1: new int[] {910, 911, 920, 921, 930, 931});
                context.SetUserValue(key: "MobSpawn", value: 0);
                context.SetUserValue(key: "MobAttack", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "MobSpawn", value: 1)) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {910, 911}, arg2: false);
                context.CreateMonster(arg1: new int[] {920, 921}, arg2: false);
                context.CreateMonster(arg1: new int[] {930, 931}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "MobAttack", value: 1)) {
                    context.State = new StateMobAttackDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobAttackDelay : TriggerState {
            internal StateMobAttackDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new StateMobAttack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobAttack01 : TriggerState {
            internal StateMobAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000,8001", arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMobAttack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobAttack02 : TriggerState {
            internal StateMobAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8002,8003", arg2: false);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMobAttack03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobAttack03 : TriggerState {
            internal StateMobAttack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8004,8005", arg2: false);
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {910, 911, 920, 921, 930, 931, 901, 902, 903})) {
                    context.State = new StateMobClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobClear : TriggerState {
            internal StateMobClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "MobClear", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}