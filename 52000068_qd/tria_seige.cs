namespace Maple2.Trigger._52000068_qd {
    public static class _tria_seige {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateQuest분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest분기 : TriggerState {
            internal StateQuest분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 11010, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 16000, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 16001, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 16002, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16003, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16004, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16005, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16006, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16007, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 16008, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16009, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16010, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16011, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 16012, visible: false, initialSequence: "Stun_A");
                context.SetInteractObject(interactIds: new []{10001074, 10001075, 10001076}, state: 2);
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetBreakable(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{20002264}, questStates: new byte[]{3})) {
                    return new State재접속유저케어(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{20002263}, questStates: new byte[]{3})) {
                    return new State조디DeadCinematic(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{199}, questIds: new []{20002263}, questStates: new byte[]{3})) {
                    return new State침공이벤트시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재접속유저케어 : TriggerState {
            internal State재접속유저케어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10000, 10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034}, arg2: false);
                context.SetVisibleBreakableObject(triggerIds: new []{5000, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012}, visible: false);
                context.SetSound(triggerId: 90000, enabled: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State조디DeadCinematic : TriggerState {
            internal State조디DeadCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateCinematicTrigger로고고(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicTrigger로고고 : TriggerState {
            internal StateCinematicTrigger로고고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999201, key: "tria_seige", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State침공이벤트시작 : TriggerState {
            internal State침공이벤트시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{701}, enabled: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004}, visible: true);
                context.SetAgent(triggerIds: new []{8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: false);
                context.CreateMonster(spawnIds: new []{1001, 2001, 2002, 4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4100, 4101, 4102, 4103, 4104, 4105, 4106, 4107, 4108, 4109, 4110, 4111, 4112, 4113, 4114, 4115, 4116, 4117, 4118, 4119, 4120, 4121, 4122, 4123, 4124}, arg2: false);
                context.SetBreakable(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 302, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 11100101, enabled: true, path: @"BG/Common/Sound/Eff_Object_Devlin_Appear_01.xml ");
                context.SetNpcEmotionSequence(spawnId: 2001, sequenceName: "AttackReady_A");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 311, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 2002, script: "$52000068_QD__TRIA_SEIGE__0$", arg4: 3, arg5: 0);
                context.SetOnetimeEffect(id: 1990, enabled: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_01_00001990.xml");
                context.CameraSelect(triggerId: 303, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State레논Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script01 : TriggerState {
            internal State레논Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000068_QD__TRIA_SEIGE__1$", arg4: 4);
                context.CameraSelect(triggerId: 304, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script02 : TriggerState {
            internal State레논Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000068_QD__TRIA_SEIGE__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script03 : TriggerState {
            internal State레논Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000068_QD__TRIA_SEIGE__3$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논Script03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script03_1 : TriggerState {
            internal State레논Script03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override TriggerState? Execute() {
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
                context.AddBuff(boxIds: new []{199}, skillId: 70000109, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 304, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004}, visible: false);
                context.SetConversation(type: 1, spawnId: 1001, script: "$52000068_QD__TRIA_SEIGE__4$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateMission01(context);
                }

                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateMission01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission01 : TriggerState {
            internal StateMission01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetInteractObject(interactIds: new []{10001074, 10001075, 10001076}, state: 1);
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000068_QD__TRIA_SEIGE__5$", arg4: 4);
                context.SetSceneSkip(state: new StateMission01반응Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMission01반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission01반응Wait : TriggerState {
            internal StateMission01반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.CameraSelect(triggerId: 305, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001074, 10001075, 10001076}, arg2: 2)) {
                    context.SetConversation(type: 1, spawnId: 1001, script: "$52000068_QD__TRIA_SEIGE__6$", arg4: 4, arg5: 0);
                    context.CreateItem(spawnIds: new []{9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012});
                    context.AddBuff(boxIds: new []{199}, skillId: 70000058, level: 1, arg4: false, arg5: false);
                    return new StateMission02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission02Wait : TriggerState {
            internal StateMission02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateMission02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission02 : TriggerState {
            internal StateMission02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAgent(triggerIds: new []{8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: true);
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 306, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001838, script: "$52000068_QD__TRIA_SEIGE__7$", arg4: 4);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104}, arg2: false, arg3: 6000);
                context.MoveNpc(spawnId: 1101, patrolName: "MS2PatrolData_1101");
                context.MoveNpc(spawnId: 1102, patrolName: "MS2PatrolData_1102");
                context.MoveNpc(spawnId: 1103, patrolName: "MS2PatrolData_1103");
                context.MoveNpc(spawnId: 1104, patrolName: "MS2PatrolData_1104");
                context.SetSceneSkip(state: new State대사스킵용01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMission02_2(context);
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

            public override TriggerState? Execute() {
                return new StateMission02_2(context);
            }

            public override void OnExit() { }
        }

        private class StateMission02_2 : TriggerState {
            internal StateMission02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetAgent(triggerIds: new []{8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: false);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.CameraSelect(triggerId: 307, enabled: true);
                context.CreateMonster(spawnIds: new []{2003}, arg2: false);
                context.SetConversation(type: 2, spawnId: 11001838, script: "$52000068_QD__TRIA_SEIGE__8$", arg4: 4);
                context.SetNpcEmotionSequence(spawnId: 2003, sequenceName: "AttackReady_A");
                context.SetSceneSkip(state: new StateMission02종료Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMission02종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission02종료Wait : TriggerState {
            internal StateMission02종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.CameraSelect(triggerId: 307, enabled: false);
                context.SetEffect(triggerIds: new []{602}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateMission02종료(context);
                }

                if (context.MonsterDead(spawnIds: new []{2003})) {
                    return new StateMission02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission02종료 : TriggerState {
            internal StateMission02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 309, enabled: true);
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.DestroyMonster(spawnIds: new []{2001});
                context.CreateMonster(spawnIds: new []{2004}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 310, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SetSkillB") == 1) {
                    return new State벽파괴Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽파괴Wait : TriggerState {
            internal State벽파괴Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{2101, 2102, 2103, 2104}, arg2: false, arg3: 6000);
                context.MoveNpc(spawnId: 2101, patrolName: "MS2PatrolData_air");
                context.MoveNpc(spawnId: 2102, patrolName: "MS2PatrolData_air");
                context.MoveNpc(spawnId: 2103, patrolName: "MS2PatrolData_air");
                context.MoveNpc(spawnId: 2104, patrolName: "MS2PatrolData_air");
                context.CameraSelect(triggerId: 308, enabled: true);
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetSkill(triggerIds: new []{701}, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001838, script: "$52000068_QD__TRIA_SEIGE__9$", arg4: 4);
                context.SetSceneSkip(state: new State대사스킵용02(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new State조디대화2(context);
            }

            public override void OnExit() { }
        }

        private class State조디대화2 : TriggerState {
            internal State조디대화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetConversation(type: 2, spawnId: 11001838, script: "$52000068_QD__TRIA_SEIGE__10$", arg4: 4);
                context.SetSceneSkip(state: new State벽파괴종료(context));
            }

            public override TriggerState? Execute() {
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
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{2101, 2102, 2103, 2104});
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetEffect(triggerIds: new []{603}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.CameraSelect(triggerId: 308, enabled: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
