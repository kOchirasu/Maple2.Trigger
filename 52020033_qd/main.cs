using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020033_qd {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{3})) {
                    return new State가버려_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{2})) {
                    return new State가버려_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
                    return new State부유도_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{2})) {
                    return new State소개_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{1})) {
                    return new State소개_Wait(context);
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

        private class StateDefault_Waiting : TriggerState {
            internal StateDefault_Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
                    return new State부유도_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인_Wait01 : TriggerState {
            internal State조건확인_Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
                    return new State부유도_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
                    return new State부유도_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001750}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가버려_Wait : TriggerState {
            internal State가버려_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{3})) {
                    return new State부유도로가버려(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{2})) {
                    return new State부유도로가버려(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001751}, questStates: new byte[]{3})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도로가버려 : TriggerState {
            internal State부유도로가버려(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020001, portalId: 1);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부유도로가버려(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소개_Wait : TriggerState {
            internal State소개_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52020033, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State소개_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소개_Prepare : TriggerState {
            internal State소개_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State소개_세로줌인01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소개_세로줌인01 : TriggerState {
            internal State소개_세로줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000, 8001}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$map:52020033$", script: "크리티아스 정찰 임무 지원 중", align: Align.Center | Align.Left, offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 12000, scale: 2.0f);
                context.SetSceneSkip(state: new State소개_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State소개_가로줌인01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소개_가로줌인01 : TriggerState {
            internal State소개_가로줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002, 8003}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Walking");
                context.AddBalloonTalk(spawnId: 0, msg: "흠…", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 101, msg: "…네, 현재까지 이상 없습니다.", duration: 2000, delayTick: 5);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State소개_완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소개_스킵완료 : TriggerState {
            internal State소개_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52020033, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new StateBattleStart01(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소개_완료 : TriggerState {
            internal State소개_완료(ITriggerContext context) : base(context) { }

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

        private class State부유도_Wait : TriggerState {
            internal State부유도_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52020033, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부유도_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_Prepare : TriggerState {
            internal State부유도_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부유도_탐색01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색01 : TriggerState {
            internal State부유도_탐색01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002, 8003}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Walking");
                context.AddCinematicTalk(npcId: 0, script: @"(함선 아래서부터 들려오는 요란한 소리.\n침입자를 막기 위한 결계, 그리고 방어군과의 전투가 벌어진 듯하다.)", duration: 4000);
                context.SetSceneSkip(state: new State부유도_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State부유도_탐색02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색02 : TriggerState {
            internal State부유도_탐색02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003650, illustId: "Neirin_serious", script: @"…네, 함장님.\n알겠습니다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부유도_탐색03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색03 : TriggerState {
            internal State부유도_탐색03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.AddCinematicTalk(npcId: 11003650, illustId: "Neirin_serious", script: @"$MyPCName$님. 함장님께서는 더 이상의 접근은 어렵다고 판단하셨습니다.\n스카이 포트리스로는요.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부유도_탐색04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색04 : TriggerState {
            internal State부유도_탐색04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003650, illustId: "Neirin_serious", script: @"하지만 비상 탈출에 Success하신다면 크리티아스에 진입할 수는 있을 거예요.\n위험할 수도 있겠지만…", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부유도_탐색05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색05 : TriggerState {
            internal State부유도_탐색05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: @"어떻게든, 저곳에 가야 하니…\n무엇이든 해 보겠습니다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부유도_탐색06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색06 : TriggerState {
            internal State부유도_탐색06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003650, illustId: "Neirin_serious", script: @"탈출용 수송선이 있는 격납고도 공격받고 있고…\n지금으로는 낙하산을 타고 주변 섬으로 내려가 경로를 찾는 방법 뿐이에요.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부유도_탐색07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_탐색07 : TriggerState {
            internal State부유도_탐색07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003650, illustId: "Neirin_serious", script: @"끝까지 지원해 드리지 못해 죄송합니다, $MyPCName$님.\n그럼… 행운을 빕니다!", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자막구간_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_00 : TriggerState {
            internal State자막구간_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8011}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자막구간_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_01 : TriggerState {
            internal State자막구간_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: @"나는 작은 낙하산 하나에 몸을 의지한 채\n짙은 안개 속으로 몸을 던졌다.");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자막구간_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자막구간_02 : TriggerState {
            internal State자막구간_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: @"이방인의 침입을 허락하지 않겠다는 듯 나를 밀어내는 강한 바람…\n이 안개 너머에서는 무슨 일이 벌어지고 있는 것일까.");
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
                context.SetCinematicUI(type: 9, script: @"안개 사이로 찢어진 땅이 보인다….\n저곳으로 내려가, 크리티아스로 들어갈 방법을 찾아보자!");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State부유도_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_스킵완료 : TriggerState {
            internal State부유도_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부유도_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부유도_종료 : TriggerState {
            internal State부유도_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
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
                context.MoveUser(mapId: 52020001, portalId: 1);
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
