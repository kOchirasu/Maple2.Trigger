using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _item_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateRound_check(context);

        private class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991119, key: "item_710_spawn", value: 0);
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 0);
                context.SetUserValue(triggerID: 991117, key: "item_712_spawn", value: 0);
                context.SetUserValue(triggerID: 991116, key: "item_713_spawn", value: 0);
                context.SetUserValue(triggerID: 991115, key: "item_714_spawn", value: 0);
                context.SetUserValue(triggerID: 991114, key: "item_715_spawn", value: 0);
                context.SetUserValue(triggerID: 991113, key: "item_716_spawn", value: 0);
                context.SetUserValue(triggerID: 991112, key: "item_717_spawn", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Round_01", value: 1)) {
                    context.State = new StateRound_01_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Ready : TriggerState {
            internal StateRound_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Start : TriggerState {
            internal StateRound_01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_710(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_711(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_712(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_713(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_714(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_715(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_716(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Stateitem_717(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNextSpawn : TriggerState {
            internal StateNextSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_710 : TriggerState {
            internal Stateitem_710(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {710})) {
                    context.State = new Stateitem_710_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_711 : TriggerState {
            internal Stateitem_711(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {711})) {
                    context.State = new Stateitem_711_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_712 : TriggerState {
            internal Stateitem_712(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {712})) {
                    context.State = new Stateitem_712_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_713 : TriggerState {
            internal Stateitem_713(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {713})) {
                    context.State = new Stateitem_713_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_714 : TriggerState {
            internal Stateitem_714(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {714})) {
                    context.State = new Stateitem_714_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_715 : TriggerState {
            internal Stateitem_715(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {715})) {
                    context.State = new Stateitem_715_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_716 : TriggerState {
            internal Stateitem_716(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {716})) {
                    context.State = new Stateitem_716_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_717 : TriggerState {
            internal Stateitem_717(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {717})) {
                    context.State = new Stateitem_717_spawn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRound_01_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_710_spawn : TriggerState {
            internal Stateitem_710_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991119, key: "item_710_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_711_spawn : TriggerState {
            internal Stateitem_711_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991118, key: "item_711_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_712_spawn : TriggerState {
            internal Stateitem_712_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991117, key: "item_712_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_713_spawn : TriggerState {
            internal Stateitem_713_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991116, key: "item_713_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_714_spawn : TriggerState {
            internal Stateitem_714_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991115, key: "item_714_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_715_spawn : TriggerState {
            internal Stateitem_715_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991114, key: "item_715_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_716_spawn : TriggerState {
            internal Stateitem_716_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991113, key: "item_716_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateitem_717_spawn : TriggerState {
            internal Stateitem_717_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991112, key: "item_717_spawn", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}