using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _item_711 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSpawn_check(context);

        private class StateSpawn_check : TriggerState {
            internal StateSpawn_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7711}, arg2: false);
                context.SetEffect(arg1: new int[] {7721}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "item_711_spawn", value: 1)) {
                    context.State = new StateSpawnItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawnItem : TriggerState {
            internal StateSpawnItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7711}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "721")) {
                    context.State = new StateGetItem_Random(context);
                    return;
                }

                if (context.UserValue(key: "item_711_spawn", value: 0)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDisable : TriggerState {
            internal StateDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetItem_Random : TriggerState {
            internal StateGetItem_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "random_buff_box");
                context.SetEffect(arg1: new int[] {7711}, arg2: false);
                context.SetEffect(arg1: new int[] {7721}, arg2: true);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateBuff_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateBuff_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateBuff_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateBuff_04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateBuff_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBuff_01 : TriggerState {
            internal StateBuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 70000080, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
            }
        }

        private class StateBuff_02 : TriggerState {
            internal StateBuff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 70000081, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
            }
        }

        private class StateBuff_03 : TriggerState {
            internal StateBuff_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 70000082, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
            }
        }

        private class StateBuff_04 : TriggerState {
            internal StateBuff_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 70000083, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
            }
        }

        private class StateBuff_05 : TriggerState {
            internal StateBuff_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 70000085, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawn_check(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
            }
        }
    }
}