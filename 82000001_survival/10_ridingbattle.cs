namespace Maple2.Trigger._82000001_survival {
    public static class _10_ridingbattle {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000330, 10000331, 10000332, 10000333, 10000334, 10000335, 10000336, 10000337, 10000338, 10000339, 10000340, 10000341}, isStart: false);
                context.SetUserValue(key: "BattleRidingOnCount", value: 0);
                context.SetUserValue(key: "BattleRidingOff", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOnCount") == 1) {
                    return new StateOnOffRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOnOffRandom : TriggerState {
            internal StateOnOffRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 40f)) {
                    return new StateBattleRidingOn(context);
                }

                if (context.RandomCondition(arg1: 60f)) {
                    return new StateBattleRidingOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleRidingOff : TriggerState {
            internal StateBattleRidingOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleRidingOn : TriggerState {
            internal StateBattleRidingOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelayRandom(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelayRandom : TriggerState {
            internal StateDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_5min00sec(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_5min20sec(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_5min40sec(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_6min00sec(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_6min20sec(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_6min40sec(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateDelay_7min00sec(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_5min00sec : TriggerState {
            internal StateDelay_5min00sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_5min20sec : TriggerState {
            internal StateDelay_5min20sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 320000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_5min40sec : TriggerState {
            internal StateDelay_5min40sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 340000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_6min00sec : TriggerState {
            internal StateDelay_6min00sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 360000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_6min20sec : TriggerState {
            internal StateDelay_6min20sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 380000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_6min40sec : TriggerState {
            internal StateDelay_6min40sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 400000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_7min00sec : TriggerState {
            internal StateDelay_7min00sec(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 420000)) {
                    return new StateRidingSpawn(context);
                }

                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn : TriggerState {
            internal StateRidingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000330, 10000331, 10000332, 10000333, 10000334, 10000335, 10000336, 10000337}, isStart: true);
                context.SideNpcTalk(npcId: 23000110, illust: "Mushking_normal", duration: 5000, script: "$82000000_survival__10_RIdINGBATTLE__0$");
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_none(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_north(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_south(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_east(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_west(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_northsouth(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_northeast(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_northwest(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_eastwest(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_southeast(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new StateRidingSpawn_Extra_southwest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_none : TriggerState {
            internal StateRidingSpawn_Extra_none(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_north : TriggerState {
            internal StateRidingSpawn_Extra_north(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000338}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_south : TriggerState {
            internal StateRidingSpawn_Extra_south(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000340}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_east : TriggerState {
            internal StateRidingSpawn_Extra_east(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000339}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_west : TriggerState {
            internal StateRidingSpawn_Extra_west(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000341}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_northsouth : TriggerState {
            internal StateRidingSpawn_Extra_northsouth(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000338, 10000340}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_northeast : TriggerState {
            internal StateRidingSpawn_Extra_northeast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000338, 10000339}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_northwest : TriggerState {
            internal StateRidingSpawn_Extra_northwest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000338, 10000341}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_eastwest : TriggerState {
            internal StateRidingSpawn_Extra_eastwest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000339, 10000341}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_southeast : TriggerState {
            internal StateRidingSpawn_Extra_southeast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000339, 10000340}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_southwest : TriggerState {
            internal StateRidingSpawn_Extra_southwest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000341, 10000340}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleRidingOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000330, 10000331, 10000332, 10000333, 10000334, 10000335, 10000336, 10000337, 10000338, 10000339, 10000340, 10000341}, isStart: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}