using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000026_qd {
    public static class _seperategroup_thief {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: false);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6101, 6102, 6103, 6104, 6105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10003003}, arg3: new byte[] {1}, arg4: 70)) {
                    return new StateSetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic01 : TriggerState {
            internal StateSetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(arg1: 3000, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSetupCinematic02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateSetupCinematic02 : TriggerState {
            internal StateSetupCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동01 : TriggerState {
            internal State유저이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3001, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_2000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State1차입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차입장01 : TriggerState {
            internal State1차입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 201}, arg2: true);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
                context.CameraSelect(arg1: 3002, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1차입장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차입장02 : TriggerState {
            internal State1차입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.CameraSelectPath(pathIds: new[] {3003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1차입장03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차입장03 : TriggerState {
            internal State1차입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000601, script: "$52000026_QD__SEPERATEGROUP_THIEF__0$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State2차입장01(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2차입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장01 : TriggerState {
            internal State2차입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.CameraSelect(arg1: 3100, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차입장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장02 : TriggerState {
            internal State2차입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301}, arg2: true);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.SetEffect(arg1: new[] {5003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차입장03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장03 : TriggerState {
            internal State2차입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: true);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_401");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2차입장04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장04 : TriggerState {
            internal State2차입장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6104}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000026_QD__SEPERATEGROUP_THIEF__1$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State2차입장05(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차입장05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장05 : TriggerState {
            internal State2차입장05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차입장06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장06 : TriggerState {
            internal State2차입장06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000026_QD__SEPERATEGROUP_THIEF__2$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State2차입장07(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2차입장07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차입장07 : TriggerState {
            internal State2차입장07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {6101}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_302");
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_402");
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
                context.CameraSelect(arg1: 3101, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3차입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차입장01 : TriggerState {
            internal State3차입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.CreateMonster(arg1: new[] {501}, arg2: true);
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_501");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State3차입장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차입장02 : TriggerState {
            internal State3차입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {601}, arg2: true);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_601");
                context.SetEffect(arg1: new[] {5003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3차입장03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차입장03 : TriggerState {
            internal State3차입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3102, arg2: true);
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, script: "$52000026_QD__SEPERATEGROUP_THIEF__3$", arg4: 7, arg5: 0);
                context.SetSkip(state: new State4차입장01(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State4차입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차입장01 : TriggerState {
            internal State4차입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.CameraSelect(arg1: 3200, arg2: true);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State4차입장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차입장02 : TriggerState {
            internal State4차입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3210, arg2: true);
                context.CreateMonster(arg1: new[] {701}, arg2: true);
                context.MoveNpc(arg1: 701, arg2: "MS2PatrolData_701");
                context.SetEffect(arg1: new[] {5003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4차입장03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차입장03 : TriggerState {
            internal State4차입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001581, script: "$52000026_QD__SEPERATEGROUP_THIEF__4$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State4차입장04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State4차입장04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차입장04 : TriggerState {
            internal State4차입장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 3201, arg2: true);
                context.CreateMonster(arg1: new[] {801}, arg2: true);
                context.MoveNpc(arg1: 801, arg2: "MS2PatrolData_801");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4차입장05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차입장05 : TriggerState {
            internal State4차입장05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000026_QD__SEPERATEGROUP_THIEF__5$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State4차입장06(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State4차입장06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차입장06 : TriggerState {
            internal State4차입장06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5차입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장01 : TriggerState {
            internal State5차입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5차입장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장02 : TriggerState {
            internal State5차입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 701, arg2: "MS2PatrolData_702");
                context.CameraSelect(arg1: 3300, arg2: true);
                context.CreateMonster(arg1: new[] {901}, arg2: true);
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_901");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5차입장03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장03 : TriggerState {
            internal State5차입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001583, script: "$52000026_QD__SEPERATEGROUP_THIEF__6$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State5차입장04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5차입장04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장04 : TriggerState {
            internal State5차입장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 3301, arg2: true);
                context.CreateMonster(arg1: new[] {1001}, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5차입장05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장05 : TriggerState {
            internal State5차입장05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001584, script: "$52000026_QD__SEPERATEGROUP_THIEF__7$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State5차입장06(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State5차입장06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장06 : TriggerState {
            internal State5차입장06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 3302, arg2: true);
                context.CreateMonster(arg1: new[] {1101}, arg2: true);
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_1101");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State5차입장07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장07 : TriggerState {
            internal State5차입장07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$52000026_QD__SEPERATEGROUP_THIEF__8$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State5차입장08(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State5차입장08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장08 : TriggerState {
            internal State5차입장08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.CameraSelect(arg1: 3303, arg2: true);
                context.CreateMonster(arg1: new[] {1201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State5차입장09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장09 : TriggerState {
            internal State5차입장09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.MoveNpc(arg1: 1201, arg2: "MS2PatrolData_1201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State5차입장10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장10 : TriggerState {
            internal State5차입장10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001586, script: "$52000026_QD__SEPERATEGROUP_THIEF__9$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State5차입장11(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5차입장11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장11 : TriggerState {
            internal State5차입장11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State5차입장12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장12 : TriggerState {
            internal State5차입장12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001586, script: "$52000026_QD__SEPERATEGROUP_THIEF__10$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State5차입장13(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5차입장13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장13 : TriggerState {
            internal State5차입장13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 3304, arg2: true);
                context.MoveNpc(arg1: 801, arg2: "MS2PatrolData_802");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State5차입장14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차입장14 : TriggerState {
            internal State5차입장14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000026_QD__SEPERATEGROUP_THIEF__11$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State입장완료01(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State입장완료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장완료01 : TriggerState {
            internal State입장완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetSound(arg1: 10000, arg2: true);
                context.CameraSelectPath(pathIds: new[] {3400, 3401, 3402, 3403}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정렬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정렬01 : TriggerState {
            internal State정렬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, script: "$52000026_QD__SEPERATEGROUP_THIEF__12$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State정렬02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State정렬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정렬02 : TriggerState {
            internal State정렬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_502");
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_602");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정렬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정렬03 : TriggerState {
            internal State정렬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1002");
                context.MoveNpc(arg1: 1201, arg2: "MS2PatrolData_1202");
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_902");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정렬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정렬04 : TriggerState {
            internal State정렬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_303");
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_403");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정렬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정렬05 : TriggerState {
            internal State정렬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_103");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_1102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정렬06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정렬06 : TriggerState {
            internal State정렬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.MoveNpc(arg1: 701, arg2: "MS2PatrolData_703");
                context.MoveNpc(arg1: 801, arg2: "MS2PatrolData_803");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State본론01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론01 : TriggerState {
            internal State본론01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, script: "$52000026_QD__SEPERATEGROUP_THIEF__13$", arg4: 10, arg5: 0);
                context.SetSkip(state: new State본론02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State본론02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론02 : TriggerState {
            internal State본론02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State본론03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론03 : TriggerState {
            internal State본론03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: false);
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, script: "$52000026_QD__SEPERATEGROUP_THIEF__14$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State본론04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State본론04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론04 : TriggerState {
            internal State본론04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {6004}, arg2: false);
                context.CameraSelect(arg1: 3500, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State본론05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론05 : TriggerState {
            internal State본론05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_304");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State본론06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론06 : TriggerState {
            internal State본론06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2005");
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_404");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State본론07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본론07 : TriggerState {
            internal State본론07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000026_QD__SEPERATEGROUP_THIEF__15$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State영상01(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State영상01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상01 : TriggerState {
            internal State영상01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetEffect(arg1: new[] {6102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상02 : TriggerState {
            internal State영상02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Royal_IshuraRemember.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, arg2: "IsStop", arg3: "1")) {
                    return new State영상03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상03 : TriggerState {
            internal State영상03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State영상04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상04 : TriggerState {
            internal State영상04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정리01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리01 : TriggerState {
            internal State정리01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3600, arg2: true);
                context.SetEffect(arg1: new[] {6105}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000026_QD__SEPERATEGROUP_THIEF__16$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State정리02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State정리02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리02 : TriggerState {
            internal State정리02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {6103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State반대01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대01 : TriggerState {
            internal State반대01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000026_QD__SEPERATEGROUP_THIEF__17$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State반대02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State반대02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대02 : TriggerState {
            internal State반대02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 3601, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State반대03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대03 : TriggerState {
            internal State반대03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001586, script: "$52000026_QD__SEPERATEGROUP_THIEF__18$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State반대04(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State반대04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대04 : TriggerState {
            internal State반대04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State반대05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대05 : TriggerState {
            internal State반대05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001586, script: "$52000026_QD__SEPERATEGROUP_THIEF__19$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State반대06(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State반대06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대06 : TriggerState {
            internal State반대06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveNpc(arg1: 1201, arg2: "MS2PatrolData_1203");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State반대07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대07 : TriggerState {
            internal State반대07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3602, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State반대08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대08 : TriggerState {
            internal State반대08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001584, script: "$52000026_QD__SEPERATEGROUP_THIEF__20$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State반대09(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State반대09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대09 : TriggerState {
            internal State반대09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1003");
                context.CameraSelect(arg1: 3603, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State반대10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대10 : TriggerState {
            internal State반대10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3604, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State반대11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대11 : TriggerState {
            internal State반대11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1201, 1001});
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_1103");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State반대12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반대12 : TriggerState {
            internal State반대12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_903");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic01 : TriggerState {
            internal StateStopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6007}, arg2: false);
                context.CameraSelect(arg1: 3801, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic02 : TriggerState {
            internal StateStopCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1101, 901});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 3801, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "SeperateGroup");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State강제Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제Exit : TriggerState {
            internal State강제Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000001, arg2: 17, arg3: 9001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() {
                context.SetSound(arg1: 10000, arg2: false);
            }
        }
    }
}