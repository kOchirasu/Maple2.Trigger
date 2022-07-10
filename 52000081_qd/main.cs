using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000081_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001532}, questStates: new byte[]{1})) {
                    return new StateCinematic01시작(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50100230}, questStates: new byte[]{1})) {
                    return new StateCinematic01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic01시작 : TriggerState {
            internal StateCinematic01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_PC_01");
                    return new StatePC말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__2$", arg4: 1, arg5: 0);
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__3$", arg4: 2, arg5: 0);
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 15000f);
                context.CreateMonster(spawnIds: new []{1001, 1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.MonsterDead(spawnIds: new []{1001, 1003, 1004})) {
                    return new State검사Spawn(context);
                }

                if (context.MonsterDead(spawnIds: new []{1001, 1003, 1004})) {
                    return new StatePC구출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사Spawn : TriggerState {
            internal State검사Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001})) {
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
                context.DestroyMonster(spawnIds: new []{1001, 1003, 1004});
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_02");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_02");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_02_1");
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionLoop(spawnId: 1002, sequenceName: "Attack_01_D", duration: 2000f);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionLoop(spawnId: 1002, sequenceName: "Bore_A", duration: 1500f);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__4$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__5$", align: Align.Left, duration: 3000);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_03");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{8004, 8005}, returnView: false);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__6$", arg4: 3, arg5: 0);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_02");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__7$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_04");
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__17$", align: Align.Left, duration: 2000);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000081_QD__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__11$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__12$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__13$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검사Exit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검사Exit01 : TriggerState {
            internal State검사Exit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_05");
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__14$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__15$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000081_QD__MAIN__16$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_NPC_06");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{1002});
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "meetarcaneblader1st");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
