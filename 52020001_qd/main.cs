namespace Maple2.Trigger._52020001_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{40001, 6001}, arg2: false);
                context.SetInteractObject(interactIds: new []{10002001, 10002002, 10002003}, state: 2);
                context.CreateMonster(spawnIds: new []{6000020}, arg2: false);
                context.SetEffect(triggerIds: new []{10090, 10091, 10092}, visible: false);
                context.SetMesh(triggerIds: new []{80000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{5})) {
                    return new State인트로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인트로_Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_Camera : TriggerState {
            internal State인트로_Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 2000012, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인트로_폭발_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_1 : TriggerState {
            internal State인트로_폭발_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10011}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State인트로_폭발_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_2 : TriggerState {
            internal State인트로_폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10012}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State인트로_폭발_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_3 : TriggerState {
            internal State인트로_폭발_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10013}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State인트로_폭발_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_4 : TriggerState {
            internal State인트로_폭발_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10014}, visible: true);
                context.SetSkill(triggerIds: new []{6001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State인트로_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로_종료 : TriggerState {
            internal State인트로_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
                context.CameraSelect(triggerId: 2000012, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: @"시간이 얼마 없습니다.\n폭격을 일삼는 에고웨폰들을 처치하며 크리티아스로 침투하세요.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1})) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100", seconds: 180, clearAtZero: true, display: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateMonsterSpawn_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_1 : TriggerState {
            internal StateMonsterSpawn_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{40001}, arg2: true);
                context.CreateMonster(spawnIds: new []{6000001, 6000002, 6000003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterDead_1(context);
                }

                if (context.TimeExpired(timerId: "100")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetConversation(type: 1, spawnId: 0, script: "서둘러야 해!", arg4: 3, arg5: 0);
            }
        }

        private class StateMonsterDead_1 : TriggerState {
            internal StateMonsterDead_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6000001, 6000002, 6000003})) {
                    return new StateMonsterSpawn_2(context);
                }

                if (context.TimeExpired(timerId: "100")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_2 : TriggerState {
            internal StateMonsterSpawn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{6000004, 6000005, 6000006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterDead_2(context);
                }

                if (context.TimeExpired(timerId: "100")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_2 : TriggerState {
            internal StateMonsterDead_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6000004, 6000005, 6000006})) {
                    return new State스위치CreationCinematic(context);
                }

                if (context.TimeExpired(timerId: "100")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스위치CreationCinematic : TriggerState {
            internal State스위치CreationCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "100");
                context.DestroyMonster(spawnIds: new []{6100001});
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State스위치CreationCinematic_Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스위치CreationCinematic_Camera : TriggerState {
            internal State스위치CreationCinematic_Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 2000003, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCreation_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation_1 : TriggerState {
            internal StateCreation_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002001}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스위치CreationCinematic_Camera_Reset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스위치CreationCinematic_Camera_Reset : TriggerState {
            internal State스위치CreationCinematic_Camera_Reset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
                context.CameraSelect(triggerId: 2000003, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{6100001}, arg2: false);
                context.SetConversation(type: 1, spawnId: 0, script: "저 스위치를 한번 작동시켜 볼까?", arg4: 3, arg5: 0);
            }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002001}, arg2: 0)) {
                    return new StateStartCinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_1 : TriggerState {
            internal StateStartCinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{6100001});
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State발사_CameraCinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발사_CameraCinematic_1 : TriggerState {
            internal State발사_CameraCinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 2000001, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State폭발배경Cinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_1 : TriggerState {
            internal State폭발배경Cinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10028}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State폭발배경Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_2 : TriggerState {
            internal State폭발배경Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10029}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State폭발_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_1 : TriggerState {
            internal State폭발_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State날라감_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State날라감_1 : TriggerState {
            internal State날라감_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
                context.CameraSelectPath(pathIds: new []{2000002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePc소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePc소환 : TriggerState {
            internal StatePc소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52020001, portalId: 11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State폭발배경Cinematic_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_3 : TriggerState {
            internal State폭발배경Cinematic_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10023}, visible: true);
                context.SetSkill(triggerIds: new []{6002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new State폭발배경Cinematic_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_4 : TriggerState {
            internal State폭발배경Cinematic_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10024}, visible: true);
                context.SetSkill(triggerIds: new []{6002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State폭발배경Cinematic_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_5 : TriggerState {
            internal State폭발배경Cinematic_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10025}, visible: true);
                context.SetSkill(triggerIds: new []{6002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new State맵폭발Cinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발Cinematic_1 : TriggerState {
            internal State맵폭발Cinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10021}, visible: true);
                context.SetSkill(triggerIds: new []{6002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State맵폭발Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_6 : TriggerState {
            internal State폭발배경Cinematic_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10026}, visible: true);
                context.SetSkill(triggerIds: new []{6002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State폭발배경Cinematic_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발배경Cinematic_7 : TriggerState {
            internal State폭발배경Cinematic_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10027}, visible: true);
                context.SetSkill(triggerIds: new []{6002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State맵폭발Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발Cinematic_2 : TriggerState {
            internal State맵폭발Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{10022}, visible: true);
                context.SetSkill(triggerIds: new []{6003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCamera리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋 : TriggerState {
            internal StateCamera리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 15, visible: true, enabled: true, minimapVisible: false);
                context.CameraReset(interpolationTime: 0.5f);
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
