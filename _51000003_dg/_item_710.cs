namespace Maple2.Trigger._51000003_dg {
    public static class _item_710 {
        public class StateSpawn_check : TriggerState {
            internal StateSpawn_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7710, 7720}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "item_710_spawn") == 1) {
                    return new StateSpawnItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnItem : TriggerState {
            internal StateSpawnItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7710}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {720})) {
                    return new StateGetItem_Random(context);
                }

                if (context.GetUserValue(key: "item_710_spawn") == 0) {
                    return new StateSpawn_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGetItem_Random : TriggerState {
            internal StateGetItem_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "random_buff_box");
                context.SetEffect(arg1: new[] {7710}, arg2: false);
                context.SetEffect(arg1: new[] {7720}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new StateBuff_01(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateBuff_02(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateBuff_03(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateBuff_04(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateBuff_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_01 : TriggerState {
            internal StateBuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000080, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawn_check(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 0);
            }
        }

        private class StateBuff_02 : TriggerState {
            internal StateBuff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000081, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawn_check(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 0);
            }
        }

        private class StateBuff_03 : TriggerState {
            internal StateBuff_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000082, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawn_check(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 0);
            }
        }

        private class StateBuff_04 : TriggerState {
            internal StateBuff_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000083, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawn_check(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 0);
            }
        }

        private class StateBuff_05 : TriggerState {
            internal StateBuff_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000085, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawn_check(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 0);
            }
        }
    }
}