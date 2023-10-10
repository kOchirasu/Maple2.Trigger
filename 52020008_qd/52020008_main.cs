namespace Maple2.Trigger._52020008_qd {
    public static class _52020008_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{9991}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 6001, 6002, 7001, 7002}, visible: false);
                context.SetBreakable(triggerIds: new []{6001, 6002, 7001, 7002}, enabled: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false);
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateCinematicCamera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1 : TriggerState {
            internal StateCinematicCamera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateStopCinematic(context), arg2: "exit");
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
                context.CreateMonster(spawnIds: new []{103}, arg2: false, arg3: 30000);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 503, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematicCamera1_세리하Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_세리하Script1 : TriggerState {
            internal StateCinematicCamera1_세리하Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003660, script: "왕녀는 내가 잘 모실테니 이제 항복하시지?", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicCamera1_크란츠Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_크란츠Script1 : TriggerState {
            internal StateCinematicCamera1_크란츠Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 504, enabled: true);
                context.SetConversation(type: 2, spawnId: 11003675, script: "아름답지 않은 시중을 받을 생각은 없다!!", arg4: 3);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicCamera1_PCScript1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_PCScript1 : TriggerState {
            internal StateCinematicCamera1_PCScript1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enabled: true);
                context.SetConversation(type: 1, spawnId: 0, script: "저녀석은 흑성회의 일원이야! 조심해!", arg4: 3);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Troubled_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicCamera1_이오네Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_이오네Script1 : TriggerState {
            internal StateCinematicCamera1_이오네Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 505, enabled: true);
                context.SetConversation(type: 2, spawnId: 11003674, script: @"시커먼 속내를 가진 건 메이플 연합도 마찬가지 아닌가요? \n크리티아스의 힘은 누구에게도 이용당하게 두지 않겠어요!", arg4: 5);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicCamera1_세리하Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_세리하Script2 : TriggerState {
            internal StateCinematicCamera1_세리하Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 503, enabled: true);
                context.SetConversation(type: 2, spawnId: 11003660, script: @"그 말이 맞는 것 같네?\n세상에 진짜 선과 악은 없는 법이지~", arg4: 3);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Bore_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicCamera1_흑성회Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_흑성회Spawn : TriggerState {
            internal StateCinematicCamera1_흑성회Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enabled: true);
                context.SetConversation(type: 2, spawnId: 11003660, script: "이제 어떻게 하실려나?", arg4: 3);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 104, 105, 106}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicCamera1_탈출장치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_탈출장치 : TriggerState {
            internal StateCinematicCamera1_탈출장치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003675, script: "이오네님 준비하시죠!", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCinematicCamera1_벽부수기세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_벽부수기세팅 : TriggerState {
            internal StateCinematicCamera1_벽부수기세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 507, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematicCamera1_레지스탕스Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_레지스탕스Spawn : TriggerState {
            internal StateCinematicCamera1_레지스탕스Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{9991}, enabled: true);
                context.SetNpcRotation(spawnId: 103, rotation: 270);
                context.DestroyMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematicCamera1_체키Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_체키Script1 : TriggerState {
            internal StateCinematicCamera1_체키Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetConversation(type: 2, spawnId: 11003661, script: "아이고 오늘 정모날인가?", arg4: 3);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematicCamera1_세리하Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_세리하Script3 : TriggerState {
            internal StateCinematicCamera1_세리하Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 504, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6001, 6002, 7001, 7002}, visible: true);
                context.SetBreakable(triggerIds: new []{6001, 6002, 7001, 7002}, enabled: true);
                context.FaceEmotion(spawnId: 103, emotionName: "Trigger_bore1");
                context.SetConversation(type: 2, spawnId: 11003660, script: "아으... 귀찮아.", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematicCamera1_세리하Script4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_세리하Script4 : TriggerState {
            internal StateCinematicCamera1_세리하Script4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.InitNpcRotation(spawnIds: new []{103});
                context.FaceEmotion(spawnId: 103, emotionName: "Trigger_bore2");
                context.SetConversation(type: 2, spawnId: 11003660, script: "왕녀는 또 어디갔어!! 환장하겠네!!", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematicCamera1_체키Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_체키Script2 : TriggerState {
            internal StateCinematicCamera1_체키Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6001, 6002, 7001, 7002}, visible: false);
                context.SetBreakable(triggerIds: new []{6001, 6002, 7001, 7002}, enabled: false);
                context.SetConversation(type: 2, spawnId: 11003661, script: "왕녀는 우리가 접수하겠다. 얘들아 처리해라!", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematicCamera1_체키Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_체키Script3 : TriggerState {
            internal StateCinematicCamera1_체키Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 104, rotation: 180);
                context.SetNpcRotation(spawnId: 105, rotation: 180);
                context.SetNpcRotation(spawnId: 106, rotation: 180);
                context.SetConversation(type: 2, spawnId: 11003661, script: "어서 움직이자!", arg4: 3);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_Chekky");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_Jigmunt");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_Henryte");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematicCamera1_세리하Script5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicCamera1_세리하Script5 : TriggerState {
            internal StateCinematicCamera1_세리하Script5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enabled: true);
                context.SetConversation(type: 1, spawnId: 103, script: "하늘로 솟은거야?? 탑 위에 뭐가 있나 봐야겠어!!", arg4: 3);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_Seriha");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{9991}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6001, 6002, 7001, 7002}, visible: false);
                context.SetBreakable(triggerIds: new []{6001, 6002, 7001, 7002}, enabled: false);
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetVisibleBreakableObject(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, visible: false);
                context.SetBreakable(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, enabled: false);
                context.CameraReset(interpolationTime: 0.1f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028}, visible: false);
            }

            public override TriggerState? Execute() {
                return new StateNPCCreation(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation : TriggerState {
            internal StateNPCCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "세리하를 추적하세요.", duration: 5000);
                context.CreateMonster(spawnIds: new []{211, 212, 213, 214, 215, 216, 217});
            }

            public override TriggerState? Execute() {
                return new StateBattleStart(context);
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 216, patrolName: "MS2PatrolData_Robot_B");
                context.MoveNpc(spawnId: 217, patrolName: "MS2PatrolData_Robot_A");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State계단전투1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단전투1 : TriggerState {
            internal State계단전투1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{221}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new State계단전투2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단전투2 : TriggerState {
            internal State계단전투2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{222}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{211, 212, 213, 214, 215, 216, 217, 221, 222})) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
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
