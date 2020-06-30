using System;

namespace Maple2.Trigger._52020030_qd {
    public static class _main30000335 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장1(context);

        private class State입장1 : TriggerState {
            internal State입장1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetOnetimeEffect(id: 300, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 301, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2003}, arg2: new int[] {30000335},
                    arg3: new byte[] {1})) {
                    context.State = new State투르카이오네연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카이오네연출시작 : TriggerState {
            internal State투르카이오네연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.DestroyMonster(arg1: new int[] {111});
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.MoveUser(arg1: 52020030, arg2: 6004);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카이오네연출시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카이오네연출시작_02 : TriggerState {
            internal State투르카이오네연출시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State투르카의등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카의등장 : TriggerState {
            internal State투르카의등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4031}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003762, msg: "천공의 심장을 손에 넣었군.", duration: 3000);
                context.SetSceneSkip(arg1: "공명준비", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State투르카의등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카의등장_01 : TriggerState {
            internal State투르카의등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_B");
                context.AddCinematicTalk(npcID: 11003762, msg: "이리 가져와라. 크란츠.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State투르카의등장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카의등장02 : TriggerState {
            internal State투르카의등장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4019}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003761, msg: "어디서 감히 명령이지?", duration: 3000);
                context.AddCinematicTalk(npcID: 11003761, msg: "나에게 명령을 내릴 수 있는 자는 오직 이오네 왕녀님 뿐이다.", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Quest_Frustration_A", arg3: 9500f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 12000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State투르카의등장03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카의등장03 : TriggerState {
            internal State투르카의등장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003760, msg: "크란츠... 지금은 이 자의 말을 듣도록 해.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003760, msg: "천공의 심장을 이리로.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State투르카의등장04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카의등장04 : TriggerState {
            internal State투르카의등장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4019}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003761, msg: "... 넵. 왕녀님", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State반대하는플레이어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어 : TriggerState {
            internal State반대하는플레이어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4025}, arg2: 0);
                context.FaceEmotion(spawnPointID: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcID: 0, msg: @"천공의 심장을 넘기면 안돼!\n투르카가 티마이온을!!!", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State반대하는플레이어02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어02 : TriggerState {
            internal State반대하는플레이어02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4019, 4035}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003761, msg: @"어쩔 수 없어.\n모든 것은 왕녀님을 위해...", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State반대하는플레이어03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어03 : TriggerState {
            internal State반대하는플레이어03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4036}, arg2: 0);
                context.MoveNpc(arg1: 109, arg2: "MS2PatrolData_3002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State반대하는플레이어04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반대하는플레이어04 : TriggerState {
            internal State반대하는플레이어04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4025}, arg2: 0);
                context.FaceEmotion(spawnPointID: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcID: 0, msg: "안돼!!!", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State크란츠이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크란츠이동 : TriggerState {
            internal State크란츠이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[] {109});
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State크란츠이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크란츠이동_02 : TriggerState {
            internal State크란츠이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {4037}, arg2: 0);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_3005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State크란츠이동_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크란츠이동_03 : TriggerState {
            internal State크란츠이동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11003760, msg: "수고했어요, 크란츠.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003761, msg: "왕녀님의 말씀이라면...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State공명준비이오네(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명준비이오네 : TriggerState {
            internal State공명준비이오네(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {105});
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4031}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003762, msg: @"자, 그럼 이오네.\n파멸의 날개에 천공의 심장을 공명시켜라.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공명준비이오네_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명준비이오네_02 : TriggerState {
            internal State공명준비이오네_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003760, msg: @"알았어.\n바로 시작하도록 하지.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공명준비이오네03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명준비이오네03 : TriggerState {
            internal State공명준비이오네03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Quest_Spell_A");
                context.AddCinematicTalk(npcID: 11003760, msg: "파멸의 날개여, 마법의 힘을 받아들여라.", duration: 3000);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공명준비이오네04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명준비이오네04 : TriggerState {
            internal State공명준비이오네04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4034}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Quest_Resonance_A", arg3: 1200000000f);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetEffect(arg1: new int[] {5007}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State투르카공격준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카공격준비 : TriggerState {
            internal State투르카공격준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4031}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003762, msg: "크하하.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003762, msg: "계획대로 되어가는군.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003762, msg: "자 그럼... 이제 방해꾼을 처리해 보도록 할까.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State투르카공격준비_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카공격준비_1 : TriggerState {
            internal State투르카공격준비_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.DestroyMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State투르카공격준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카공격준비01 : TriggerState {
            internal State투르카공격준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4021}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Attack_02_C");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 300, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcID: 11003762, msg: @"너 따위는 내가 직접 나설 것도 없지.\n이 곳에서 영원히 잠들어라.",
                    duration: 3000);
                context.AddCinematicTalk(npcID: 11003762, msg: "나와라. 어둠의 그림자들이여...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State투르카공격준비03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카공격준비03 : TriggerState {
            internal State투르카공격준비03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 400, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(arg1: new int[] {4032, 4033}, arg2: 0);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Bore_A", arg3: 100000f);
                context.CreateMonster(arg1: new int[] {501}, arg2: true);
                context.CreateMonster(arg1: new int[] {502}, arg2: true);
                context.CreateMonster(arg1: new int[] {503}, arg2: true);
                context.CreateMonster(arg1: new int[] {504}, arg2: true);
                context.CreateMonster(arg1: new int[] {505}, arg2: true);
                context.CreateMonster(arg1: new int[] {506}, arg2: true);
                context.CreateMonster(arg1: new int[] {507}, arg2: true);
                context.CreateMonster(arg1: new int[] {508}, arg2: true);
                context.CreateMonster(arg1: new int[] {509}, arg2: true);
                context.CreateMonster(arg1: new int[] {510}, arg2: true);
                context.CreateMonster(arg1: new int[] {511}, arg2: true);
                context.CreateMonster(arg1: new int[] {512}, arg2: true);
                context.CreateMonster(arg1: new int[] {513}, arg2: true);
                context.CreateMonster(arg1: new int[] {514}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State투르카공격준비04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카공격준비04 : TriggerState {
            internal State투르카공격준비04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카공격준비05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카공격준비05 : TriggerState {
            internal State투르카공격준비05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020030, arg2: 6005);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 300, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "투르카의 부하들을 처치하세요.", arg3: new int[] {2000}, arg4: "0");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.DestroyMonster(arg1: new int[] {104});
                context.CameraReset(interpolationTime: 0f);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514})) {
                    context.State = new State공명완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료 : TriggerState {
            internal State공명완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공명완료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료02 : TriggerState {
            internal State공명완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 301, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Bore_A", arg3: 100000f);
                context.AddCinematicTalk(npcID: 11003760, msg: @"공명이 완료 되었어.\n다음 재료를 찾으러 이동 해야해.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003762, msg: "후후. 빠르군.", duration: 3000);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State공명완료02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료02_01 : TriggerState {
            internal State공명완료02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4039}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003761, msg: @"왕녀님, 몸음 괜찮으신 겁니까. \n혹시 무리라도 하신건...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State공명완료02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료02_02 : TriggerState {
            internal State공명완료02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11003760, msg: "난 괜찮아 크란츠. ", duration: 3000);
                context.AddCinematicTalk(npcID: 11003760, msg: "투르카, 어서 다음 재료의 장소로 이동을.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State공명완료02_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료02_03 : TriggerState {
            internal State공명완료02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Bore_A", arg3: 100000f);
                context.AddCinematicTalk(npcID: 11003762, msg: "자, 그럼 이동해볼까.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State공명완료03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료03 : TriggerState {
            internal State공명완료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {110});
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.MoveUser(arg1: 52020030, arg2: 6005);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공명완료03_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료03_01 : TriggerState {
            internal State공명완료03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4038}, arg2: 0);
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.FaceEmotion(spawnPointID: 0, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 8000f);
                context.AddCinematicTalk(npcID: 0, msg: "이럴수가...", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "이오네 왕녀가 투르카와 손을 잡다니...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State공명완료04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료04 : TriggerState {
            internal State공명완료04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcID: 11003753, msg: "자네... 무사했군....", duration: 3000);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State공명완료05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공명완료05 : TriggerState {
            internal State공명완료05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetAchievement(arg1: 2003, arg2: "trigger", arg3: "SkyTower");
                context.DestroyMonster(arg1: new int[] {107});
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}