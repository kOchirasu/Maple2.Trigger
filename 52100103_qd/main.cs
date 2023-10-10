using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100103_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600, 700}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic체크 : TriggerState {
            internal StateStartCinematic체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10000}, questIds: new []{50100960}, questStates: new byte[]{2})) {
                    return new StateStartCinematicPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicPrepare : TriggerState {
            internal StateStartCinematicPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1}, arg2: false);
                context.SetEffect(triggerIds: new []{600, 700}, visible: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematicNPC소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicNPC소환 : TriggerState {
            internal StateCinematicNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52100103, portalId: 3);
                context.CreateMonster(spawnIds: new []{1000, 2000}, arg2: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart암전1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart암전1 : TriggerState {
            internal StateStart암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52100103, portalId: 3);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new State엔딩암전(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State클라디아Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아Script1 : TriggerState {
            internal State클라디아Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 2000, sequenceName: "Bore_A", duration: 1333f);
                context.AddCinematicTalk(npcId: 11004419, script: "$52100103_QD__MAIN__0$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네Script1 : TriggerState {
            internal State마를레네Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
                context.SetNpcEmotionLoop(spawnId: 1000, sequenceName: "Talk_A", duration: 1333f);
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__1$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCamera흔들기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera흔들기 : TriggerState {
            internal StateCamera흔들기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{700}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네Script2 : TriggerState {
            internal State마를레네Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{3, 200, 201, 202, 203}, arg2: false);
                context.SetNpcRotation(spawnId: 1000, rotation: -45);
                context.SetNpcRotation(spawnId: 2000, rotation: 45);
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__2$", duration: 2000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004419, script: "$52100103_QD__MAIN__3$", duration: 2000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 3, sequenceName: "Bore_A", duration: 1333f);
                context.CameraSelect(triggerId: 100, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script1 : TriggerState {
            internal State투르카Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "PatrolData_PC_01");
                context.AddCinematicTalk(npcId: 11004430, script: "$52100103_QD__MAIN__4$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC돌아보기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC돌아보기 : TriggerState {
            internal StatePC돌아보기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 200, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StatePortal오픈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal오픈 : TriggerState {
            internal StatePortal오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CameraSelect(triggerId: 1002, enabled: true);
                context.CreateMonster(spawnIds: new []{300}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대사 : TriggerState {
            internal StatePC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__5$", duration: 3000, align: Align.Left);
                context.MoveUser(mapId: 52100103, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카이동1 : TriggerState {
            internal State투르카이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 300, patrolName: "PatrolData_Turka_1");
                context.MoveNpc(spawnId: 200, patrolName: "PatrolData_200_1");
                context.MoveNpc(spawnId: 201, patrolName: "PatrolData_201_1");
                context.MoveNpc(spawnId: 202, patrolName: "PatrolData_202_1");
                context.MoveNpc(spawnId: 203, patrolName: "PatrolData_203_1");
                context.CameraSelect(triggerId: 1003, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1000}, arg2: false);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100103_QD__MAIN__6$", duration: 3000, align: Align.Left);
                context.MoveNpc(spawnId: 1001, patrolName: "PatrolData_1001_1");
                context.MoveNpc(spawnId: 300, patrolName: "PatrolData_Turka_2");
                context.MoveNpc(spawnId: 200, patrolName: "PatrolData_200_2");
                context.MoveNpc(spawnId: 201, patrolName: "PatrolData_201_2");
                context.MoveNpc(spawnId: 202, patrolName: "PatrolData_202_2");
                context.MoveNpc(spawnId: 203, patrolName: "PatrolData_203_2");
                context.MoveUserPath(patrolName: "PatrolData_PC_02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC말풍선대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사 : TriggerState {
            internal StatePC말풍선대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52100103_QD__MAIN__7$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC공격자세(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC공격자세 : TriggerState {
            internal StatePC공격자세(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 30000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대사협박1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대사협박1 : TriggerState {
            internal State투르카대사협박1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 202, rotation: 45);
                context.SetNpcRotation(spawnId: 201, rotation: -45);
                context.SetNpcRotation(spawnId: 200, rotation: 15);
                context.SetNpcRotation(spawnId: 203, rotation: -15);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100103_QD__MAIN__8$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 300, sequenceName: "Bore_A", duration: 1333f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네협박(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네협박 : TriggerState {
            internal State마를레네협박(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__9$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 1001, sequenceName: "Talk_A", duration: 1333f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대사협박2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대사협박2 : TriggerState {
            internal State투르카대사협박2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004430, script: "$52100103_QD__MAIN__10$", duration: 6000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__11$", duration: 2000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004430, script: "$52100103_QD__MAIN__12$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 300, sequenceName: "Bore_A", duration: 1333f);
                context.DestroyMonster(spawnIds: new []{2000}, arg2: false);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아대사 : TriggerState {
            internal State클라디아대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2001, patrolName: "PatrolData_2001_1");
                context.AddCinematicTalk(npcId: 11004385, script: "$52100103_QD__MAIN__13$", duration: 2000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004385, script: "$52100103_QD__MAIN__14$", duration: 3500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State마를레네대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네대사 : TriggerState {
            internal State마를레네대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__15$", duration: 2000, align: Align.Left);
                context.SetNpcRotation(spawnId: 1001, rotation: 45);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아마를레네바라보기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아마를레네바라보기 : TriggerState {
            internal State클라디아마를레네바라보기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 2001, rotation: -90);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아Script2 : TriggerState {
            internal State클라디아Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 2001, sequenceName: "Talk_A", duration: 1333f);
                context.AddCinematicTalk(npcId: 11004385, script: "$52100103_QD__MAIN__16$", duration: 4000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__17$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script3 : TriggerState {
            internal State투르카Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004430, script: "$52100103_QD__MAIN__18$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 300, sequenceName: "Bore_A", duration: 1333f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아Exit : TriggerState {
            internal State클라디아Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CameraSelect(triggerId: 1004, enabled: true);
                context.MoveNpc(spawnId: 2001, patrolName: "PatrolData_2001_2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부하Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하Exit : TriggerState {
            internal State부하Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "PatrolData_200_3");
                context.MoveNpc(spawnId: 201, patrolName: "PatrolData_201_3");
                context.MoveNpc(spawnId: 202, patrolName: "PatrolData_202_3");
                context.MoveNpc(spawnId: 203, patrolName: "PatrolData_203_3");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Exit : TriggerState {
            internal State투르카Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 300, patrolName: "PatrolData_Turka_3");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네엔딩대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네엔딩대사 : TriggerState {
            internal State마를레네엔딩대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1005, 1006}, returnView: false);
                context.AddCinematicTalk(npcId: 11004395, script: "$52100103_QD__MAIN__19$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩암전 : TriggerState {
            internal State엔딩암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonster정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster정리 : TriggerState {
            internal StateMonster정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State상황정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황정리 : TriggerState {
            internal State상황정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52100109, portalId: 2);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네CreationPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네CreationPrepare : TriggerState {
            internal State마를레네CreationPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네Creation : TriggerState {
            internal State마를레네Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600, 700}, visible: false);
                context.CreateMonster(spawnIds: new []{1}, arg2: false);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
