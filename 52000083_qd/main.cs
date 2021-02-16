using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000083_qd {
    public static class _main {
        public class State50001536Cinematic출력체크 : TriggerState {
            internal State50001536Cinematic출력체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001536}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100260}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001536}, arg3: new byte[] {1})) {
                    return new State조건체크01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100260}, arg3: new byte[] {1})) {
                    return new State조건체크01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크01 : TriggerState {
            internal State조건체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001536}, arg3: new byte[] {2})) {
                    return new StateCinematic이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100260}, arg3: new byte[] {2})) {
                    return new StateCinematic이후(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001536}, arg3: new byte[] {2})) {
                    return new State조건체크02(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100260}, arg3: new byte[] {2})) {
                    return new State조건체크02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크02 : TriggerState {
            internal State조건체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001536}, arg3: new byte[] {3})) {
                    return new State조건체크03(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001536}, arg3: new byte[] {3})) {
                    return new State전투종료후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100260}, arg3: new byte[] {3})) {
                    return new State조건체크03(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100260}, arg3: new byte[] {3})) {
                    return new State조건체크03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크03 : TriggerState {
            internal State조건체크03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001537}, arg3: new byte[] {1})) {
                    return new StateCinematic이후(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001537}, arg3: new byte[] {1})) {
                    return new StateCinematic이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100270}, arg3: new byte[] {1})) {
                    return new StateCinematic이후(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100270}, arg3: new byte[] {1})) {
                    return new StateCinematic이후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic이후 : TriggerState {
            internal StateCinematic이후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료후 : TriggerState {
            internal State전투종료후(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1011, 1021, 1022, 1023, 1024}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateMonster처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster처치 : TriggerState {
            internal StateMonster처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1021, 1022, 1023, 1024})) {
                    return new State경로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경로이동01 : TriggerState {
            internal State경로이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                context.MoveNpc(arg1: 1011, arg2: "MS2PatrolData_blader_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State경로이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경로이동02 : TriggerState {
            internal State경로이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC_02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DestroyMonster(arg1: new[] {1011});
                    context.CreateMonster(arg1: new[] {1012}, arg2: false);
                    return new StatePC말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000083_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사시네마틱대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사시네마틱대사 : TriggerState {
            internal State검사시네마틱대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__1$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC말풍선02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000083_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC말풍선03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선03 : TriggerState {
            internal StatePC말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000083_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State디나말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나말풍선01 : TriggerState {
            internal State디나말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1001, script: "$52000083_QD__MAIN__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State디나기상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나기상 : TriggerState {
            internal State디나기상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Idle_A", arg3: 69000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화01 : TriggerState {
            internal State검사대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8001, 8002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 1012, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__5$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State디나대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화01 : TriggerState {
            internal State디나대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화02 : TriggerState {
            internal State검사대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__7$", align: Align.Left, duration: 3000);
                context.SetNpcEmotionLoop(arg1: 1012, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State디나대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화02 : TriggerState {
            internal State디나대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화03 : TriggerState {
            internal State검사대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__9$", align: Align.Left, duration: 3000);
                context.SetNpcEmotionLoop(arg1: 1012, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State디나대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화03 : TriggerState {
            internal State디나대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State디나대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화04 : TriggerState {
            internal State디나대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__11$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State디나대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화05 : TriggerState {
            internal State디나대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__12$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State디나대화051(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화051 : TriggerState {
            internal State디나대화051(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화04 : TriggerState {
            internal State검사대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__14$", align: Align.Left, duration: 3000);
                context.SetNpcEmotionLoop(arg1: 1012, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State디나대화06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디나대화06 : TriggerState {
            internal State디나대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003065, script: "$52000083_QD__MAIN__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화06 : TriggerState {
            internal State검사대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__16$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State시점이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시점이동 : TriggerState {
            internal State시점이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 1012, arg2: "Bore_B", arg3: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State검사Exit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사Exit01 : TriggerState {
            internal State검사Exit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1012, arg2: "MS2PatrolData_blader_02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePC따라감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC따라감 : TriggerState {
            internal StatePC따라감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC_03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePC말풍선04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선04 : TriggerState {
            internal StatePC말풍선04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000083_QD__MAIN__17$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Talk_B", arg2: 2500f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선05 : TriggerState {
            internal StatePC말풍선05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000083_QD__MAIN__18$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Talk_B", arg2: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사시네마틱Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사시네마틱Script02 : TriggerState {
            internal State검사시네마틱Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__19$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사말풍선03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사말풍선03 : TriggerState {
            internal State검사말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000083_QD__MAIN__20$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사Exit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사Exit02 : TriggerState {
            internal State검사Exit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.MoveNpc(arg1: 1012, arg2: "MS2PatrolData_blader_03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(arg1: new[] {1012, 1001});
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "meetarcaneblader2nd");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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