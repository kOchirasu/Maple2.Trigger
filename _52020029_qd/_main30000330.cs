using System;

namespace Maple2.Trigger._52020029_qd {
    public static class _main30000330 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {30000330},
                    arg3: new byte[] {2})) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작1 : TriggerState {
            internal State연출시작1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020029, arg2: 6002);
                context.DestroyMonster(arg1: new int[] {105});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.DestroyMonster(arg1: new int[] {104});
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Quest_Programming", arg3: 15000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작2 : TriggerState {
            internal State연출시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 9000f);
                context.FaceEmotion(spawnPointID: 0, emotionName: "defaultBattle");
                context.AddCinematicTalk(npcID: 11003755, msg: "어떤가요? 사용할 수 있겠어요?", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "절 너무 물로보면 곤란합니다.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003755, msg: "그럼 순서대로 검색해볼까요?", duration: 3000);
                context.SetSceneSkip(arg1: "이동", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State정보검색첫번째(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째 : TriggerState {
            internal State정보검색첫번째(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003755, msg: "티어스 코어에 대해서 검색해 주세요.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정보검색첫번째2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째2 : TriggerState {
            internal State정보검색첫번째2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003717, msg: "데이터 서칭 완료입니다.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "고대 문자라 읽기 어려운데... 내용은 이렇습니다.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State정보검색첫번째2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째2_1 : TriggerState {
            internal State정보검색첫번째2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013, 4010}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003717, msg: "티어스 코어는 티마이온의 에너지 원으로, 강력한 마력의 힘이 담겨 있다.",
                    duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "티어스 코어는 몇 가지의 재료로 조합할 수 있으며, 이 재료는 크리티아스의 사방에 흩어져 있다.",
                    duration: 3000);
                context.AddCinematicTalk(npcID: 11003717,
                    msg: "주 재료가 되는 파멸의 날개는 크리티아스 왕가에 내려져 오는 가보로, 하나는 헤카톤 국왕이, 하나는 왕비가 가지고 있다.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "왕비가 가지고 있던 파멸의 날개는 딸 이오네에게 넘겨졌다.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State정보검색첫번째3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째3 : TriggerState {
            internal State정보검색첫번째3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003717, msg: "파멸의 날개 이외의 재료는 천공의 심장, 신의 눈, 영혼의 구슬, 지혜의 고리이다. ",
                    duration: 3000);
                context.AddCinematicTalk(npcID: 11003717,
                    msg: "천공의 심장은 마력의 숲의 천공의 탑에 보관되어 있으며, 실제적인 티어스 코어의 베이스가 되는 물질이다.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "신의 눈은 티아만 시간의...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State정보검색첫번째3_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째3_1 : TriggerState {
            internal State정보검색첫번째3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 104, emotionName: "dance_S");
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003717, msg: "엇!?", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째4 : TriggerState {
            internal State정보검색첫번째4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Emotion_Troubled_A");
                context.AddCinematicTalk(npcID: 11003717, msg: "으음...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정보검색첫번째4_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째4_2 : TriggerState {
            internal State정보검색첫번째4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3005");
                context.AddCinematicTalk(npcID: 11003755, msg: "무슨일이지요?", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째4_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째4_3 : TriggerState {
            internal State정보검색첫번째4_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003717, msg: "갑자기... 티어스 코어에 대한 정보를 볼수가 없게 되었습니다.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "누군가가... 데이터 접근을 막고 있습니다.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State정보검색첫번째4_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째4_4 : TriggerState {
            internal State정보검색첫번째4_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11003755, msg: "흐음. 누가 접근을 막고 있는건지는 알 수 있을까나?", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "노력은 해보겠지만, 시간이 필요합니다.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "그 외의 정보라면 먼저 검색해 볼 수 있을 것 같습니다.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State정보검색첫번째5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째5 : TriggerState {
            internal State정보검색첫번째5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 20000f);
                context.AddCinematicTalk(npcID: 0, msg: "그렇다면, 제가 먼저 천공의 심장을 찾으러 가겠어요.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째5_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째5_1 : TriggerState {
            internal State정보검색첫번째5_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 9000f);
                context.AddCinematicTalk(npcID: 11003755, msg: "...아무래도 그게 좋겠군요.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째5_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째5_2 : TriggerState {
            internal State정보검색첫번째5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "당신은 같이 안 가나요?", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째5_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째5_3 : TriggerState {
            internal State정보검색첫번째5_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11003755, msg: @"예. 저는 더 찾고 싶은 정보가 있습니다.\n나중에 뵙죠.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째6 : TriggerState {
            internal State정보검색첫번째6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "알겠어요. 더 알게 되는 것이 있으면 알려주세요.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정보검색첫번째7_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째7_1 : TriggerState {
            internal State정보검색첫번째7_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State정보검색첫번째7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째7 : TriggerState {
            internal State정보검색첫번째7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정보검색첫번째8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째8 : TriggerState {
            internal State정보검색첫번째8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003755, msg: "방해꾼이 사라졌군요.", duration: 3000);
                context.AddCinematicTalk(npcID: 11003717, msg: "헤헤. 그럼 이제 뭘 찾으면 될까요?", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State정보검색첫번째8_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째8_1 : TriggerState {
            internal State정보검색첫번째8_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Emotion_Troubled_A");
                context.AddCinematicTalk(npcID: 11003717, msg: "희귀한 보석? 헤카톤 왕의 비밀?", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정보검색첫번째9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째9 : TriggerState {
            internal State정보검색첫번째9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003755, msg: "훗. 찾고 있는 것은 따로 있지.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정보검색첫번째9_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째9_1 : TriggerState {
            internal State정보검색첫번째9_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_B");
                context.FaceEmotion(spawnPointID: 103, emotionName: "Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State정보검색첫번째10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보검색첫번째10 : TriggerState {
            internal State정보검색첫번째10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
                context.FaceEmotion(spawnPointID: 103, emotionName: "Trigger_Bore_03");
                context.AddCinematicTalk(npcID: 11003755, msg: "비밀 병기 프로젝트 아포칼립스...!", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이동_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_1 : TriggerState {
            internal State이동_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이동_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_2 : TriggerState {
            internal State이동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 02020016, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}