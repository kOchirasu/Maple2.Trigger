namespace Maple2.Trigger._99999922 {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 99999, enabled: false);
                context.SetEffect(triggerIds: new []{100000001, 100000002, 100000003, 100000004, 100000005, 100000006}, visible: false);
                context.SetMesh(triggerIds: new []{1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1400, 1500}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{1000001, 1000002, 1000003, 1000004, 1000005, 1000006, 1100001, 1100002, 1100003}, visible: false);
                context.SetInteractObject(interactIds: new []{10000065}, state: 2);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1})) {
                    return new StateCreation_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation_1 : TriggerState {
            internal StateCreation_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_1 : TriggerState {
            internal StateStartCinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 2000001, enabled: true);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State대화_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화_1 : TriggerState {
            internal State대화_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 101, script: "신입사원인가요?", arg4: 5);
                context.SetSkip(state: new State대화_1_스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대화_1_스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화_1_스킵 : TriggerState {
            internal State대화_1_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State대화_2(context);
            }

            public override void OnExit() { }
        }

        private class State대화_2 : TriggerState {
            internal State대화_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 101, script: @"반가워요.\n그럼 저를 따라와 보시겠어요??", arg4: 3);
                context.SetSkip(state: new StateEndCinematic_1(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대화_2_스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화_2_스킵 : TriggerState {
            internal State대화_2_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEndCinematic_1(context);
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic_1 : TriggerState {
            internal StateEndCinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 2000001, enabled: false);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStoneSound_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData0_101_1");
                context.SetMesh(triggerIds: new []{1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, visible: false, arg3: 2000, arg4: 100, arg5: 0f);
                context.SetMesh(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111}, visible: true, arg3: 5000, arg4: 100, arg5: 0f);
            }
        }

        private class StateStoneSound_1 : TriggerState {
            internal StateStoneSound_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "자경대장 오스칼과 함께 몬스터들을 처치하세요.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBridgeSound_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{100000001}, visible: true);
            }
        }

        private class StateBridgeSound_1 : TriggerState {
            internal StateBridgeSound_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonsterSpawn_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{100000002}, visible: true);
            }
        }

        private class StateMonsterSpawn_1 : TriggerState {
            internal StateMonsterSpawn_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1400}, visible: false, arg3: 1000, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateUserDetection_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection_2 : TriggerState {
            internal StateUserDetection_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2}, jobCode: 0)) {
                    return new State길막추가_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길막추가_1 : TriggerState {
            internal State길막추가_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{1000001, 1000002, 1000003, 1000004, 1000005, 1000006}, visible: true);
                context.SetMesh(triggerIds: new []{1400}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateNpcDetection1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDetection1 : TriggerState {
            internal StateNpcDetection1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2}, jobCode: 0) && context.NpcDetected(boxId: 2, spawnIds: new []{101})) {
                    return new State다리Remove_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Remove_1 : TriggerState {
            internal State다리Remove_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111}, visible: false, arg3: 100, arg4: 100, arg5: 0f);
                context.SetEffect(triggerIds: new []{100000003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateMonsterDead_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_1 : TriggerState {
            internal StateMonsterDead_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001})) {
                    return new State3번째구역통로오픈(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, script: "다리를 건너 마지막 몬스터를 처치하세요!", duration: 4000);
            }
        }

        private class State3번째구역통로오픈 : TriggerState {
            internal State3번째구역통로오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{1000001, 1000002, 1000003, 1000004, 1000005, 1000006}, visible: false);
                context.SetMesh(triggerIds: new []{1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308}, visible: false, arg3: 2000, arg4: 100, arg5: 0f);
                context.SetMesh(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211}, visible: true, arg3: 4000, arg4: 100, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateStoneSound_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{1500}, visible: false, arg3: 5000, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData0_101_2");
            }
        }

        private class StateStoneSound_2 : TriggerState {
            internal StateStoneSound_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new StateBridgeSound_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{100000004}, visible: true);
            }
        }

        private class StateBridgeSound_2 : TriggerState {
            internal StateBridgeSound_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1900)) {
                    return new StateUserDetection_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{100000005}, visible: true);
            }
        }

        private class StateUserDetection_3 : TriggerState {
            internal StateUserDetection_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{3}, jobCode: 0) && context.NpcDetected(boxId: 3, spawnIds: new []{101})) {
                    return new State길막추가_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길막추가_2 : TriggerState {
            internal State길막추가_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1500}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{1100001, 1100002, 1100003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State다리Remove_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Remove_2 : TriggerState {
            internal State다리Remove_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 99999, enabled: true);
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.SetMesh(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211}, visible: false, arg3: 100, arg4: 100, arg5: 0f);
                context.SetEffect(triggerIds: new []{100000006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateMonsterDead_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_2 : TriggerState {
            internal StateMonsterDead_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateStartCinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_2 : TriggerState {
            internal StateStartCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 99999, enabled: false);
                context.CameraSelect(triggerId: 2000002, enabled: true);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLeverCreation_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCreation_1 : TriggerState {
            internal StateLeverCreation_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000065}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new State대화_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화_3 : TriggerState {
            internal State대화_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 101, script: "저 스위치를 당겨야해요!", arg4: 5);
                context.SetSkip(state: new State대화_3_스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대화_3_스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화_3_스킵 : TriggerState {
            internal State대화_3_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEndCinematic_2(context);
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic_2 : TriggerState {
            internal StateEndCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 2000002, enabled: false);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLeverCreation_1_완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, script: "Creation된 스위치를 작동시키세요!", duration: 4000);
            }
        }

        private class StateLeverCreation_1_완료 : TriggerState {
            internal StateLeverCreation_1_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000065}, arg2: 0)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateNPC이동_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동_2 : TriggerState {
            internal StateNPC이동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData0_101_3");
                context.SetConversation(type: 1, spawnId: 101, script: "오예~끝났당~", arg4: 3, arg5: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcDetection4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDetection4 : TriggerState {
            internal StateNpcDetection4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 4, spawnIds: new []{101})) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
