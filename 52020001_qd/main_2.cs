namespace Maple2.Trigger._52020001_qd {
    public static class _main_2 {
        public class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2})) {
                    return new State잠시기다림_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시기다림_1 : TriggerState {
            internal State잠시기다림_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, script: "폭격이 더욱 거세집니다. 서둘러 이동하세요!", duration: 4000);
            }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "101", seconds: 180, autoRemove: true, display: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateMonsterSpawn_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_3 : TriggerState {
            internal StateMonsterSpawn_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{6100002, 6000011, 6000012, 6000013}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterDead_3(context);
                }

                if (context.TimeExpired(timerId: "101")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_3 : TriggerState {
            internal StateMonsterDead_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6000011, 6000012, 6000013})) {
                    return new StateMonsterSpawn_4(context);
                }

                if (context.TimeExpired(timerId: "101")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_4 : TriggerState {
            internal StateMonsterSpawn_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{6000014, 6000015, 6000016}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterDead_4(context);
                }

                if (context.TimeExpired(timerId: "101")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_4 : TriggerState {
            internal StateMonsterDead_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6000014, 6000015, 6000016})) {
                    return new StateCreation_2(context);
                }

                if (context.TimeExpired(timerId: "101")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation_2 : TriggerState {
            internal StateCreation_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "101");
                context.SetInteractObject(interactIds: new []{10002002}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State작동_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_2 : TriggerState {
            internal State작동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002002}, arg2: 0)) {
                    return new StateStartCinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_2 : TriggerState {
            internal StateStartCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{6100002});
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2000005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State폭발_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State맵폭발Cinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발Cinematic_1 : TriggerState {
            internal State맵폭발Cinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10031}, visible: true);
                context.SetSkill(triggerIds: new []{6004}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateCameraCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic : TriggerState {
            internal StateCameraCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2000006}, returnView: false);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePc소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePc소환_2 : TriggerState {
            internal StatePc소환_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52020001, portalId: 12);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateCamera리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋 : TriggerState {
            internal StateCamera리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 16, visible: true, enabled: true, minimapVisible: false);
                context.CameraReset(interpolationTime: 0.8f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10090, 10091, 10092}, visible: true);
                context.SetMesh(triggerIds: new []{80000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetEventUI(arg1: 1, script: "미션에 실패하였습니다. 다시 재도전 해보세요.", duration: 4000);
                context.MoveUser(mapId: 52020001, portalId: 99);
                context.SetPortal(portalId: 14, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
