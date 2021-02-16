using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000085_qd {
    public static class _50001538 {
        public class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100280}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100280}, arg3: new byte[] {2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100280}, arg3: new byte[] {3})) {
                    return new State던전종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602, 603}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
                context.SetPortal(portalId: 91, visible: false, enabled: false, minimapVisible: false);
                context.RemoveBuff(arg1: 199, arg2: 70000115);
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
                context.SetLocalCamera(cameraId: 2000, enable: false);
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 999999999999f);
                context.SetSkip(state: new StateStopCinematic(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 300, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__0$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__1$", align: Align.Left, duration: 6000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__2$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003A");
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__3$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__4$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 302, arg2: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__6$", align: Align.Right, duration: 3000);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 303, arg2: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__9$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__11$", align: Align.Right, duration: 6000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 305, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003B");
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__12$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__13$", align: Align.Left, duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004A");
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 307, arg2: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000085_QD__50001538__14$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 308, arg2: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__15$", align: Align.Right, duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 310, arg2: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000085_QD__50001538__16$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 308, arg2: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__17$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 309, arg2: true);
                context.AddCinematicTalk(npcId: 11003071, illustId: "11003762", script: "$52000085_QD__50001538__18$", align: Align.Right, duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Bore_A");
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", script: "$52000085_QD__50001538__19$", align: Align.Left, duration: 2000);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1099");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1099");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {1003, 1004});
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 311, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001B");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 312, arg2: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__21$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 1002, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.CameraSelect(arg1: 313, arg2: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__23$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004});
                context.CreateMonster(arg1: new[] {2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveUser(arg1: 52000085, arg2: 99);
                context.AddBuff(arg1: new[] {199}, arg2: 70000115, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.CreateMonster(arg1: new[] {2003, 2004, 2005}, arg2: false);
                    return new State에르다DeadWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다DeadWait : TriggerState {
            internal State에르다DeadWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new State에르다DeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다DeadDelay : TriggerState {
            internal State에르다DeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2003, 2004, 2005});
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 52000085, arg2: 98);
                context.DestroyMonster(arg1: new[] {2001, 2002});
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {1005, 1006}, arg2: false);
                context.CameraSelect(arg1: 314, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 315, arg2: true);
                context.SetNpcEmotionLoop(arg1: 1006, arg2: "Attack_Idle_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000085_QD__50001538__26$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006");
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000085_QD__50001538__27$", align: Align.Right, duration: 3000);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Stun_A", arg3: 999999999999f);
                context.SetPcEmotionLoop(arg1: "StunFrozen_A", arg2: 25000f);
                context.SetEffect(arg1: new[] {602, 603}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 316, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {1006});
                context.CameraSelect(arg1: 317, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000085_QD__50001538__28$", arg4: 3);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1005, script: "$52000085_QD__50001538__29$", arg4: 4);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 318, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000085_QD__50001538__30$", arg4: 3);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 1007, script: "$52000085_QD__50001538__31$", arg4: 5);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007A");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Idle_A", arg3: 999999999999f);
                context.SetConversation(arg1: 1, arg2: 1005, script: "$52000085_QD__50001538__32$", arg4: 2);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005A");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007B");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 1000f);
                context.MoveUserPath(arg1: "MS2PatrolData_PC2");
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007C");
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000085_QD__50001538__33$", arg4: 3);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 319, arg2: true);
                context.AddCinematicTalk(npcId: 11003073, illustId: "11000404", script: "$52000085_QD__50001538__34$", align: Align.Right, duration: 6000);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Idle_A", arg3: 999999999999f);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 1000f);
                context.DestroyMonster(arg1: new[] {1005, 1006, 1007});
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "snowqueenerda");
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {1008, 1009}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(arg1: new[] {601, 602, 603}, arg2: false);
                context.SetPortal(portalId: 91, visible: true, enabled: true, minimapVisible: true);
                context.CameraReset(interpolationTime: 0.0f);
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