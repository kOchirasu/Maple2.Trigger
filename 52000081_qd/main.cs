namespace Maple2.Trigger._52000081_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001532}, arg3: new byte[] {1})) {
                    return new State연출01시작(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100230}, arg3: new byte[] {1})) {
                    return new State연출01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출01시작 : TriggerState {
            internal State연출01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                    return new StatePC말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선03 : TriggerState {
            internal StatePC말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__2$", arg4: 1, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 10000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State감옥이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥이펙트 : TriggerState {
            internal State감옥이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State몹소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹소환 : TriggerState {
            internal State몹소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__3$", arg4: 2, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 15000f);
                context.CreateMonster(arg1: new[] {1001, 1003, 1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.MonsterDead(arg1: new[] {1001, 1003, 1004})) {
                    return new State검사Appear(context);
                }

                if (context.MonsterDead(arg1: new[] {1001, 1003, 1004})) {
                    return new StatePC구출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사Appear : TriggerState {
            internal State검사Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_01");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StatePC구출01(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new State예비용00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예비용00 : TriggerState {
            internal State예비용00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1003, 1004});
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC구출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC구출01 : TriggerState {
            internal StatePC구출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC구출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC구출02 : TriggerState {
            internal StatePC구출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_02_1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC구출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC구출03 : TriggerState {
            internal StatePC구출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1002, arg2: "Attack_01_D", arg3: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC구출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC구출04 : TriggerState {
            internal StatePC구출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 10000f);
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
                context.SetNpcEmotionLoop(arg1: 1002, arg2: "Bore_A", arg3: 1500f);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__4$", align: "left", duration: 3000);
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__5$", align: "left", duration: 3000);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StatePC말풍선04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선04 : TriggerState {
            internal StatePC말풍선04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004, 8005}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__6$", arg4: 3, arg5: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_02");
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
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__7$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_04");
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__17$", align: "left", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선06 : TriggerState {
            internal StatePC말풍선06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선07 : TriggerState {
            internal StatePC말풍선07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선08 : TriggerState {
            internal StatePC말풍선08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000081_QD__MAIN__10$", arg4: 3, arg5: 0);
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__11$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화05 : TriggerState {
            internal State검사대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__12$", align: "left", duration: 3000);
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__13$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사퇴장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사퇴장01 : TriggerState {
            internal State검사퇴장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_05");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State검사대화07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화07 : TriggerState {
            internal State검사대화07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__14$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화08 : TriggerState {
            internal State검사대화08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__15$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사대화09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사대화09 : TriggerState {
            internal State검사대화09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52000081_QD__MAIN__16$", align: "left", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사퇴장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사퇴장02 : TriggerState {
            internal State검사퇴장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_NPC_06");
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
                context.DestroyMonster(arg1: new[] {1002});
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "meetarcaneblader1st");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
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