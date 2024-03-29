namespace Maple2.Trigger._52020022_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 111, 115});
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001791}, questStates: new byte[]{3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001791}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001791}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001790}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001790}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001790}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001784}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001784}, questStates: new byte[]{2})) {
                    return new State세리하_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001784}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001783}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001783}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001783}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001782}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001782}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001782}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001781}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001781}, questStates: new byte[]{2})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001781}, questStates: new byte[]{1})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{3})) {
                    return new StateDefault_Waiting(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
                    return new State아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{1})) {
                    return new State레지스탕스_Wait(context);
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

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001791}, questStates: new byte[]{3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001784}, questStates: new byte[]{2})) {
                    return new State세리하_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
                    return new State아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{1})) {
                    return new State레지스탕스_Wait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_Wait : TriggerState {
            internal State레지스탕스_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102, 103, 104}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{1})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State레지스탕스_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_Prepare : TriggerState {
            internal State레지스탕스_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000, 8001}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State레지스탕스_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_StartCinematic : TriggerState {
            internal State레지스탕스_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State레지스탕스_스킵완료(context), arg2: "exit");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Walkin");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State레지스탕스_체키01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_체키01 : TriggerState {
            internal State레지스탕스_체키01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.AddCinematicTalk(npcId: 11003661, illustId: "Checky_normal", script: "여기 뭐가 있긴 있는 거야?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레지스탕스_헨리테01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_헨리테01 : TriggerState {
            internal State레지스탕스_헨리테01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003662, illustId: "henritte_normal", script: "여기 뭔가 있다는 소문도 사실은 거짓 정보 아니야?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레지스탕스_지그문트01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_지그문트01 : TriggerState {
            internal State레지스탕스_지그문트01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003663, illustId: "sigmund_normal", script: @"아니야. 연출이 있는 건 사실이지만 보강 예정이라고.\n1월 마감 이전에 업데이트한대.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레지스탕스_이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_이동 : TriggerState {
            internal State레지스탕스_이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_Goingout_Checky");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_Goingout_Henritte");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_Goingout_Sigmund");
                context.AddCinematicTalk(npcId: 11003663, illustId: "sigmund_normal", script: "그럼, 조금만 기다려 주시길...", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레지스탕스_마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_마무리 : TriggerState {
            internal State레지스탕스_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102, 103, 104});
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State레지스탕스_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_스킵완료 : TriggerState {
            internal State레지스탕스_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104});
                context.CreateMonster(spawnIds: new []{101});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State레지스탕스_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레지스탕스_StopCinematic : TriggerState {
            internal State레지스탕스_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
                    return new State아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
                    return new State아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001763}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르망_Wait : TriggerState {
            internal State아르망_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101}, arg2: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001780}, questStates: new byte[]{2})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State아르망_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르망_Prepare : TriggerState {
            internal State아르망_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아르망_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르망_StartCinematic : TriggerState {
            internal State아르망_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State아르망_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르망_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르망_Cinematic01 : TriggerState {
            internal State아르망_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010, 8011}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Armand_comingout");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Surprised");
                context.AddCinematicTalk(npcId: 11003672, illustId: "Armand_normal", script: "연출 추가 예정입니다.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르망_마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르망_마무리 : TriggerState {
            internal State아르망_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 111});
                context.CreateMonster(spawnIds: new []{111});
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르망_스킵완료 : TriggerState {
            internal State아르망_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 111});
                context.CreateMonster(spawnIds: new []{111});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_Wait : TriggerState {
            internal State세리하_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 115}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001784}, questStates: new byte[]{2})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_Prepare : TriggerState {
            internal State세리하_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8014}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_StartCinematic : TriggerState {
            internal State세리하_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State세리하_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_Cinematic01 : TriggerState {
            internal State세리하_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8021}, returnView: false);
                context.AddCinematicTalk(npcId: 11003660, illustId: "Seriha_normal", script: "1월 중 연출 보강 예정", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State세리하_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_Cinematic02 : TriggerState {
            internal State세리하_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8014}, returnView: false);
                context.AddCinematicTalk(npcId: 11003672, illustId: "Armand_normal", script: "대사 위주 보강 예정", duration: 4000);
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State세리하_마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_마무리 : TriggerState {
            internal State세리하_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{115});
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_스킵완료 : TriggerState {
            internal State세리하_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{115});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 111, 115}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001791}, questStates: new byte[]{3})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
