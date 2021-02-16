using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020035_qd {
    public static class _main30000316 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000315, 30000316}, arg3: new byte[] {2})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_02 : TriggerState {
            internal StateStartCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {102}, arg2: false, arg3: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘이야기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기01 : TriggerState {
            internal State라딘이야기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSkip01(context), arg2: "exit");
                context.ShowCaption(type: CaptionType.Vertical, title: "라딘의 막사", script: "$MyPCName$$pp:가,이$ 떠난 직후", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State라딘이야기01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기01_01 : TriggerState {
            internal State라딘이야기01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Bore_A", arg3: 3000f);
                context.AddCinematicTalk(npcId: 11003750, script: "…이런 일이 있었다고 합니다.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라딘이야기01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기01_02 : TriggerState {
            internal State라딘이야기01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4013}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: "흠… 크리티아스가 다시 나타난 것은 어둠의 세력과 관련이 있을지도 모르겠군…", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State라딘이야기01_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기01_03 : TriggerState {
            internal State라딘이야기01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003753, script: "그렇다는 것은 확실히 이곳에 중요한 무언가가 있다는 얘기겠지.", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State라딘이야기01_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기01_04 : TriggerState {
            internal State라딘이야기01_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: "수고했네. 덕분에 중요한 정보를 얻게 되었군.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003750, script: "이런 상황을 예측하신 라딘님께서 미리 지시해주신 덕분입니다.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State라딘이야기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기02 : TriggerState {
            internal State라딘이야기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4013}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcId: 11003753, script: "가질, 아무래도 그 자들과 다시 한번 거래를 해야할 것 같으니 연락 좀 해주게.", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State라딘이야기02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기02_01 : TriggerState {
            internal State라딘이야기02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4015}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "ChatUP_A");
                context.AddCinematicTalk(npcId: 11003750, script: "그 자들이라면… 설마 흑성회 녀석들과 다시 거래하실 생각이신겁니까?", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State라딘이야기02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기02_02 : TriggerState {
            internal State라딘이야기02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4013}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: @"분명 신뢰할 수 없는 자들이지만 아직은 이용할 가치가 있어.\n원하는 것을 손에 넣을때까지는 장단을 맞춰줘야지.", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State라딘이야기02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘이야기02_03 : TriggerState {
            internal State라딘이야기02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4016}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: "짓밟아버리는 것은 그 이후에 해도 늦지 않아.", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003750, script: "넵, 분부대로 하겠습니다.", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State화면암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면암전 : TriggerState {
            internal State화면암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State흑성회입장전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회입장전 : TriggerState {
            internal State흑성회입장전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.DestroyMonster(arg1: new[] {101, 102});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State흑성회Spawn직전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn직전 : TriggerState {
            internal State흑성회Spawn직전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "잠시 후, 라딘의 막사", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회입장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회입장 : TriggerState {
            internal State흑성회입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(arg1: new[] {116}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {109}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {104}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {103}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {122}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {123}, arg2: false, arg3: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State흑성회입장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회입장_02 : TriggerState {
            internal State흑성회입장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new[] {4032}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, script: "이런곳까지 불러내다니... 다시봤구만, 나으리.", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State손님맞이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State손님맞이 : TriggerState {
            internal State손님맞이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 109, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State손님맞이_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State손님맞이_01 : TriggerState {
            internal State손님맞이_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003758, script: @"이곳이 바로 역사에서 사라졌던 크리티아스…\n빨리 구경해보고 싶어요!", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State손님맞이_01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State손님맞이_01_01 : TriggerState {
            internal State손님맞이_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_3002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State손님맞이_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State손님맞이_02 : TriggerState {
            internal State손님맞이_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4033}, arg2: false);
                context.AddCinematicTalk(npcId: 11003757, script: @"우린 여기 놀러온게 아니야.\n흑성회의 간부답게 행동해라.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State손님맞이_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State손님맞이_03 : TriggerState {
            internal State손님맞이_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4017}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State손님맞이_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State손님맞이_03_01 : TriggerState {
            internal State손님맞이_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 109, arg2: 90);
                context.SetNpcEmotionSequence(arg1: 109, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003758, script: @"형… 알았어요.\n대신 일이 끝나면 꼭 같이…", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State흑성회와이야기시작01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작01_1 : TriggerState {
            internal State흑성회와이야기시작01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4020}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: @"하하, 흑성회가 자랑하는 천재 전략가가 이런 어린 소년일줄이야.\n과연 웨이 홍이 자랑할만하군.", duration: 3000);
                context.SetNpcRotation(arg1: 109, arg2: -360);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회와이야기시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작02 : TriggerState {
            internal State흑성회와이야기시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4018}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 109, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11003758, script: @"칭찬해주셔서 감사합니다. 당신이 바로 라딘님이시군요.\n과거 트라이아의 검은 사자라고 불리웠던 제1왕위계승자…", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State흑성회와이야기시작02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작02_01 : TriggerState {
            internal State흑성회와이야기시작02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 116, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003757, script: "민, 상대의 도발에 일일이 반응하지마라.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State흑성회와이야기시작02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작02_02 : TriggerState {
            internal State흑성회와이야기시작02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4020}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: @"이런, 거기에 루델리 아레나 최강의 챔피언 바사라 첸이라니.\n이런 귀빈들이 올 줄 알았다면 좀 더 손님맞이를 잘 준비했을텐데.", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State흑성회와이야기시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작03 : TriggerState {
            internal State흑성회와이야기시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003754, script: "능구렁이 같은 모습은 여전하시군. 그 덕에 이번에 뒷통수를 거하게 맞았지.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, script: @"거기에 황송하게도 갑작스러운 초대라니…\n이번엔 또 어떤 기가막힌 선물을 주실지 몰라 흑성회의 간부들을 모두 소집했지.", duration: 5000);
                context.AddCinematicTalk(npcId: 11003754, script: @"그나저나 내가 당신을 너무 높게 평가했던 것 같군.\n천하의 라딘 비드블라임님께서 먼저 꼬리를 말고 기어올 줄이야.", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new State흑성회와이야기시작03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작03_01 : TriggerState {
            internal State흑성회와이야기시작03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4023}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, script: "도대체 무슨 꿍꿍이 속인거지?", duration: 3000);
                context.DestroyMonster(arg1: new[] {109});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State흑성회와이야기시작04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04 : TriggerState {
            internal State흑성회와이야기시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: "자네의 그 경박한 언사는 도저히 고칠 수가 없나 보군.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003753, script: @"아무튼 더 큰 일을 위해서라면 사소한 오해 정도는 아량을 베풀 수 있는 법이니…\n지난 일은 조용히 넘어가주도록 하겠네.", duration: 5000);
                context.AddCinematicTalk(npcId: 11003753, script: "이제라도 제대로 손을 잡고 일 해보는 게 어떤가?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Talk_A", arg3: 5000f);
                context.AddCinematicTalk(npcId: 11003754, script: @"장사 한 두 번 하는 것도 아니고, 그런 말에 내가 속아 넘어갈 것으로 보이시나 보지?\n두 번이나 당할 정도로 이 웨이 홍이 어리석진 않은데 말이야.", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_02 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4020}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 18000f);
                context.AddCinematicTalk(npcId: 11003753, script: "자네의 리소스를 활용하여 우리 연구원들의 안전한 자료 수집 및 조사를 지원한다.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003753, script: @"그리고 이를 통해 나는 사라졌던 크리티아스의 기술력을 손에 넣고\n자네는 우리가 개발할 최첨단 장비들을 제공받는다.", duration: 5000);
                context.AddCinematicTalk(npcId: 11003753, script: @"난 이게 우리의 계약이었던 것으로 기억하네만…\n계약을 어기고 멋대로 이오네 왕녀를 추적한 것은 자네가 먼저였던 것 같은데?", duration: 5000);
                context.AddCinematicTalk(npcId: 11003753, script: "그 덕에 $MyPCName$ 녀석이 일을 이 모양으로 망쳐놓았고 말이야.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_03 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Talk_A", arg3: 10000f);
                context.AddBalloonTalk(spawnPointId: 123, msg: "건방진..", duration: 3000);
                context.AddBalloonTalk(spawnPointId: 122, msg: "감히!", duration: 3000);
                context.AddCinematicTalk(npcId: 11003754, script: @"흥, 기술력을 손에 넣고나면 순순히 약속을 지킬 정도로\n당신이 믿음직한 사람인줄 아나?", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, script: @"우리 입장에서도 보험 하나 정도는 있어야 하는게 당연하지 않나?\n게다가 그 여자가 당신의 말대로 정말 크리티아스의 왕녀라는 보장도 없고 말이야.", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_04 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4020}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003753, script: "훗, 이거이거 내가 이 정도로 신용도가 없는 사람인가 보군.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003753, script: @"그녀가 이오네 왕녀라는 중요한 정보를 자네에게 공유해줄만큼\n난 우리 사이에 어느 정도 신뢰가 있다고 생각했는데 말이야.", duration: 5000);
                context.AddCinematicTalk(npcId: 11003753, script: @"게다가 내가 손을 쓰지 않았다면 벌써 이곳은 이미 수호군의 손아귀에 넘어갔을 걸세.\n이 정도면 나를 믿어줄 이유는 충분하다고 보는데, 어떤가?", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_05 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Talk_A", arg3: 7000f);
                context.AddCinematicTalk(npcId: 11003754, script: "오호~ 그러신가?", duration: 2000);
                context.AddCinematicTalk(npcId: 11003754, script: @"$MyPCName$ 녀석 하나 제대로 못 막아준 덕분에\n공들여 키운 장기말을 써먹을 수가 없는 상황이 되었는데?", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_06 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4020}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: @"진정하고 크게 생각하세나.\n이렇게 서로 싸우기만 하다간 우리 모두 아무런 이득을 보지 못할걸세.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003753, script: @"난 지금 무조건적으로 나를 믿어달라는게 아니야.\n그저 원하는 것을 손에 넣기 위해 서로 돕자는 것이지.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003753, script: "애당초 자네나 나나 이곳에 원하는 것이 있어서 함께 손을 잡았던 것 아닌가?", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_07 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4021}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcId: 11003754, script: @"서로 언제 뒤통수를 칠 지 모르는데도 어쩔 수 없는 동맹이라…\n크큭. 왕족 나리께서 제법 모험도 하시는군.", duration: 4000);
                context.AddCinematicTalk(npcId: 11003754, script: "좋소. 어디 원하는 바를 말해보시지 그래.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State흑성회와이야기시작04_라딘과웨이홍_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_라딘과웨이홍_08 : TriggerState {
            internal State흑성회와이야기시작04_라딘과웨이홍_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4022}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, script: "훗, 이제서야 말이 통하는군.", duration: 2000);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003753, script: "그럼, 계획에 대해서 이야기해 보도록 하지…", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State흑성회와이야기시작04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회와이야기시작04_1 : TriggerState {
            internal State흑성회와이야기시작04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State장면전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장면전환 : TriggerState {
            internal State장면전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State장면전환_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장면전환_02 : TriggerState {
            internal State장면전환_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "MeetRadin");
                context.DestroyMonster(arg1: new[] {103, 104, 109, 122, 123, 116});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마을로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip01 : TriggerState {
            internal StateSkip01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "MeetRadin");
                context.DestroyMonster(arg1: new[] {103, 104, 109, 122, 123, 116});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마을로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마을로이동 : TriggerState {
            internal State마을로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 0f);
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 02020014, arg2: 4);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}