using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000312_bf {
    public static class _mobspawn_11 {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005, 3006, 3007, 3008, 3009, 3010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 510, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false);
                context.SetMesh(triggerIds: new []{3002, 3003, 3004, 1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1140}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{1140}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
                context.SetUserValue(key: "MobWaveStop", value: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enable: true);
                context.SetSkip(state: new StateCameraWalk01(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 600, enable: false);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetLadder(triggerId: 510, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true);
                context.SetMesh(triggerIds: new []{3005, 3006, 3007, 3008, 3009, 3010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 20031201, textId: 20031201);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    return new StateBattle02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103});
            }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031201);
                context.CreateMonster(spawnIds: new []{111, 112, 113, 114}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114})) {
                    return new StateBattle03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{111, 112, 113, 114});
            }
        }

        private class StateBattle03 : TriggerState {
            internal StateBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 20031202, textId: 20031202);
                context.CreateMonster(spawnIds: new []{130}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{130})) {
                    return new StateVineRemove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{130});
            }
        }

        private class StateVineRemove01 : TriggerState {
            internal StateVineRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031202);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetMesh(triggerIds: new []{3002, 3003, 3004}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, visible: false, meshCount: 9, arg4: 0, delay: 50);
                context.SetRandomMesh(triggerIds: new []{1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119}, visible: false, meshCount: 10, arg4: 300, delay: 50);
                context.SetRandomMesh(triggerIds: new []{1120, 1121, 1122, 1123, 1124, 1125, 1126}, visible: false, meshCount: 7, arg4: 200, delay: 50);
                context.SetRandomMesh(triggerIds: new []{1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137}, visible: false, meshCount: 8, arg4: 100, delay: 50);
                context.SetMesh(triggerIds: new []{1140}, visible: false, arg3: 200, arg4: 0, arg5: 10f);
                context.SetMeshAnimation(triggerIds: new []{1140}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new StateMobWaveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobWaveStart : TriggerState {
            internal StateMobWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 20031203, textId: 20031203);
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 125, 126, 127, 128}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 122, 123, 124, 125, 126, 127, 128})) {
                    return new StateMobWaveDelayRandom(context);
                }

                if (context.GetUserValue(key: "MobWaveStop") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{121, 122, 123, 124, 125, 126, 127, 128});
            }
        }

        private class StateMobWaveDelayRandom : TriggerState {
            internal StateMobWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 60f)) {
                    return new StateMobWaveDelay01(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateMobWaveDelay02(context);
                }

                if (context.RandomCondition(rate: 20f)) {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
