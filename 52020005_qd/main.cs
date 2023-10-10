namespace Maple2.Trigger._52020005_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
            }

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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{2})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new StatePC내보내기Cinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001772}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001772}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001772}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001771}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001771}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001771}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001770}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001770}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001770}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State첫만남_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{1})) {
                    return new State돌아가_Wait(context);
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

        private class State돌아가_Wait : TriggerState {
            internal State돌아가_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new State지하피난처로돌아가(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하피난처로돌아가 : TriggerState {
            internal State지하피난처로돌아가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020004, portalId: 1);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State지하피난처로돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫만남_Wait : TriggerState {
            internal State첫만남_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State첫만남_StartCinematic(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{2})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new StatePC내보내기Cinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new StatePC내보내기Cinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new StatePC내보내기Cinematic_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001773}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫만남_StartCinematic : TriggerState {
            internal State첫만남_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State일어나00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나00 : TriggerState {
            internal State일어나00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020005, portalId: 10);
                context.SetSceneSkip(state: new State일어나_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State일어나01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나01 : TriggerState {
            internal State일어나01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003667, illustId: "Krantz_normal", script: @"이봐. 눈을 떠 봐.\n정신이 드나?", duration: 2000);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State일어나02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나02 : TriggerState {
            internal State일어나02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003572, illustId: "Eone_normal", script: "흠, 부상은 크지 않은 것 같은데.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State일어나03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나03 : TriggerState {
            internal State일어나03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003667, illustId: "Krantz_normal", script: @"그렇다면, 빠르게 정신이 들도록…\n(스르릉, 하고 들려오는 이 소리는… 검을 뽑는 소리…?)", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State일어나04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나04 : TriggerState {
            internal State일어나04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003572, illustId: "Eone_normal", script: "그 검으로 찌르면 정신이 들자마자 저 세상으로 가고 말걸.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Sleep_Idle_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State일어나05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나05 : TriggerState {
            internal State일어나05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003667, illustId: "Krantz_normal", script: @"이 자의 운명이라면 받아들여야 할 터…. \n그것이 세상의 아름다운 섭리입니다.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State일어나06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나06 : TriggerState {
            internal State일어나06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "(빨리 일어나지 않으면 목숨이 위험할 것 같다. 어서 일어나자.)", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State일어나07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나07 : TriggerState {
            internal State일어나07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003572, illustId: "Eone_normal", script: "…눈을 떴군.", duration: 2000);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Surprise_A", duration: 3000f);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State일어나_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나_스킵완료 : TriggerState {
            internal State일어나_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State일어나_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어나_StopCinematic : TriggerState {
            internal State일어나_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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

        private class StatePC내보내기Cinematic_Wait : TriggerState {
            internal StatePC내보내기Cinematic_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52020005, portalId: 10);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StatePCExit_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC내보내기Cinematic_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC내보내기Cinematic_시작 : TriggerState {
            internal StatePC내보내기Cinematic_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Walkout");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.AddCinematicTalk(npcId: 11003572, illustId: "Eone_normal", script: "이 연출은 제작 중이다. ", duration: 3000);
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
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Eone");
                context.AddCinematicTalk(npcId: 11003667, illustId: "Krantz_normal", script: "그렇다. 제작 중이다.", duration: 3000);
                context.VisibleMyPc(visible: false);
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
                context.AddCinematicTalk(npcId: 11003572, illustId: "Eone_normal", script: "기다려 달라.", duration: 3000);
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
                context.AddCinematicTalk(npcId: 11003667, illustId: "Krantz_normal", script: "그렇다. 좀 기다려 달라.", duration: 3000);
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
                context.AddCinematicTalk(npcId: 11003572, illustId: "Eone_normal", script: "1월까지 완료될 것이다.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCExit_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCExit_스킵완료 : TriggerState {
            internal StatePCExit_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCExit_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCExit_StopCinematic : TriggerState {
            internal StatePCExit_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "PrincessAndHerKnight");
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
                context.MoveUser(mapId: 02020013, portalId: 10);
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
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
