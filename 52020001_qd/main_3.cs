namespace Maple2.Trigger._52020001_qd {
    public static class _main_3 {
        public class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{3})) {
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

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "102", seconds: 180, autoRemove: true, display: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateMonsterSpawn_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_5 : TriggerState {
            internal StateMonsterSpawn_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{6100003, 6000018, 6000019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterHealth50(context);
                }

                if (context.TimeExpired(timerId: "102")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterHealth50 : TriggerState {
            internal StateMonsterHealth50(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 6000018) <= 0.50f || context.GetNpcHpRate(spawnId: 6000019) <= 0.50f) {
                    return new StateCreation_2(context);
                }

                if (context.TimeExpired(timerId: "102")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation_2 : TriggerState {
            internal StateCreation_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{6000018}, skillId: 49286001, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{6000019}, skillId: 49286001, level: 1, arg4: true);
                context.ResetTimer(timerId: "102");
                context.SetInteractObject(interactIds: new []{10002003}, state: 1);
                context.SetEventUI(arg1: 1, script: "아크레온이 거대해지며 모든공격을 튕겨내기 시작했습니다.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State작동_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 921, key: "respawn", value: 1);
            }
        }

        private class State작동_2 : TriggerState {
            internal State작동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002003}, arg2: 0)) {
                    return new StateStartCinematic_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 921, key: "respawn_end", value: 2);
            }
        }

        private class StateStartCinematic_2 : TriggerState {
            internal StateStartCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{6100003});
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
                context.CameraSelectPath(pathIds: new []{2000007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State폭발_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new State맵폭발Cinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발Cinematic_1 : TriggerState {
            internal State맵폭발Cinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10041}, visible: true);
                context.SetSkill(triggerIds: new []{6005}, enabled: true);
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
                context.CameraSelectPath(pathIds: new []{2000008}, returnView: false);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
                context.DestroyMonster(spawnIds: new []{6000018, 6000019});
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
                context.MoveUser(mapId: 52020001, portalId: 13);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State맵폭발Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발Cinematic_2 : TriggerState {
            internal State맵폭발Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10042}, visible: true);
                context.SetSkill(triggerIds: new []{6006}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateCamera리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋 : TriggerState {
            internal StateCamera리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 17, visible: true, enabled: true, minimapVisible: false);
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

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
