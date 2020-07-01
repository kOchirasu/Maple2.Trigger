namespace Maple2.Trigger._52020008_qd {
    public static class _52020008_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {9991}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 6001, 6002, 7001, 7002}, arg2: false);
                context.SetBreakable(arg1: new[] {6001, 6002, 7001, 7002}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    context.State = new State연출카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1 : TriggerState {
            internal State연출카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "연출종료", arg2: "exit");
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false, arg3: 30000);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 503, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출카메라1_세리하대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_세리하대사1 : TriggerState {
            internal State연출카메라1_세리하대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003660, arg3: "왕녀는 내가 잘 모실테니 이제 항복하시지?", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출카메라1_크란츠대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_크란츠대사1 : TriggerState {
            internal State연출카메라1_크란츠대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003675, arg3: "아름답지 않은 시중을 받을 생각은 없다!!", arg4: 3);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출카메라1_PC대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_PC대사1 : TriggerState {
            internal State연출카메라1_PC대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "저녀석은 흑성회의 일원이야! 조심해!", arg4: 3);
                context.SetPcEmotionSequence(arg1: "Emotion_Troubled_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출카메라1_이오네대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_이오네대사1 : TriggerState {
            internal State연출카메라1_이오네대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 505, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003674, arg3: @"시커먼 속내를 가진 건 메이플 연합도 마찬가지 아닌가요? \n크리티아스의 힘은 누구에게도 이용당하게 두지 않겠어요!", arg4: 5);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출카메라1_세리하대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_세리하대사2 : TriggerState {
            internal State연출카메라1_세리하대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 503, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003660, arg3: @"그 말이 맞는 것 같네?\n세상에 진짜 선과 악은 없는 법이지~", arg4: 3);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출카메라1_흑성회등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_흑성회등장 : TriggerState {
            internal State연출카메라1_흑성회등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003660, arg3: "이제 어떻게 하실려나?", arg4: 3);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 104, 105, 106}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출카메라1_탈출장치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_탈출장치 : TriggerState {
            internal State연출카메라1_탈출장치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003675, arg3: "이오네님 준비하시죠!", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State연출카메라1_벽부수기세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_벽부수기세팅 : TriggerState {
            internal State연출카메라1_벽부수기세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 507, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출카메라1_레지스탕스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_레지스탕스등장 : TriggerState {
            internal State연출카메라1_레지스탕스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {9991}, arg2: true);
                context.SetNpcRotation(arg1: 103, arg2: 270);
                context.DestroyMonster(arg1: new[] {101, 102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출카메라1_체키대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_체키대사1 : TriggerState {
            internal State연출카메라1_체키대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003661, arg3: "아이고 오늘 정모날인가?", arg4: 3);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출카메라1_세리하대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_세리하대사3 : TriggerState {
            internal State연출카메라1_세리하대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6001, 6002, 7001, 7002}, arg2: true);
                context.SetBreakable(arg1: new[] {6001, 6002, 7001, 7002}, arg2: true);
                context.FaceEmotion(spawnPointId: 103, emotionName: "Trigger_bore1");
                context.SetConversation(arg1: 2, arg2: 11003660, arg3: "아으... 귀찮아.", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출카메라1_세리하대사4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_세리하대사4 : TriggerState {
            internal State연출카메라1_세리하대사4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.InitNpcRotation(arg1: new[] {103});
                context.FaceEmotion(spawnPointId: 103, emotionName: "Trigger_bore2");
                context.SetConversation(arg1: 2, arg2: 11003660, arg3: "왕녀는 또 어디갔어!! 환장하겠네!!", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출카메라1_체키대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_체키대사2 : TriggerState {
            internal State연출카메라1_체키대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6001, 6002, 7001, 7002}, arg2: false);
                context.SetBreakable(arg1: new[] {6001, 6002, 7001, 7002}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003661, arg3: "왕녀는 우리가 접수하겠다. 얘들아 처리해라!", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출카메라1_체키대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_체키대사3 : TriggerState {
            internal State연출카메라1_체키대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 104, arg2: 180);
                context.SetNpcRotation(arg1: 105, arg2: 180);
                context.SetNpcRotation(arg1: 106, arg2: 180);
                context.SetConversation(arg1: 2, arg2: 11003661, arg3: "어서 움직이자!", arg4: 3);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_Chekky");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_Jigmunt");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_Henryte");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출카메라1_세리하대사5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출카메라1_세리하대사5 : TriggerState {
            internal State연출카메라1_세리하대사5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "하늘로 솟은거야?? 탑 위에 뭐가 있나 봐야겠어!!", arg4: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_Seriha");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {9991}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6001, 6002, 7001, 7002}, arg2: false);
                context.SetBreakable(arg1: new[] {6001, 6002, 7001, 7002}, arg2: false);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetVisibleBreakableObject(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: false);
                context.SetBreakable(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: false);
                context.CameraReset(interpolationTime: 0.1f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC생성 : TriggerState {
            internal StateNPC생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "세리하를 추적하세요.", arg3: 5000);
                context.CreateMonster(arg1: new[] {211, 212, 213, 214, 215, 216, 217});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 216, arg2: "MS2PatrolData_Robot_B");
                context.MoveNpc(arg1: 217, arg2: "MS2PatrolData_Robot_A");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
                    context.State = new State계단전투1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단전투1 : TriggerState {
            internal State계단전투1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {221}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {903})) {
                    context.State = new State계단전투2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단전투2 : TriggerState {
            internal State계단전투2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {222}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {211, 212, 213, 214, 215, 216, 217, 221, 222})) {
                    context.State = new State포탈활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈활성화 : TriggerState {
            internal State포탈활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}