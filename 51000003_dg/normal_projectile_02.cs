namespace Maple2.Trigger._51000003_dg {
    public static class _normal_projectile_02 {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    return new StateRound_03(context);
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Round_05") == 1) {
                    // return new StateRound_05(context);
                    return null;
                }

                if (context.GetUserValue(key: "Round_06") == 1) {
                    // return new StateRound_06(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01 : TriggerState {
            internal StateRound_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{351, 352});
                context.CreateMonster(spawnIds: new []{302}, arg2: true, arg3: 1000);
                context.CreateMonster(spawnIds: new []{303}, arg2: true, arg3: 2000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02 : TriggerState {
            internal StateRound_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{353, 354});
                context.CreateMonster(spawnIds: new []{304}, arg2: true, arg3: 500);
                context.CreateMonster(spawnIds: new []{305}, arg2: true, arg3: 1500);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_03") == 1) {
                    return new StateRound_03(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_03 : TriggerState {
            internal StateRound_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{355, 356});
                context.CreateMonster(spawnIds: new []{306}, arg2: true, arg3: 1000);
                context.CreateMonster(spawnIds: new []{301}, arg2: true, arg3: 2000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_04") == 1) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04 : TriggerState {
            internal StateRound_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{312}, arg2: true, arg3: 500);
                context.CreateMonster(spawnIds: new []{311}, arg2: true, arg3: 1500);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
