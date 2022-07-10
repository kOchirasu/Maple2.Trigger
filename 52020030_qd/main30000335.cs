namespace Maple2.Trigger._52020030_qd {
    public static class _main30000335 {
        public class State입장1 : TriggerState {
            internal State입장1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5007, 5006}, visible: false);
                context.SetOnetimeEffect(id: 300, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 301, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2003}, questIds: new []{30000335}, questStates: new byte[]{1})) {
                    return new State투르카이오네StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카이오네StartCinematic : TriggerState {
            internal State투르카이오네StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{109}, arg2: false);
                context.DestroyMonster(spawnIds: new []{111});
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.MoveUser(mapId: 52020030, portalId: 6004);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카이오네StartCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카이오네StartCinematic_02 : TriggerState {
            internal State투르카이오네StartCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{102, 103}, arg2: false);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State투르카의Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카의Spawn : TriggerState {
            internal State투르카의Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4031}, returnView: false);
                context.AddCinematicTalk(npcId: 11003762, script: "천공의 심장을 손에 넣었군.", duration: 3000);
                context.SetSceneSkip(state: new State공명Prepare이오네(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카의Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카의Spawn_01 : TriggerState {
            internal State투르카의Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11003762, script: "이리 가져와라. 크란츠.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카의Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카의Spawn02 : TriggerState {
            internal State투르카의Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4019}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: "어디서 감히 명령이지?", duration: 3000);
                context.AddCinematicTalk(npcId: 11003761, script: "나에게 명령을 내릴 수 있는 자는 오직 이오네 왕녀님 뿐이다.", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Quest_Frustration_A", duration: 9500f);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 12000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State투르카의Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카의Spawn03 : TriggerState {
            internal State투르카의Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.AddCinematicTalk(npcId: 11003760, script: "크란츠... 지금은 이 자의 말을 듣도록 해.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003760, script: "천공의 심장을 이리로.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State투르카의Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카의Spawn04 : TriggerState {
            internal State투르카의Spawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4019}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: "... 넵. 왕녀님", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State반대하는플레이어(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어 : TriggerState {
            internal State반대하는플레이어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4025}, returnView: false);
                context.FaceEmotion(spawnId: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: @"천공의 심장을 넘기면 안돼!\n투르카가 티마이온을!!!", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State반대하는플레이어02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어02 : TriggerState {
            internal State반대하는플레이어02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4019, 4035}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: @"어쩔 수 없어.\n모든 것은 왕녀님을 위해...", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State반대하는플레이어03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어03 : TriggerState {
            internal State반대하는플레이어03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4036}, returnView: false);
                context.MoveNpc(spawnId: 109, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State반대하는플레이어04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어04 : TriggerState {
            internal State반대하는플레이어04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4025}, returnView: false);
                context.FaceEmotion(spawnId: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: "안돼!!!", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠이동 : TriggerState {
            internal State크란츠이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{109});
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠이동_02 : TriggerState {
            internal State크란츠이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4037}, returnView: false);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_3005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State크란츠이동_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠이동_03 : TriggerState {
            internal State크란츠이동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003760, script: "수고했어요, 크란츠.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003761, script: "왕녀님의 말씀이라면...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State공명Prepare이오네(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명Prepare이오네 : TriggerState {
            internal State공명Prepare이오네(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4031}, returnView: false);
                context.AddCinematicTalk(npcId: 11003762, script: @"자, 그럼 이오네.\n파멸의 날개에 천공의 심장을 공명시켜라.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공명Prepare이오네_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명Prepare이오네_02 : TriggerState {
            internal State공명Prepare이오네_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.AddCinematicTalk(npcId: 11003760, script: @"알았어.\n바로 시작하도록 하지.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공명Prepare이오네03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명Prepare이오네03 : TriggerState {
            internal State공명Prepare이오네03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Quest_Spell_A");
                context.AddCinematicTalk(npcId: 11003760, script: "파멸의 날개여, 마법의 힘을 받아들여라.", duration: 3000);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공명Prepare이오네04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명Prepare이오네04 : TriggerState {
            internal State공명Prepare이오네04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4034}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Quest_Resonance_A", duration: 1200000000f);
                context.SetEffect(triggerIds: new []{5004, 5007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State투르카공격Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Prepare : TriggerState {
            internal State투르카공격Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4031}, returnView: false);
                context.AddCinematicTalk(npcId: 11003762, script: "크하하.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003762, script: "계획대로 되어가는군.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003762, script: "자 그럼... 이제 방해꾼을 처리해 보도록 할까.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State투르카공격Prepare_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Prepare_1 : TriggerState {
            internal State투르카공격Prepare_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.DestroyMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카공격Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Prepare01 : TriggerState {
            internal State투르카공격Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4021}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Attack_02_C");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 300, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 11003762, script: @"너 따위는 내가 직접 나설 것도 없지.\n이 곳에서 영원히 잠들어라.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003762, script: "나와라. 어둠의 그림자들이여...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State투르카공격Prepare03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Prepare03 : TriggerState {
            internal State투르카공격Prepare03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 400, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(pathIds: new []{4032, 4033}, returnView: false);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 104, sequenceName: "Bore_A", duration: 100000f);
                context.CreateMonster(spawnIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카공격Prepare04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Prepare04 : TriggerState {
            internal State투르카공격Prepare04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카공격Prepare05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격Prepare05 : TriggerState {
            internal State투르카공격Prepare05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020030, portalId: 6005);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 300, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "투르카의 부하들을 처치하세요.", duration: 2000, boxId: 0);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.DestroyMonster(spawnIds: new []{104});
                context.CameraReset(interpolationTime: 0f);
                context.SetEffect(triggerIds: new []{5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514})) {
                    return new State공명완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료 : TriggerState {
            internal State공명완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공명완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료02 : TriggerState {
            internal State공명완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 301, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Bore_A", duration: 100000f);
                context.AddCinematicTalk(npcId: 11003760, script: @"공명이 완료 되었어.\n다음 재료를 찾으러 이동 해야해.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003762, script: "후후. 빠르군.", duration: 3000);
                context.SetEffect(triggerIds: new []{5004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State공명완료02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료02_01 : TriggerState {
            internal State공명완료02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4039}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: @"왕녀님, 몸음 괜찮으신 겁니까. \n혹시 무리라도 하신건...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State공명완료02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료02_02 : TriggerState {
            internal State공명완료02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003760, script: "난 괜찮아 크란츠. ", duration: 3000);
                context.AddCinematicTalk(npcId: 11003760, script: "투르카, 어서 다음 재료의 장소로 이동을.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State공명완료02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료02_03 : TriggerState {
            internal State공명완료02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Bore_A", duration: 100000f);
                context.AddCinematicTalk(npcId: 11003762, script: "자, 그럼 이동해볼까.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State공명완료03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료03 : TriggerState {
            internal State공명완료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.DestroyMonster(spawnIds: new []{102, 103, 110});
                context.SetEffect(triggerIds: new []{5001, 5002, 5005}, visible: true);
                context.MoveUser(mapId: 52020030, portalId: 6005);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공명완료03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료03_01 : TriggerState {
            internal State공명완료03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4038}, returnView: false);
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.FaceEmotion(spawnId: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 8000f);
                context.AddCinematicTalk(npcId: 0, script: "이럴수가...", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "이오네 왕녀가 투르카와 손을 잡다니...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State공명완료04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료04 : TriggerState {
            internal State공명완료04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4017}, returnView: false);
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003753, script: "자네... 무사했군....", duration: 3000);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State공명완료05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공명완료05 : TriggerState {
            internal State공명완료05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetAchievement(triggerId: 2003, type: "trigger", code: "SkyTower");
                context.DestroyMonster(spawnIds: new []{107});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
