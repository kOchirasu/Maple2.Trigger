using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000085_qd {
    public static class _50001538 {
        public class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100280}, questStates: new byte[]{1})) {
                    return new StateWait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100280}, questStates: new byte[]{2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100280}, questStates: new byte[]{3})) {
                    return new State던전종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003}, arg2: false);
                context.SetPortal(portalId: 91, visible: false, enabled: false, minimapVisible: false);
                context.RemoveBuff(boxId: 199, skillId: 70000115);
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
                context.SetLocalCamera(cameraId: 2000, enable: false);
                context.SetNpcEmotionLoop(spawnId: 1001, sequenceName: "Attack_Idle_A", duration: 999999999999f);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 999999999999f);
                context.SetSkip(state: new StateStopCinematic(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 300, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트루카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script01 : TriggerState {
            internal State트루카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 1003, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__0$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script02 : TriggerState {
            internal State트루카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__1$", align: Align.Left, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State에르다Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script01 : TriggerState {
            internal State에르다Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002A");
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__2$", align: Align.Right, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script02 : TriggerState {
            internal State에르다Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003A");
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__3$", align: Align.Right, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script03 : TriggerState {
            internal State트루카Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
                context.SetNpcEmotionSequence(spawnId: 1003, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__4$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script04 : TriggerState {
            internal State트루카Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__5$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script03 : TriggerState {
            internal State에르다Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__6$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트루카Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script05 : TriggerState {
            internal State트루카Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__7$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script06 : TriggerState {
            internal State트루카Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__8$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script07 : TriggerState {
            internal State트루카Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__9$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script04 : TriggerState {
            internal State에르다Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__10$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State설눈이이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이이동01 : TriggerState {
            internal State설눈이이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: true);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State설눈이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script01 : TriggerState {
            internal State설눈이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1001, sequenceName: "Attack_Idle_A", duration: 999999999999f);
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__11$", align: Align.Right, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State트루카Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script08 : TriggerState {
            internal State트루카Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enable: true);
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003B");
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__12$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트루카Script09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script09 : TriggerState {
            internal State트루카Script09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__13$", align: Align.Left, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State홀슈타트Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn : TriggerState {
            internal State홀슈타트Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 306, enable: true);
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State홀슈타트Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Script01 : TriggerState {
            internal State홀슈타트Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 307, enable: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000085_QD__50001538__14$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script10 : TriggerState {
            internal State트루카Script10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 308, enable: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__15$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State홀슈타트Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Script02 : TriggerState {
            internal State홀슈타트Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 310, enable: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000085_QD__50001538__16$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script11 : TriggerState {
            internal State트루카Script11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 308, enable: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__17$", align: Align.Right, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State트루카Script12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트루카Script12 : TriggerState {
            internal State트루카Script12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 309, enable: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__18$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortalEffect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEffect : TriggerState {
            internal StatePortalEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 1003, sequenceName: "Bore_A");
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000085_QD__50001538__19$", align: Align.Left, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateNPC합체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC합체 : TriggerState {
            internal StateNPC합체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1099");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1099");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 600)) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1003, 1004});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortalDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalDestroy : TriggerState {
            internal StatePortalDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State설눈이이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이이동02 : TriggerState {
            internal State설눈이이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 311, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC");
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State설눈이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script02 : TriggerState {
            internal State설눈이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__20$", align: Align.Right, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다방향전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다방향전환 : TriggerState {
            internal State에르다방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script05 : TriggerState {
            internal State에르다Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 312, enable: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__21$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State설눈이Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script03 : TriggerState {
            internal State설눈이Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__22$", align: Align.Right, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script06 : TriggerState {
            internal State에르다Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1002, sequenceName: "Attack_Idle_A", duration: 999999999999f);
                context.CameraSelect(triggerId: 313, enable: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__23$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004});
                context.CreateMonster(spawnIds: new []{2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveUser(mapId: 52000085, portalId: 99);
                context.AddBuff(boxIds: new []{199}, skillId: 70000115, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.CreateMonster(spawnIds: new []{2003, 2004, 2005}, arg2: false);
                    return new State에르다DeadWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다DeadWait : TriggerState {
            internal State에르다DeadWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    return new State에르다DeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다DeadDelay : TriggerState {
            internal State에르다DeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2003, 2004, 2005});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000085, portalId: 98);
                context.DestroyMonster(spawnIds: new []{2001, 2002});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEndStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndStartCinematic : TriggerState {
            internal StateEndStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateEndStopCinematic(context));
                context.CreateMonster(spawnIds: new []{1005, 1006}, arg2: false);
                context.CameraSelect(triggerId: 314, enable: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script07 : TriggerState {
            internal State에르다Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__24$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State설눈이Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script04 : TriggerState {
            internal State설눈이Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__25$", align: Align.Right, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State에르다공중부양Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다공중부양Prepare : TriggerState {
            internal State에르다공중부양Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 315, enable: true);
                context.SetNpcEmotionLoop(spawnId: 1006, sequenceName: "Attack_Idle_A", duration: 999999999999f);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__26$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다공중부양(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다공중부양 : TriggerState {
            internal State에르다공중부양(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_1006");
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__27$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State얼림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State얼림 : TriggerState {
            internal State얼림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1005, sequenceName: "Stun_A", duration: 999999999999f);
                context.SetPcEmotionLoop(sequenceName: "StunFrozen_A", duration: 25000f);
                context.SetEffect(triggerIds: new []{602, 603}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State에르다공중부양중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다공중부양중 : TriggerState {
            internal State에르다공중부양중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 316, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StatePC말풍선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선Script01 : TriggerState {
            internal StatePC말풍선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1006});
                context.CameraSelect(triggerId: 317, enable: true);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000085_QD__50001538__28$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State설눈이말풍선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이말풍선Script01 : TriggerState {
            internal State설눈이말풍선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1007}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1005, script: "$52000085_QD__50001538__29$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선Script02 : TriggerState {
            internal StatePC말풍선Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 318, enable: true);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000085_QD__50001538__30$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State설만이이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설만이이동01 : TriggerState {
            internal State설만이이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1007, script: "$52000085_QD__50001538__31$", arg4: 5);
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State설눈이인사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이인사 : TriggerState {
            internal State설눈이인사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: false);
                context.SetNpcEmotionLoop(spawnId: 1005, sequenceName: "Idle_A", duration: 999999999999f);
                context.SetConversation(type: 1, spawnId: 1005, script: "$52000085_QD__50001538__32$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State설만이이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설만이이동02 : TriggerState {
            internal State설만이이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005A");
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선Script03 : TriggerState {
            internal StatePC말풍선Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: false);
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 1000f);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC2");
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007C");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000085_QD__50001538__33$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State설만이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설만이Script01 : TriggerState {
            internal State설만이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateEndStopCinematic(context));
                context.CameraSelect(triggerId: 319, enable: true);
                context.AddCinematicTalk(npcId: 11003073, illustId: "11000404", script: "$52000085_QD__50001538__34$", align: Align.Right, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State설눈이Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script05 : TriggerState {
            internal State설눈이Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__35$", align: Align.Left, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State설만이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설만이Script02 : TriggerState {
            internal State설만이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003073, illustId: "11000404", script: "$52000085_QD__50001538__36$", align: Align.Right, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State설눈이Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script06 : TriggerState {
            internal State설눈이Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__37$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State설눈이Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script07 : TriggerState {
            internal State설눈이Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__38$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEndStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndStopCinematic : TriggerState {
            internal StateEndStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetNpcEmotionLoop(spawnId: 1005, sequenceName: "Idle_A", duration: 999999999999f);
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 1000f);
                context.DestroyMonster(spawnIds: new []{1005, 1006, 1007});
                context.SetAchievement(triggerId: 199, type: "trigger", code: "snowqueenerda");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State던전종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1008, 1009}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
                context.SetPortal(portalId: 91, visible: true, enabled: true, minimapVisible: true);
                context.CameraReset(interpolationTime: 0.0f);
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
