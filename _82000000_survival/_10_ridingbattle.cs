using System;

namespace Maple2.Trigger._82000000_survival {
    public static class _10_ridingbattle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000330, 10000331, 10000332, 10000333, 10000334, 10000335, 10000336, 10000337, 10000338,
                        10000339, 10000340, 10000341
                    }, isStart: "false");
                context.SetUserValue(key: "BattleRidingOnCount", value: 0);
                context.SetUserValue(key: "BattleRidingOff", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOnCount", value: 1)) {
                    context.State = new StateOnOffRandom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOnOffRandom : TriggerState {
            internal StateOnOffRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 40f)) {
                    context.State = new StateBattleRidingOn(context);
                    return;
                }

                if (context.RandomCondition(arg1: 60f)) {
                    context.State = new StateBattleRidingOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleRidingOff : TriggerState {
            internal StateBattleRidingOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleRidingOn : TriggerState {
            internal StateBattleRidingOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelayRandom(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelayRandom : TriggerState {
            internal StateDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_5min00sec(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_5min20sec(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_5min40sec(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_6min00sec(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_6min20sec(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_6min40sec(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateDelay_7min00sec(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_5min00sec : TriggerState {
            internal StateDelay_5min00sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_5min20sec : TriggerState {
            internal StateDelay_5min20sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 320000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_5min40sec : TriggerState {
            internal StateDelay_5min40sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 340000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_6min00sec : TriggerState {
            internal StateDelay_6min00sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 360000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_6min20sec : TriggerState {
            internal StateDelay_6min20sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 380000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_6min40sec : TriggerState {
            internal StateDelay_6min40sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay_7min00sec : TriggerState {
            internal StateDelay_7min00sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 420000)) {
                    context.State = new StateRidingSpawn(context);
                    return;
                }

                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn : TriggerState {
            internal StateRidingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {10000330, 10000331, 10000332, 10000333, 10000334, 10000335, 10000336, 10000337},
                    isStart: "true");
                context.SideNpcTalk(npcID: 23000110, illust: "Mushking_normal", duration: 5000,
                    script: "$82000000_survival__10_RIDINGBATTLE__0$");
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_none(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_north(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_south(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_east(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_west(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_northsouth(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_northeast(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_northwest(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_eastwest(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_southeast(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateRidingSpawn_Extra_southwest(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_none : TriggerState {
            internal StateRidingSpawn_Extra_none(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_north : TriggerState {
            internal StateRidingSpawn_Extra_north(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000338}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_south : TriggerState {
            internal StateRidingSpawn_Extra_south(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000340}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_east : TriggerState {
            internal StateRidingSpawn_Extra_east(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000339}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_west : TriggerState {
            internal StateRidingSpawn_Extra_west(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000341}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_northsouth : TriggerState {
            internal StateRidingSpawn_Extra_northsouth(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000338, 10000340}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_northeast : TriggerState {
            internal StateRidingSpawn_Extra_northeast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000338, 10000339}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_northwest : TriggerState {
            internal StateRidingSpawn_Extra_northwest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000338, 10000341}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_eastwest : TriggerState {
            internal StateRidingSpawn_Extra_eastwest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000339, 10000341}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_southeast : TriggerState {
            internal StateRidingSpawn_Extra_southeast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000339, 10000340}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_southwest : TriggerState {
            internal StateRidingSpawn_Extra_southwest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000341, 10000340}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleRidingOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000330, 10000331, 10000332, 10000333, 10000334, 10000335, 10000336, 10000337, 10000338,
                        10000339, 10000340, 10000341
                    }, isStart: "false");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}