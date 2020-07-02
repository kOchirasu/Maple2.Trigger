namespace Maple2.Trigger._51000003_dg {
    public static class _item_01 {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 0);
                context.SetUserValue(triggerId: 991118, key: "item_711_spawn", value: 0);
                context.SetUserValue(triggerId: 991117, key: "item_712_spawn", value: 0);
                context.SetUserValue(triggerId: 991116, key: "item_713_spawn", value: 0);
                context.SetUserValue(triggerId: 991115, key: "item_714_spawn", value: 0);
                context.SetUserValue(triggerId: 991114, key: "item_715_spawn", value: 0);
                context.SetUserValue(triggerId: 991113, key: "item_716_spawn", value: 0);
                context.SetUserValue(triggerId: 991112, key: "item_717_spawn", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Ready : TriggerState {
            internal StateRound_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Start : TriggerState {
            internal StateRound_01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_710(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_711(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_712(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_713(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_714(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_715(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_716(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateItem_717(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextSpawn : TriggerState {
            internal StateNextSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRound_01_Start(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_710 : TriggerState {
            internal StateItem_710(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {710})) {
                    return new StateItem_710_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_711 : TriggerState {
            internal StateItem_711(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {711})) {
                    return new StateItem_711_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_712 : TriggerState {
            internal StateItem_712(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {712})) {
                    return new StateItem_712_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_713 : TriggerState {
            internal StateItem_713(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {713})) {
                    return new StateItem_713_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_714 : TriggerState {
            internal StateItem_714(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {714})) {
                    return new StateItem_714_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_715 : TriggerState {
            internal StateItem_715(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {715})) {
                    return new StateItem_715_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_716 : TriggerState {
            internal StateItem_716(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {716})) {
                    return new StateItem_716_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_717 : TriggerState {
            internal StateItem_717(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {717})) {
                    return new StateItem_717_spawn(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateItem_710_spawn : TriggerState {
            internal StateItem_710_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991119, key: "item_710_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_711_spawn : TriggerState {
            internal StateItem_711_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991118, key: "item_711_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_712_spawn : TriggerState {
            internal StateItem_712_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991117, key: "item_712_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_713_spawn : TriggerState {
            internal StateItem_713_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991116, key: "item_713_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_714_spawn : TriggerState {
            internal StateItem_714_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991115, key: "item_714_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_715_spawn : TriggerState {
            internal StateItem_715_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991114, key: "item_715_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_716_spawn : TriggerState {
            internal StateItem_716_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991113, key: "item_716_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }

        private class StateItem_717_spawn : TriggerState {
            internal StateItem_717_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991112, key: "item_717_spawn", value: 1);
            }

            public override TriggerState Execute() {
                return new StateNextSpawn(context);
            }

            public override void OnExit() { }
        }
    }
}