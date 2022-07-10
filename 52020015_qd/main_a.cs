namespace Maple2.Trigger._52020015_qd {
    public static class _main_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5100, 5101}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200095}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{60200095}, questStates: new byte[]{1})) {
                    return new StateScene_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_Ready : TriggerState {
            internal StateScene_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5100, 5101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4101, 4102}, returnView: false);
                context.SetSceneSkip(state: new StateMobSpawn_A(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4105}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4104, 4103}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4201}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Down_Idle_A", duration: 10000f);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Down_Idle_A", duration: 10000f);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Down_Idle_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4202}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4204}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4202}, returnView: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMobSpawn_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_A : TriggerState {
            internal StateMobSpawn_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 101, addSpawnId: 201);
                context.ChangeMonster(removeSpawnId: 102, addSpawnId: 202);
                context.ChangeMonster(removeSpawnId: 103, addSpawnId: 203);
                context.SetEffect(triggerIds: new []{5006, 5007, 5008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePlay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlay : TriggerState {
            internal StatePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2003})) {
                    return new StateMobSpawn_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_B : TriggerState {
            internal StateMobSpawn_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 104, addSpawnId: 204);
                context.ChangeMonster(removeSpawnId: 105, addSpawnId: 205);
                context.ChangeMonster(removeSpawnId: 106, addSpawnId: 206);
                context.ChangeMonster(removeSpawnId: 107, addSpawnId: 207);
                context.ChangeMonster(removeSpawnId: 108, addSpawnId: 208);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208})) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "Exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5100, 5101}, visible: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
