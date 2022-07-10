using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000315_bf {
    public static class _battle_01 {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000}, visible: false);
                context.SetLadder(triggerId: 510, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3110, 3210, 3310}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005}, visible: true);
                context.SetInteractObject(interactIds: new []{10001043, 10001044, 10001035}, state: 1);
                context.EnableSpawnPointPc(spawnId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 992, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 993, isEnable: false);
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

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{99}, arg2: false);
            }

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
                context.CameraSelectPath(pathIds: new []{600, 601}, returnView: false);
                context.SetSkip(state: new StateCameraWalk01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{601, 600}, returnView: true);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1stBattle(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetLadder(triggerId: 510, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State1stBattle : TriggerState {
            internal State1stBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "CameraWalkEnd", value: 1);
                context.CreateMonster(spawnIds: new []{901, 902, 903}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001043}, arg2: 0)) {
                    return new State1stBridgeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stBridgeOn : TriggerState {
            internal State1stBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001}, visible: false);
                context.DestroyMonster(spawnIds: new []{901, 902, 903});
                context.SetMesh(triggerIds: new []{3110}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109}, visible: true, arg3: 0, arg4: 100, arg5: 10f);
                context.SetUserValue(triggerId: 101, key: "BridgeOpen", value: 1);
                context.SetUserValue(triggerId: 102, key: "BridgeOpen", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{504})) {
                    return new State2ndBattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndBattle : TriggerState {
            internal State2ndBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 991, isEnable: true);
                context.CreateMonster(spawnIds: new []{904, 905, 906}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001044}, arg2: 0)) {
                    return new State2ndBridgeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndBridgeOn : TriggerState {
            internal State2ndBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8002, 8003}, visible: false);
                context.DestroyMonster(spawnIds: new []{904, 905, 906});
                context.SetMesh(triggerIds: new []{3210}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, visible: true, arg3: 0, arg4: 100, arg5: 10f);
                context.SetUserValue(triggerId: 101, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 102, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 103, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 104, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 105, key: "BridgeOpen", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{507})) {
                    return new State3rdBattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdBattle : TriggerState {
            internal State3rdBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 993, isEnable: true);
                context.CreateMonster(spawnIds: new []{907, 908, 909}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001035}, arg2: 0)) {
                    return new State3rdBridgeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdBridgeOn : TriggerState {
            internal State3rdBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8004, 8005}, visible: false);
                context.DestroyMonster(spawnIds: new []{907, 908, 909});
                context.SetMesh(triggerIds: new []{3310}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309}, visible: true, arg3: 0, arg4: 100, arg5: 10f);
                context.SetUserValue(triggerId: 101, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 102, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 103, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 104, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 105, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 106, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 107, key: "BridgeOpen", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{402})) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 993, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 992, isEnable: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{99});
            }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
