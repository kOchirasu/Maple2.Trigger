using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000312_bf {
    public static class _mobspawn_11 {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3005, 3006, 3007, 3008, 3009, 3010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 510, arg2: false, arg3: false);
                context.SetLadder(arg1: 511, arg2: false, arg3: false);
                context.SetLadder(arg1: 512, arg2: false, arg3: false);
                context.SetLadder(arg1: 513, arg2: false, arg3: false);
                context.SetMesh(arg1: new[] {3002, 3003, 3004, 1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1140}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {1140}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: false);
                context.SetUserValue(key: "MobWaveStop", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(state: new StateCameraWalk01(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetLadder(arg1: 510, arg2: true, arg3: true);
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetMesh(arg1: new[] {3005, 3006, 3007, 3008, 3009, 3010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031201, textId: 20031201);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103})) {
                    return new StateBattle02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 102, 103});
            }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031201);
                context.CreateMonster(arg1: new[] {111, 112, 113, 114}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114})) {
                    return new StateBattle03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114});
            }
        }

        private class StateBattle03 : TriggerState {
            internal StateBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031202, textId: 20031202);
                context.CreateMonster(arg1: new[] {130}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {130})) {
                    return new StateVineRemove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {130});
            }
        }

        private class StateVineRemove01 : TriggerState {
            internal StateVineRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031202);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {3002, 3003, 3004}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false, arg3: 9, arg4: 0, arg5: 50);
                context.SetRandomMesh(arg1: new[] {1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119}, arg2: false, arg3: 10, arg4: 300, arg5: 50);
                context.SetRandomMesh(arg1: new[] {1120, 1121, 1122, 1123, 1124, 1125, 1126}, arg2: false, arg3: 7, arg4: 200, arg5: 50);
                context.SetRandomMesh(arg1: new[] {1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137}, arg2: false, arg3: 8, arg4: 100, arg5: 50);
                context.SetMesh(arg1: new[] {1140}, arg2: false, arg3: 200, arg4: 0, arg5: 10f);
                context.SetMeshAnimation(arg1: new[] {1140}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateMobWaveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobWaveStart : TriggerState {
            internal StateMobWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20031203, textId: 20031203);
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128})) {
                    return new StateMobWaveDelayRandom(context);
                }

                if (context.GetUserValue(key: "MobWaveStop") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128});
            }
        }

        private class StateMobWaveDelayRandom : TriggerState {
            internal StateMobWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 60f)) {
                    return new StateMobWaveDelay01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMobWaveDelay02(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMobWaveDelay03(context);
                }

                if (context.GetUserValue(key: "MobWaveStop") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobWaveDelay01 : TriggerState {
            internal StateMobWaveDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateMobWaveStart(context);
                }

                if (context.GetUserValue(key: "MobWaveStop") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobWaveDelay02 : TriggerState {
            internal StateMobWaveDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new StateMobWaveStart(context);
                }

                if (context.GetUserValue(key: "MobWaveStop") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobWaveDelay03 : TriggerState {
            internal StateMobWaveDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateMobWaveStart(context);
                }

                if (context.GetUserValue(key: "MobWaveStop") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031203);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}