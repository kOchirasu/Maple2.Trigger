namespace Maple2.Trigger._52100022_qd {
    public static class _01_bossbattle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {901, 902, 903});
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.EnableSpawnPointPc(spawnPointId: 10000, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 10001, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 10002, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 10003, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateBoss01SpawnDelay(context);
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    return new StateBoss02SpawnDelay(context);
                }

                if (context.UserDetected(arg1: new[] {9003})) {
                    return new StateBoss03SpawnDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss01SpawnDelay : TriggerState {
            internal StateBoss01SpawnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 10000, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 10001, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoss01Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss01Spawn : TriggerState {
            internal StateBoss01Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901}, arg2: false);
                context.SetUserValue(triggerId: 1122330, key: "AgentOff", value: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss01Talk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss01Talk01 : TriggerState {
            internal StateBoss01Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003068, script: "$02000382_BF__01_BOSSBATTLE__0$", arg4: 4);
                context.SetSkip(state: new StateBoss01Talk01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss01Talk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss01Talk01Skip : TriggerState {
            internal StateBoss01Talk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss01Talk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss01Talk02 : TriggerState {
            internal StateBoss01Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003069, script: "$02000382_BF__01_BOSSBATTLE__1$", arg4: 5);
                context.SetSkip(state: new StateBoss01Talk02Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss01Talk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss01Talk02Skip : TriggerState {
            internal StateBoss01Talk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    return new StateLeavePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02SpawnDelay : TriggerState {
            internal StateBoss02SpawnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 10000, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 10002, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoss02Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02Spawn : TriggerState {
            internal StateBoss02Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss02CameraSet(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02CameraSet : TriggerState {
            internal StateBoss02CameraSet(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 511, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss02Talk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02Talk01 : TriggerState {
            internal StateBoss02Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003068, script: "$02000382_BF__01_BOSSBATTLE__2$", arg4: 3);
                context.SetSkip(state: new StateBoss02Talk01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBoss02Talk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02Talk01Skip : TriggerState {
            internal StateBoss02Talk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 512, arg2: true);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss02Talk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02Talk02 : TriggerState {
            internal StateBoss02Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003069, script: "$02000382_BF__01_BOSSBATTLE__3$", arg4: 4);
                context.SetSkip(state: new StateBoss02Talk02Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss02Talk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss02Talk02Skip : TriggerState {
            internal StateBoss02Talk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    return new StateLeavePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss03SpawnDelay : TriggerState {
            internal StateBoss03SpawnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 10000, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 10003, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoss03Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss03Spawn : TriggerState {
            internal StateBoss03Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {903}, arg2: false);
                context.SetUserValue(triggerId: 1122330, key: "AgentOff", value: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 521, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss03Talk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss03Talk01 : TriggerState {
            internal StateBoss03Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003068, script: "$02000382_BF__01_BOSSBATTLE__4$", arg4: 4);
                context.SetSkip(state: new StateBoss03Talk01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss03Talk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss03Talk01Skip : TriggerState {
            internal StateBoss03Talk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 522, arg2: true);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss03Talk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss03Talk02 : TriggerState {
            internal StateBoss03Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003069, script: "$02000382_BF__01_BOSSBATTLE__5$", arg4: 5);
                context.SetSkip(state: new StateBoss03Talk02Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss03Talk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss03Talk02Skip : TriggerState {
            internal StateBoss03Talk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {903})) {
                    return new StateLeavePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeavePortalOn : TriggerState {
            internal StateLeavePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "BossKill", value: 1);
                context.DestroyMonster(arg1: new[] {901, 902, 903});
            }

            public override TriggerState Execute() {
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
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "ClearSnowQueen");
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}