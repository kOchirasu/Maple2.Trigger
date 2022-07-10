using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020004_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State트럭으로가세요_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State세리하첫SpawnCinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{3})) {
                    return new State제이든만_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{2})) {
                    return new State제이든만_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{1})) {
                    return new State제이든만_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{3})) {
                    return new State제이든만_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{2})) {
                    return new State제이든호출_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{1})) {
                    return new State제이든호출_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001760}, questStates: new byte[]{3})) {
                    return new State라딘에게돌아가_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001760}, questStates: new byte[]{2})) {
                    return new State라딘에게돌아가_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001760}, questStates: new byte[]{1})) {
                    return new State공주님과기사Cinematic_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefault : TriggerState {
            internal StateDefault(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘에게돌아가_Wait : TriggerState {
            internal State라딘에게돌아가_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001760}, questStates: new byte[]{3})) {
                    return new State라딘에게돌아가(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001760}, questStates: new byte[]{2})) {
                    return new State라딘에게돌아가(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001760}, questStates: new byte[]{2})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘에게돌아가 : TriggerState {
            internal State라딘에게돌아가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020002, portalId: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘에게돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든호출_Wait : TriggerState {
            internal State제이든호출_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{2})) {
                    return new State제이든호출_SetupCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{1})) {
                    return new State제이든호출_SetupCinematic(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{2})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefault_Waiting : TriggerState {
            internal StateDefault_Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State세리하첫SpawnCinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인_Wait01 : TriggerState {
            internal State조건확인_Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State세리하첫SpawnCinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{1})) {
                    return new StateMonster체크(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인_Wait02 : TriggerState {
            internal State조건확인_Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State세리하첫SpawnCinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001762}, questStates: new byte[]{1})) {
                    return new StateMonster체크(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001761}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트럭으로가세요_Wait : TriggerState {
            internal State트럭으로가세요_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State트럭으로가세요(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State트럭으로가세요(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트럭으로가세요 : TriggerState {
            internal State트럭으로가세요(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020005, portalId: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트럭으로가세요(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 111, 121, 122, 131, 132, 133});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주님과기사Cinematic_Wait : TriggerState {
            internal State공주님과기사Cinematic_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52020004, portalId: 1);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State공주님과기사Cinematic_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State공주님과기사Cinematic_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주님과기사Cinematic_시작 : TriggerState {
            internal State공주님과기사Cinematic_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공주와기사00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주와기사00 : TriggerState {
            internal State공주와기사00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003675, illustId: "Krantz_normal", script: "이곳은… 꽤나 오랜만에 오는 것 같군요. ", duration: 3000);
                context.MoveNpc(spawnId: 102, patrolName: "krantz_walkin");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공주와기사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주와기사01 : TriggerState {
            internal State공주와기사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddCinematicTalk(npcId: 11003674, illustId: "Eone_normal", script: "그렇구나. …다시 올 일이 없을 줄 알았지만. ", duration: 3000);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_Krantz_walking");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공주와기사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주와기사02 : TriggerState {
            internal State공주와기사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.AddCinematicTalk(npcId: 11003675, illustId: "Krantz_normal", script: "제게 내리실 명령이 무엇입니까?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공주와기사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주와기사03 : TriggerState {
            internal State공주와기사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_Krantz_promise");
                context.AddCinematicTalk(npcId: 11003674, illustId: "Eone_normal", script: "기다려 달라.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공주와기사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주와기사04 : TriggerState {
            internal State공주와기사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003675, illustId: "Krantz_normal", script: "헐….", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.AddCinematicTalk(npcId: 11003674, illustId: "Eone_normal", script: @"연출을 보강할 예정이니 기다려 달라.\n이 연출엔 대사가 추가될 것이다.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공주님과기사Cinematic_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주님과기사Cinematic_스킵완료 : TriggerState {
            internal State공주님과기사Cinematic_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State공주님과기사Cinematic_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공주님과기사Cinematic_종료 : TriggerState {
            internal State공주님과기사Cinematic_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "PrincessMeetsHerKnight");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State라딘에게돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든만_Wait : TriggerState {
            internal State제이든만_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 110, 111, 112, 121, 122, 131, 132, 133});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든호출_SetupCinematic : TriggerState {
            internal State제이든호출_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{110, 105, 106, 107, 108, 109}, arg2: false);
                context.DestroyMonster(spawnIds: new []{101, 102, 111, 112, 121, 122, 131, 132, 133});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제이든호출_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든호출_StartCinematic : TriggerState {
            internal State제이든호출_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new State제이든호출_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC진입_놀람(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC진입_놀람 : TriggerState {
            internal StatePC진입_놀람(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007, 8008, 8009}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "이건 대체… 무슨 상황이지?", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State제이든짜증01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든짜증01 : TriggerState {
            internal State제이든짜증01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.AddCinematicTalk(npcId: 11003541, illustId: "Jaiden_normal", script: "…몰라서 물어?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이든짜증02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든짜증02 : TriggerState {
            internal State제이든짜증02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8011}, returnView: false);
                context.AddCinematicTalk(npcId: 11003541, illustId: "Jaiden_normal", script: "부주의한 누구 덕에 난리가 난 상황이다.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 110, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이든짜증03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든짜증03 : TriggerState {
            internal State제이든짜증03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8012}, returnView: false);
                context.AddCinematicTalk(npcId: 11003541, illustId: "Jaiden_normal", script: "빨리 이쪽으로 넘어와! 어서!", duration: 2000);
                context.SetNpcEmotionLoop(spawnId: 110, sequenceName: "Talk_A", duration: 3000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제이든호출_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든호출_스킵완료 : TriggerState {
            internal State제이든호출_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제이든호출_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든호출_StopCinematic : TriggerState {
            internal State제이든호출_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster체크 : TriggerState {
            internal StateMonster체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105, 106, 107, 108, 109})) {
                    return new StateMonster추가Spawn01(context);
                }

                if (context.MonsterDead(spawnIds: new []{105})) {
                    return new StateMonster추가Spawn105(context);
                }

                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateMonster추가Spawn106(context);
                }

                if (context.MonsterDead(spawnIds: new []{107})) {
                    return new StateMonster추가Spawn107(context);
                }

                if (context.MonsterDead(spawnIds: new []{108})) {
                    return new StateMonster추가Spawn108(context);
                }

                if (context.MonsterDead(spawnIds: new []{109})) {
                    return new StateMonster추가Spawn109(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Spawn01 : TriggerState {
            internal StateMonster추가Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105, 106, 107, 108, 109}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105, 106, 107, 108, 109})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Spawn105 : TriggerState {
            internal StateMonster추가Spawn105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105})) {
                    return new StateMonster추가Spawn106(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Spawn106 : TriggerState {
            internal StateMonster추가Spawn106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{106}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateMonster추가Spawn107(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Spawn107 : TriggerState {
            internal StateMonster추가Spawn107(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{107}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{107})) {
                    return new StateMonster추가Spawn108(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Spawn108 : TriggerState {
            internal StateMonster추가Spawn108(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{108}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{108})) {
                    return new StateMonster추가Spawn109(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Spawn109 : TriggerState {
            internal StateMonster추가Spawn109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{109}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{109})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하첫SpawnCinematic_Wait : TriggerState {
            internal State세리하첫SpawnCinematic_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.DestroyMonster(spawnIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 112, 121, 122, 131, 132, 133});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하첫SpawnCinematic_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하첫SpawnCinematic_Prepare : TriggerState {
            internal State세리하첫SpawnCinematic_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52020004, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하첫SpawnCinematic_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하첫SpawnCinematic_시작 : TriggerState {
            internal State세리하첫SpawnCinematic_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8015}, returnView: false);
                context.SetSceneSkip(state: new State세리하첫SpawnCinematic_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State탐색실패01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탐색실패01 : TriggerState {
            internal State탐색실패01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8015}, returnView: false);
                context.AddBalloonTalk(spawnId: 0, msg: "흐음….", duration: 2000, delayTick: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State탐색실패02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탐색실패02 : TriggerState {
            internal State탐색실패02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003541, illustId: "Jaiden_normal", script: @"단서가 될 만한 게 없는 건지, 있는데도 모르겠는 건지.\n답답하네, 좀.", duration: 3000);
                context.MoveUserPath(patrolName: "PC_walkinCenter");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn01 : TriggerState {
            internal State흑성회Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121, 122}, arg2: false);
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: "그럼, 답답한 사람들끼리 이야기를 좀 해보면 어떨까?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn02 : TriggerState {
            internal State흑성회Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8020}, returnView: false);
                context.MoveNpc(spawnId: 121, patrolName: "Weihong_walkin01");
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: "알고 있는 것을 나누면, 목표에 보다 빨리 다가갈 수 있을 테니.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn03 : TriggerState {
            internal State흑성회Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8021}, returnView: false);
                context.MoveNpc(spawnId: 122, patrolName: "Seriha_walkin01");
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: @"크리티아스의 왕족.\n너희가 찾고 있는 건 바로 그들의 행적 아닌가.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn04 : TriggerState {
            internal State흑성회Spawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: @"아마 이곳에 들어온 모두가 그들을 찾고 있을 거야.\n흑성회도 마찬가지다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회Spawn05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn05 : TriggerState {
            internal State흑성회Spawn05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: @"과연 누가 가장 먼저 목적을 이루게 될까… 궁금하지 않나?\n물론, 나는 정답을 알 것 같지만.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC독백01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC독백01 : TriggerState {
            internal StatePC독백01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{131, 132, 133}, arg2: false);
                context.CameraSelectPath(pathIds: new []{8015}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "(흑성회라니… 일이 생각보다 복잡하게 돌아가는 것 같다.)", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레지스탕스Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스Spawn01 : TriggerState {
            internal State레지스탕스Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8030}, returnView: false);
                context.AddCinematicTalk(npcId: 11003663, script: "생각하고 계시는 그 답이 정답이 맞을까요, 영감님?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레지스탕스Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스Spawn02 : TriggerState {
            internal State레지스탕스Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003661, script: "틀렸을 것 같은데?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레지스탕스Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스Spawn03 : TriggerState {
            internal State레지스탕스Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003662, script: "우리도 여기까지 힘들게 왔는데, 빈 손으로 갈 수는 없잖아요.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레지스탕스Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스Spawn04 : TriggerState {
            internal State레지스탕스Spawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003662, script: @"우리 등장이 좀 밋밋했죠?\n멋있게 등장하도록 연출 보강 예정이니 참고해 주세요.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하Spawn01 : TriggerState {
            internal State세리하Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: @"불청객이 많아서 그런가, 좀 시끄럽군.\n나는 시끄러운 건 영 체질에 안 맞는단 말이야.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하Spawn02 : TriggerState {
            internal State세리하Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003659, illustId: "WeiHong_normal", script: "$npc:11003660$, 정리해라.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하Spawn03 : TriggerState {
            internal State세리하Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 122, patrolName: "Seriha_walkinto");
                context.ShowCaption(type: CaptionType.Name, title: "$npc:11003660$", script: "흑성회 특수부대장, $npc:11003659$의 측근", align: Align.Center | Align.Left, offsetRateX: 0.5f, offsetRateY: 0.15f, duration: 5000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하Spawn04 : TriggerState {
            internal State세리하Spawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8023}, returnView: false);
                context.AddCinematicTalk(npcId: 11003660, illustId: "Seriha_normal", script: "네, 보스.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이든경고01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든경고01 : TriggerState {
            internal State제이든경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8015}, returnView: false);
                context.MoveNpc(spawnId: 111, patrolName: "Jaiden_whispertoPC");
                context.AddCinematicTalk(npcId: 11003541, illustId: "Jaiden_normal", script: "도망가자.", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이든경고02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든경고02 : TriggerState {
            internal State제이든경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "갑자기 그게 무슨 소리…", duration: 2000, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003541, illustId: "Jaiden_normal", script: @"$npcName:11003660$$pp:가,이$ 나선 이상, 이제 여긴 불지옥이 될거야.\n시간 없어. 빨리.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC제이든과도망(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC제이든과도망 : TriggerState {
            internal StatePC제이든과도망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddBalloonTalk(spawnId: 111, msg: "저쪽으로. 서둘러…!", duration: 2000, delayTick: 0);
                context.MoveNpc(spawnId: 111, patrolName: "Jaiden_run");
                context.MoveUserPath(patrolName: "PC_run");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하공격Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하공격Prepare : TriggerState {
            internal State세리하공격Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8023}, returnView: false);
                context.AddCinematicTalk(npcId: 11003660, illustId: "Seriha_normal", script: "입만 산 것들. 깨끗하게 정리해 주마.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자막구간_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_Prepare : TriggerState {
            internal State자막구간_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State자막구간_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_01 : TriggerState {
            internal State자막구간_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: @"제이든과 함께 그곳을 빠져나오던 순간\n들려왔던 어마어마한 소리.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State자막구간_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_02 : TriggerState {
            internal State자막구간_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: @"왕족의 비상상황을 대비해 견고하게 지어졌을 지하실 내부는\n순식간에 굉음을 내며 무너져 내렸다.");
                context.SetSkip(state: new State자막구간_03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State자막구간_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_03 : TriggerState {
            internal State자막구간_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: @"나는 달려야 했다.\n오직 살아남는 것만을 생각하면서.");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State세리하첫SpawnCinematic_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하첫SpawnCinematic_스킵완료 : TriggerState {
            internal State세리하첫SpawnCinematic_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하첫SpawnCinematic_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하첫SpawnCinematic_종료 : TriggerState {
            internal State세리하첫SpawnCinematic_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "BlackStarVSResistance");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinal맵이동 : TriggerState {
            internal StateFinal맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020005, portalId: 10);
                context.VisibleMyPc(visible: false);
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
