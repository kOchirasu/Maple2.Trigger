namespace Maple2.Trigger._52020024_qd {
    public static class _52020024_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "TimerStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "FinalPhase", value: 0);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetActor(triggerId: 10001, visible: true, initialSequence: "ks_quest_movewall_A02_off");
                context.SetActor(triggerId: 10002, visible: true, initialSequence: "ks_quest_movewall_A02_off");
                context.SetActor(triggerId: 10003, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                context.SetMesh(triggerIds: new []{1001, 2001}, visible: true);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10002006, 10002007, 10002008, 10002009}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new State1차CombatDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차CombatDetection : TriggerState {
            internal State1차CombatDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State1차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투 : TriggerState {
            internal State1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "방 안을 수색하세요", duration: 5000, boxId: 0);
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103}, arg2: false)) {
                    return new State1번레버활성화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번레버활성화 : TriggerState {
            internal State1번레버활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002006}, state: 1);
                context.AddBalloonTalk(spawnId: 0, msg: "파편 융합 장치 전원을 찾아야해", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002006}, arg2: 0)) {
                    return new State2차CombatDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차CombatDetection : TriggerState {
            internal State2차CombatDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001}, visible: false, arg3: 500);
                context.SetActor(triggerId: 10001, visible: true, initialSequence: "ks_quest_movewall_A02_start");
                context.AddBalloonTalk(spawnId: 0, msg: "헐... 대박...", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new State2차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 112}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112}, arg2: false)) {
                    return new State2번레버활성화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번레버활성화 : TriggerState {
            internal State2번레버활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "여기엔 없는것 같네", duration: 3000, delayTick: 0);
                context.SetInteractObject(interactIds: new []{10002007}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002007}, arg2: 0)) {
                    return new State3차CombatDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차CombatDetection : TriggerState {
            internal State3차CombatDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2001}, visible: false, arg3: 500);
                context.SetActor(triggerId: 10002, visible: true, initialSequence: "ks_quest_movewall_A02_start");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{904})) {
                    return new State3차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121, 122}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 122}, arg2: false)) {
                    return new State3번레버활성화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번레버활성화 : TriggerState {
            internal State3번레버활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002008}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002008}, arg2: 0)) {
                    return new State파편모으기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파편모으기 : TriggerState {
            internal State파편모으기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002009}, state: 1);
                context.AddBalloonTalk(spawnId: 0, msg: "중앙으로 가보자!", duration: 3000, delayTick: 0);
                context.SetEventUI(arg1: 1, script: "융합장치 전원 활성화.", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002009}, arg2: 0)) {
                    return new State파이널전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파이널전투 : TriggerState {
            internal State파이널전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 10003, visible: true, initialSequence: "ks_quest_fusiondevice_A01_on");
                context.SetUserValue(triggerId: 99990002, key: "TimerStart", value: 1);
                context.SetUserValue(triggerId: 99990003, key: "FinalPhase", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimerStart") == 2) {
                    return new State파편합성완료(context);
                }

                if (context.GetUserValue(key: "FinalPhase") == 2) {
                    return new State파편합성완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파편합성완료 : TriggerState {
            internal State파편합성완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 10003, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_미카엘Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_미카엘Spawn : TriggerState {
            internal StateCamera_미카엘Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.MoveUser(mapId: 52020024, portalId: 2);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_Michael");
                context.CameraSelect(triggerId: 501, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_미카엘Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_미카엘Script1 : TriggerState {
            internal StateCamera_미카엘Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "아주 좋아!", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera_미카엘Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_미카엘Script2 : TriggerState {
            internal StateCamera_미카엘Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetConversation(type: 1, spawnId: 201, script: "파편이 어쩌구~ 저쩌구~", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera_지진사태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_지진사태 : TriggerState {
            internal StateCamera_지진사태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 503, enabled: true);
                context.SetConversation(type: 1, spawnId: 0, script: "왜...왜 이러지?", arg4: 4);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG\Common\Eff_Com_Vibrate_Lowamp.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_바닥부서짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_바닥부서짐 : TriggerState {
            internal StateCamera_바닥부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "으아아악!!!", arg4: 2);
                context.CameraSelect(triggerId: 504, enabled: true);
                context.SetSkill(triggerIds: new []{1}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020025, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
