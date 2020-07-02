namespace Maple2.Trigger._52000068_qd {
    public static class _tria_seige {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateQuest분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest분기 : TriggerState {
            internal StateQuest분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11010, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 16000, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 16001, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 16002, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16003, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16004, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16005, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16006, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16007, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 16008, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16009, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16010, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16011, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 16012, arg2: false, arg3: "Stun_A");
                context.SetInteractObject(arg1: new[] {10001074, 10001075, 10001076}, arg2: 2);
                context.SetEffect(arg1: new[] {601, 602, 603}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetBreakable(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {20002264}, arg3: new byte[] {3})) {
                    return new State재접속유저케어(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {20002263}, arg3: new byte[] {3})) {
                    return new State조디Dead연출(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {20002263}, arg3: new byte[] {3})) {
                    return new State침공이벤트시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재접속유저케어 : TriggerState {
            internal State재접속유저케어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {10000, 10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {5000, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012}, arg2: false);
                context.SetSound(arg1: 90000, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateTrigger멈춤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger멈춤 : TriggerState {
            internal StateTrigger멈춤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State조디Dead연출 : TriggerState {
            internal State조디Dead연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State연출Trigger로고고(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출Trigger로고고 : TriggerState {
            internal State연출Trigger로고고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999201, key: "tria_seige", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State침공이벤트시작 : TriggerState {
            internal State침공이벤트시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {701}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004}, arg2: true);
                context.SetAgent(arg1: new[] {8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, arg2: false);
                context.CreateMonster(arg1: new[] {1001, 2001, 2002, 4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4100, 4101, 4102, 4103, 4104, 4105, 4106, 4107, 4108, 4109, 4110, 4111, 4112, 4113, 4114, 4115, 4116, 4117, 4118, 4119, 4120, 4121, 4122, 4123, 4124}, arg2: false);
                context.SetBreakable(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동2 : TriggerState {
            internal StateCamera이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State데블린동작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데블린동작 : TriggerState {
            internal State데블린동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100101, enable: true, path: @"BG/Common/Sound/Eff_Object_Devlin_Appear_01.xml ");
                context.SetNpcEmotionSequence(arg1: 2001, arg2: "AttackReady_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마드리아Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아Camera : TriggerState {
            internal State마드리아Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 311, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마드리아백샷(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아백샷 : TriggerState {
            internal State마드리아백샷(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2002, arg3: "$52000068_QD__TRIA_SEIGE__0$", arg4: 3, arg5: 0);
                context.SetOnetimeEffect(id: 1990, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_01_00001990.xml");
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State레논대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논대사01 : TriggerState {
            internal State레논대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000068_QD__TRIA_SEIGE__1$", arg4: 4);
                context.CameraSelect(arg1: 304, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논대사02 : TriggerState {
            internal State레논대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000068_QD__TRIA_SEIGE__2$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논대사03 : TriggerState {
            internal State레논대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000068_QD__TRIA_SEIGE__3$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논대사03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논대사03_1 : TriggerState {
            internal State레논대사03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 4);
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {199}, arg2: 70000109, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 304, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52000068_QD__TRIA_SEIGE__4$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new State임무01(context);
                }

                if (context.UserDetected(arg1: new[] {101})) {
                    return new State임무01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State임무01 : TriggerState {
            internal State임무01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetInteractObject(arg1: new[] {10001074, 10001075, 10001076}, arg2: 1);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000068_QD__TRIA_SEIGE__5$", arg4: 4);
                context.SetSceneSkip(arg1: "임무01반응대기");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State임무01반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State임무01반응대기 : TriggerState {
            internal State임무01반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.CameraSelect(arg1: 305, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001074, 10001075, 10001076}, arg2: 2)) {
                    context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52000068_QD__TRIA_SEIGE__6$", arg4: 4, arg5: 0);
                    context.CreateItem(arg1: new[] {9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012});
                    context.AddBuff(arg1: new[] {199}, arg2: 70000058, arg3: 1, arg4: false, arg5: false);
                    return new State임무02대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State임무02대기 : TriggerState {
            internal State임무02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State임무02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State임무02 : TriggerState {
            internal State임무02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetAgent(arg1: new[] {8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, arg2: true);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 306, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001838, arg3: "$52000068_QD__TRIA_SEIGE__7$", arg4: 4);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104}, arg2: false, arg3: 6000);
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_1101");
                context.MoveNpc(arg1: 1102, arg2: "MS2PatrolData_1102");
                context.MoveNpc(arg1: 1103, arg2: "MS2PatrolData_1103");
                context.MoveNpc(arg1: 1104, arg2: "MS2PatrolData_1104");
                context.SetSceneSkip(arg1: "대사스킵용01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State임무02_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사스킵용01 : TriggerState {
            internal State대사스킵용01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State임무02_2(context);
            }

            public override void OnExit() { }
        }

        private class State임무02_2 : TriggerState {
            internal State임무02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetAgent(arg1: new[] {8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.CameraSelect(arg1: 307, arg2: true);
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001838, arg3: "$52000068_QD__TRIA_SEIGE__8$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 2003, arg2: "AttackReady_A");
                context.SetSceneSkip(arg1: "임무02종료대기");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State임무02종료대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State임무02종료대기 : TriggerState {
            internal State임무02종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.CameraSelect(arg1: 307, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State임무02종료(context);
                }

                if (context.MonsterDead(arg1: new[] {2003})) {
                    return new State임무02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State임무02종료 : TriggerState {
            internal State임무02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 309, arg2: true);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SetSkillA") == 1) {
                    return new State데블린Camera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데블린Camera이동 : TriggerState {
            internal State데블린Camera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SetSkillB") == 1) {
                    return new State벽파괴대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽파괴대기 : TriggerState {
            internal State벽파괴대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State벽파괴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽파괴 : TriggerState {
            internal State벽파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2101, 2102, 2103, 2104}, arg2: false, arg3: 6000);
                context.MoveNpc(arg1: 2101, arg2: "MS2PatrolData_air");
                context.MoveNpc(arg1: 2102, arg2: "MS2PatrolData_air");
                context.MoveNpc(arg1: 2103, arg2: "MS2PatrolData_air");
                context.MoveNpc(arg1: 2104, arg2: "MS2PatrolData_air");
                context.CameraSelect(arg1: 308, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetSkill(arg1: new[] {701}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State조디대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디대화 : TriggerState {
            internal State조디대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001838, arg3: "$52000068_QD__TRIA_SEIGE__9$", arg4: 4);
                context.SetSceneSkip(arg1: "대사스킵용02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State조디대화2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사스킵용02 : TriggerState {
            internal State대사스킵용02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State조디대화2(context);
            }

            public override void OnExit() { }
        }

        private class State조디대화2 : TriggerState {
            internal State조디대화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetConversation(arg1: 2, arg2: 11001838, arg3: "$52000068_QD__TRIA_SEIGE__10$", arg4: 4);
                context.SetSceneSkip(arg1: "벽파괴종료");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State벽파괴종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽파괴종료 : TriggerState {
            internal State벽파괴종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetPortal(arg1: 2, arg2: false, arg3: true, arg4: true);
                context.DestroyMonster(arg1: new[] {2101, 2102, 2103, 2104});
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.CameraSelect(arg1: 308, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}