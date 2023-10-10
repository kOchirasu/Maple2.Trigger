namespace Maple2.Trigger._82000002_survival {
    public static class _10_ridingbattle {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000507, 10000508, 10000509, 10000510, 10000511, 10000512, 10000513, 10000514, 10000515, 10000516, 10000517, 10000518}, isStart: false);
                context.SetUserValue(key: "BattleRidingOnCount", value: 0);
                context.SetUserValue(key: "BattleRidingOff", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BattleRidingOnCount") == 1) {
                    return new StateRidingSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn : TriggerState {
            internal StateRidingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000507, 10000508, 10000509, 10000510, 10000511, 10000512, 10000513, 10000514}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_none(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_north(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_south(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_east(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_west(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_northsouth(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_northeast(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_northwest(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_eastwest(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_southeast(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateRidingSpawn_Extra_southwest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRidingSpawn_Extra_none : TriggerState {
            internal StateRidingSpawn_Extra_none(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000515}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000517}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000516}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000518}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000515, 10000517}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000515, 10000516}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000515, 10000518}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000516, 10000518}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000516, 10000517}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000518, 10000517}, isStart: true);
            }

            public override TriggerState? Execute() {
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
                context.StartCombineSpawn(groupId: new []{10000507, 10000508, 10000509, 10000510, 10000511, 10000512, 10000513, 10000514, 10000515, 10000516, 10000517, 10000518}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
