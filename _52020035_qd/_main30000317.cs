namespace Maple2.Trigger._52020035_qd {
    public static class _main30000317 {
        public class Stateidle2 : TriggerState {
            internal Stateidle2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {30000317}, arg3: new byte[] {1})) {
                    context.State = new State연출시작2(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {30000317}, arg3: new byte[] {2})) {
                    context.State = new StateSkip_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작2 : TriggerState {
            internal State연출시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작3 : TriggerState {
            internal State연출시작3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52020035, arg2: 6001);
                context.CreateMonster(arg1: new[] {110}, arg2: false, arg3: 0);
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State라딘과대화시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘과대화시작 : TriggerState {
            internal State라딘과대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "exit");
                context.AddCinematicTalk(npcId: 11003753, msg: "자네도 알겠지만 수호군이 크리티아스에 쉽게 오지는 못할걸세.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003753, msg: @"지원군을 소집하는데도 시간이 걸리겠지만\n우리가 포털 수리 및 방어 시스템을 무력화시키지 않는다면\n결국 또 다른 많은 희생을 치루게 되겠지.", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new State라딘과대화시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘과대화시작_02 : TriggerState {
            internal State라딘과대화시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4027}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "그렇다면 저희가 나서서 수호군이 안전하게 올 수 있도록 조치를 취해야겠군요.", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State라딘과대화시작_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘과대화시작_03 : TriggerState {
            internal State라딘과대화시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: @"그렇지. 게다가 자네가 얘기해준 티어스 코어라는 물건에 대해서도 빨리 정보를 찾아\n왜 어둠의 세력이 그것을 노리고 있는지도 알아내야 하고 말이야.", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State라딘과대화시작_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘과대화시작_04 : TriggerState {
            internal State라딘과대화시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4027}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "해야할 일이 많네요… 이럴 때 수호군의 동료들이 있었다면…", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State라딘과대화시작_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘과대화시작_05 : TriggerState {
            internal State라딘과대화시작_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: @"그래서 우리를 도와줄만한 사람들에게 연락을 취해두었네.\n곧 도착할 시간인데…", duration: 4000);
                context.MoveUser(arg1: 52020035, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State흑성회다같이입장1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회다같이입장1 : TriggerState {
            internal State흑성회다같이입장1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcRotation(arg1: 110, arg2: -45);
                context.AddCinematicTalk(npcId: 11003753, msg: "아. 마침 저기 들어오는군.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: @"<font size='40'>!!! 저 녀석들은?</font>", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State카메라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {111}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {115}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {112}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {113}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {114}, arg2: false, arg3: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State간부얼굴준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State간부얼굴준비 : TriggerState {
            internal State간부얼굴준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4010, 4011}, arg2: false);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_3007");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_3006");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_3004");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_3005");
                context.SetOnetimeEffect(id: 9, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, msg: @"<font size='40'>흑성회?!</font>", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State하렌(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하렌 : TriggerState {
            internal State하렌(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4012}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 113, arg2: "Bore_A");
                context.ShowCaption(type: "VerticalCaption", title: "하렌", desc: "흑성회 제 3 간부", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카일(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일 : TriggerState {
            internal State카일(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4024}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 114, arg2: "Bore_B");
                context.ShowCaption(type: "VerticalCaption", title: "카일", desc: "흑성회 제 4 간부", align: "centerRight", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State브리드민(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State브리드민 : TriggerState {
            internal State브리드민(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 115, arg2: "Bore_B");
                context.ShowCaption(type: "VerticalCaption", title: "브리드 민", desc: "흑성회 제 5 간부", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State바사라첸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바사라첸 : TriggerState {
            internal State바사라첸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4025}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 112, arg2: "Bore_A");
                context.ShowCaption(type: "VerticalCaption", title: "바사라첸", desc: "흑성회 제 2 간부", align: "centerRight", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State웨이홍(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이홍 : TriggerState {
            internal State웨이홍(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 111, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003754, msg: @"여어~ $MyPCName$, 용케도 살아있었군.\n정말 그 끈질긴 생명력은 칭찬하지 않을 수 없군 그래.", duration: 4000);
                context.ShowCaption(type: "VerticalCaption", title: "웨이홍", desc: "흑성회 보스", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State흑성회와의동맹에대하여(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여 : TriggerState {
            internal State흑성회와의동맹에대하여(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4029}, arg2: false);
                context.FaceEmotion(spwnPointId: false, emotionName: "defaultBattle");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "흑성회 놈들! 이번에야말로…!", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State흑성회와의동맹에대하여1_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여1_2 : TriggerState {
            internal State흑성회와의동맹에대하여1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: "진정하게. 저들이 바로 내가 도움을 요청했다는 자들일세.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State흑성회와의동맹에대하여1_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여1_3 : TriggerState {
            internal State흑성회와의동맹에대하여1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4029}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
                context.AddCinematicTalk(npcId: 0, msg: @"<font size='40'>!!! 뭐라고요?</font>", duration: 2000);
                context.AddCinematicTalk(npcId: 0, msg: "저들에게 도움을 요청하다니, 도대체 무슨 생각이신거죠!", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State흑성회와의동맹에대하여2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여2 : TriggerState {
            internal State흑성회와의동맹에대하여2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, msg: @"제법 똑똑한 녀석인줄 알았는데 이제보니 영 머리가 안굴러 가는 녀석이군.\n세상물정 모르는 꼬맹이같으니라고.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State흑성회와의동맹에대하여3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여3 : TriggerState {
            internal State흑성회와의동맹에대하여3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4028, arg2: true);
                context.AddCinematicTalk(npcId: 11003753, msg: @"$MyPCName$, 자네의 마음은 이해하네.\n자네 말대로 흑성회는 신뢰할 수없는, 적이나 다름없는 이들이지.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003753, msg: @"그러나 지금은 냉정하게 판단할 때일세.\n지금 우리는 자원도 부족하고 아무런 지원도 받을 수 없는 상황이네.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003753, msg: @"누군가의 힘을 빌려 수호군이 안전하게 크리티아스에 도착하고\n어둠의 세력으로부터 이곳을 지켜낼 수만 있다면…", duration: 4000);
                context.AddCinematicTalk(npcId: 11003753, msg: "설령 그것이 흑성회라 할지라도 지금은 손을 잡아야 하지 않겠나?", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    context.State = new State흑성회와의동맹에대하여4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여4 : TriggerState {
            internal State흑성회와의동맹에대하여4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4029, arg2: true);
                context.AddCinematicTalk(npcId: 0, msg: "……네, 알겠습니다.", duration: 2000);
                context.AddCinematicTalk(npcId: 0, msg: @"하지만 언제 우리를 배신할지 모르는 자들이에요.\n절대 경계를 늦춰서는 안될 겁니다.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State흑성회와의동맹에대하여5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회와의동맹에대하여5 : TriggerState {
            internal State흑성회와의동맹에대하여5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4028, arg2: true);
                context.AddCinematicTalk(npcId: 11003753, msg: @"이해해줘서 고맙군.\n그럼 웨이 홍, 약속한 정보는 가져왔나?", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State정보전달하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기 : TriggerState {
            internal State정보전달하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, msg: @"뭐, 징징거리는 어린아이는 다 달랜 것 같으니…\n본격적으로 거래를 시작해보자구.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, msg: @"선불을 하는 취미는 없지만 호의를 베풀어 먼저 알려주도록 하지.\n의심많은 녀석의 입도 다물게 할겸. 후후.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, msg: @"일단 우리 쪽에서 입수한 정보에 따르면 크리티아스의 방어 시스템은\n티아만 에너지 포트라는 곳에서 제어되고 있다고 한다.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State정보전달하기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기_02 : TriggerState {
            internal State정보전달하기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: @"티아만 에너지 포트라…\n내 기억이 맞다면 최신식 장비들을 연구, 생산해내는\n크리티아스의 첨단 개발지역이었던 것으로 기억하네.", duration: 5000);
                context.AddCinematicTalk(npcId: 11003753, msg: @"유학시절 방문해보고 싶었지만 크리티아스의 기술력이 집약된 장소라\n외부인에게는 접근 자체가 불가능한 지역이었지.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, msg: @"왕족 나으리의 호사스런 유학 생활 이야기는 관심없고,\n그곳을 장악하지 못하면 수호군 녀석들의 크리티아스 소풍은 포기해야할거야.", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new State정보전달하기_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기_03 : TriggerState {
            internal State정보전달하기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4029}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: @"더 들을 필요도 없는 것 같군요.\n서둘러 티아만 에너지 포트로 가서 방어 시스템을 무력화시키죠.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State정보전달하기_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기_04 : TriggerState {
            internal State정보전달하기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, msg: @"어이어이, 애송이. 서두르지 말라고?\n아직 중요한 얘기가 하나 더 있으니깐 말이야.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State정보전달하기_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기_05 : TriggerState {
            internal State정보전달하기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: "티어스 코어에 대한건가?", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State정보전달하기_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기_06 : TriggerState {
            internal State정보전달하기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, msg: @"크리티아스의 방어 시스템, 그리고 티어스 코어라는 물건에 대한 정보.\n그게 거래조건이었으니 당연히 알아봤지.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, msg: @"그런데 그 티어스 코어라는 물건말이야…\n정확하게 어디에 쓰는 것인지는 몰라도 보통 물건은 아닌 것 같더군.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, msg: @"헤카톤 왕이 직접 개발한 장치라는데 티마이온?\n아무튼 무슨 거대 장치의 동력원으로 사용되었다고 하더군.", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State정보전달하기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기2 : TriggerState {
            internal State정보전달하기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.AddBalloonTalk(msg: "!!!", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 110, msg: "!!!", duration: 2000, delayTick: 1000);
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정보전달하기3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기3 : TriggerState {
            internal State정보전달하기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003753, msg: "$MyPCName$… 생각보다 상황이 좋지 않을지도 모르겠군…", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "예… 녀석들이 티어스 코어를 노리는 것이 티마이온 때문이라면…", duration: 3000);
                context.AddCinematicTalk(npcId: 11003753, msg: "혹시 티어스 코어에 대한 정보는 그게 다인가? 어디에 있다던지 하는건…", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State정보전달하기3_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기3_1 : TriggerState {
            internal State정보전달하기3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, msg: @"이봐 라딘 사장, 이것도 정말 어렵게 얻은 정보라고.\n이 정도면 충분히 거래조건을 지킨 것 같은데?", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State정보전달하기3_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기3_2 : TriggerState {
            internal State정보전달하기3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: "알겠네. 잠시 $MyPCName$와 얘기 좀 할테니 기다려주게나.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State정보전달하기4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정보전달하기4 : TriggerState {
            internal State정보전달하기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "MeetRadin");
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115});
                context.CreateMonster(arg1: new[] {117}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {118}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {119}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {120}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {121}, arg2: false, arg3: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115});
                context.CreateMonster(arg1: new[] {117}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {118}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {119}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {120}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {121}, arg2: false, arg3: 0);
                context.SetProductionUI(arg1: 4);
                context.CameraReset(interpolationTime: 0f);
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "MeetRadin");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {110});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}