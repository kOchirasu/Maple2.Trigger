namespace Maple2.Trigger._52020006_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104});
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001797}, questStates: new byte[]{3})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001797}, questStates: new byte[]{2})) {
                    return new State빈방(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001797}, questStates: new byte[]{1})) {
                    return new State제이든_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{3})) {
                    return new State제이든_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{2})) {
                    return new State제이든_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State세리하와함께전투_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{3})) {
                    return new State세리하_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{2})) {
                    return new State세리하_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State세리하와아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001794}, questStates: new byte[]{3})) {
                    return new State세리하_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하_Wait : TriggerState {
            internal State세리하_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State세리하와함께전투_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State세리하와아르망_Wait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이든_Wait : TriggerState {
            internal State제이든_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State세리하와함께전투_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State세리하와아르망_Wait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈방 : TriggerState {
            internal State빈방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State세리하와함께전투_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State세리하와아르망_Wait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인_Wait01 : TriggerState {
            internal State조건확인_Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State세리하와함께전투_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State세리하와아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
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
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State세리하와함께전투_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State세리하와아르망_Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{3})) {
                    return new State조건확인_Wait01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{2})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new State조건확인_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Wait : TriggerState {
            internal State세리하와아르망_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001795}, questStates: new byte[]{1})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와아르망_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Prepare : TriggerState {
            internal State세리하와아르망_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와아르망_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_StartCinematic : TriggerState {
            internal State세리하와아르망_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State세리하와아르망_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하와아르망_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Cinematic01 : TriggerState {
            internal State세리하와아르망_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", script: "연출 보강 예정", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와아르망_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Cinematic02 : TriggerState {
            internal State세리하와아르망_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddCinematicTalk(npcId: 11003658, illustId: "Armand_normal", script: "조금만 기다려 주세요", duration: 3000);
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와아르망_Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_Cinematic03 : TriggerState {
            internal State세리하와아르망_Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", script: "죄송합니다", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와아르망_마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_마무리 : TriggerState {
            internal State세리하와아르망_마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하와아르망_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_스킵완료 : TriggerState {
            internal State세리하와아르망_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
                context.CreateMonster(spawnIds: new []{101});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와아르망_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와아르망_StopCinematic : TriggerState {
            internal State세리하와아르망_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "Armandsidentity");
                context.VisibleMyPc(visible: true);
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

        private class State세리하와함께전투_Wait : TriggerState {
            internal State세리하와함께전투_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001796}, questStates: new byte[]{1})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와함께전투_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Prepare : TriggerState {
            internal State세리하와함께전투_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{150, 151, 152, 153}, arg2: true);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세리하와함께전투_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_StartCinematic : TriggerState {
            internal State세리하와함께전투_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State세리하와함께전투_전투직전스킵(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세리하와함께전투_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Cinematic01 : TriggerState {
            internal State세리하와함께전투_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", script: "그럼 누가 먼저 저것들을 쓸어버리나 내기하자고.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와함께전투_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Cinematic02 : TriggerState {
            internal State세리하와함께전투_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "임시연출이라 몬스터가 허약할 거야.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와함께전투_Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_Cinematic03 : TriggerState {
            internal State세리하와함께전투_Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.AddCinematicTalk(npcId: 29000335, illustId: "Seriha_normal", script: "간다!", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWaitCombat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_전투직전스킵 : TriggerState {
            internal State세리하와함께전투_전투직전스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105});
                context.CreateMonster(spawnIds: new []{101});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitCombat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitCombat01 : TriggerState {
            internal StateWaitCombat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare01 : TriggerState {
            internal State전투Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{150, 151, 152, 153})) {
                    return new State전투끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8040}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전02 : TriggerState {
            internal State암전02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpc교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc교체01 : TriggerState {
            internal StateNpc교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투후제이든Spawn_SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Spawn_SetupCinematic : TriggerState {
            internal State전투후제이든Spawn_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8020}, returnView: false);
                context.SetSceneSkip(state: new State전투후제이든Spawn_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후제이든Spawn_01_세리하소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Spawn_01_세리하소멸 : TriggerState {
            internal State전투후제이든Spawn_01_세리하소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003548, illustId: "Seriha_normal", script: "내가 이긴 듯. 그럼 이만!", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투후제이든Spawn_02_PC독백(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Spawn_02_PC독백 : TriggerState {
            internal State전투후제이든Spawn_02_PC독백(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{110});
                context.AddCinematicTalk(npcId: 0, illustId: "Seriha_normal", script: "이제 저 너머로 갈 차례인가...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투후제이든Spawn_03_제이든Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Spawn_03_제이든Appear : TriggerState {
            internal State전투후제이든Spawn_03_제이든Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.AddCinematicTalk(npcId: 11003677, illustId: "Jaiden_normal", script: "무사했구나, $MyPCName$.", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세리하와함께전투_제이든Spawn_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후제이든Spawn_스킵완료 : TriggerState {
            internal State전투후제이든Spawn_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 105, 110, 111, 150, 151, 152, 153});
                context.CreateMonster(spawnIds: new []{105});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State세리하와함께전투_StopCinematic(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세리하와함께전투_제이든Spawn_StopCinematic : TriggerState {
            internal State세리하와함께전투_제이든Spawn_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "FightingSeriha");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
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
