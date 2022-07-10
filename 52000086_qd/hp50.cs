using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000086_qd {
    public static class _hp50 {
        public class StateQuest체크50100300_2 : TriggerState {
            internal StateQuest체크50100300_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100300}, questStates: new byte[]{3})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100300}, questStates: new byte[]{2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100300}, questStates: new byte[]{1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크50100310_2 : TriggerState {
            internal StateQuest체크50100310_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100310}, questStates: new byte[]{3})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100310}, questStates: new byte[]{2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100310}, questStates: new byte[]{1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크50100311_2 : TriggerState {
            internal StateQuest체크50100311_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100311}, questStates: new byte[]{3})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100311}, questStates: new byte[]{2})) {
                    return new State던전종료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50100311}, questStates: new byte[]{1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: false);
                context.SetPortal(portalId: 91, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "hp50") == 1) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{1007, 1008}, arg2: false);
                context.MoveUser(mapId: 52000086, portalId: 30);
                context.CameraSelect(triggerId: 313, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Spawn : TriggerState {
            internal State에르다Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateStopCinematic(context));
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(triggerId: 314, enable: true);
                context.MoveNpc(spawnId: 1008, patrolName: "MS2PatrolData_1008A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script01 : TriggerState {
            internal State에르다Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__0$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script01 : TriggerState {
            internal State비에른Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 315, enable: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__1$", align: Align.Left, duration: 3000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__2$", align: Align.Left, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에르다Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script02 : TriggerState {
            internal State에르다Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 316, enable: true);
                context.VisibleMyPc(visible: false);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__3$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State비에른Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script02 : TriggerState {
            internal State비에른Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__4$", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__5$", align: Align.Left, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State비에른접근(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른접근 : TriggerState {
            internal State비에른접근(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1006B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script03 : TriggerState {
            internal State에르다Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.CameraSelect(triggerId: 317, enable: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__6$", align: Align.Right, duration: 4000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__7$", align: Align.Right, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State비에른Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script03 : TriggerState {
            internal State비에른Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 318, enable: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__8$", align: Align.Left, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script04 : TriggerState {
            internal State에르다Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 317, enable: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__9$", align: Align.Right, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비에른Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script04 : TriggerState {
            internal State비에른Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 312, enable: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__10$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script05 : TriggerState {
            internal State비에른Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 318, enable: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__11$", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__12$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State에르다Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script05 : TriggerState {
            internal State에르다Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 317, enable: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__13$", align: Align.Right, duration: 2000);
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
                context.DestroyMonster(spawnIds: new []{1008});
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__14$", align: Align.Left, duration: 2000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__15$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에르다Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script07 : TriggerState {
            internal State에르다Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 319, enable: true);
                context.CreateMonster(spawnIds: new []{1009}, arg2: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__16$", align: Align.Right, duration: 3000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__17$", align: Align.Right, duration: 5000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__18$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State에르다이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다이동 : TriggerState {
            internal State에르다이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1009, patrolName: "MS2PatrolData_1009A");
                context.CameraSelect(triggerId: 320, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script08 : TriggerState {
            internal State에르다Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007A");
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__19$", align: Align.Right, duration: 4000);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__20$", align: Align.Right, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
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
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
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
                context.VisibleMyPc(visible: true);
                context.SetAiExtraData(key: "getBack", value: 1);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{1007, 1008, 1009});
                context.CreateMonster(spawnIds: new []{2098}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBuff(boxIds: new []{199}, skillId: 70000115, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State비에른DeadWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른DeadWait : TriggerState {
            internal State비에른DeadWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new StateDeadCinematicWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadCinematicWait : TriggerState {
            internal StateDeadCinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDeadStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadStartCinematic : TriggerState {
            internal StateDeadStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000086, portalId: 40);
                context.DestroyMonster(spawnIds: new []{2099, 2098});
                context.CreateMonster(spawnIds: new []{1101, 1102}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 1102, sequenceName: "Stun_A", duration: 999999999999f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State에드다이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에드다이동02 : TriggerState {
            internal State에드다이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateDeadStopCinematic(context));
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(triggerId: 321, enable: true);
                context.MoveNpc(spawnId: 1101, patrolName: "MS2PatrolData_1101A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에르다Script10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script10 : TriggerState {
            internal State에르다Script10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__21$", align: Align.Right, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른Script10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script10 : TriggerState {
            internal State비에른Script10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 322, enable: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__22$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다Script11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script11 : TriggerState {
            internal State에르다Script11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__23$", align: Align.Right, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비에른Script11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script11 : TriggerState {
            internal State비에른Script11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 323, enable: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__24$", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__25$", align: Align.Left, duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State비에른Script12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script12 : TriggerState {
            internal State비에른Script12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__26$", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다Script12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script12 : TriggerState {
            internal State에르다Script12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__27$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State비에른Script13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script13 : TriggerState {
            internal State비에른Script13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 322, enable: true);
                context.SetNpcEmotionLoop(spawnId: 1102, sequenceName: "Idle_A", duration: 999999999999f);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__28$", align: Align.Left, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State비에른Script14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script14 : TriggerState {
            internal State비에른Script14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 324, enable: true);
                context.MoveNpc(spawnId: 1102, patrolName: "MS2PatrolData_1102A");
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__HP50__29$", align: Align.Left, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에드다이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에드다이동03 : TriggerState {
            internal State에드다이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 325, enable: true);
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__30$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선대사 : TriggerState {
            internal StatePC말풍선대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000086_QD__HP50__31$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State에르다Script13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script13 : TriggerState {
            internal State에르다Script13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__32$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다Script131(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script131 : TriggerState {
            internal State에르다Script131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003074, illustId: "SnowQueen_normal", script: "$52000086_QD__HP50__33$", align: Align.Right, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다Script14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script14 : TriggerState {
            internal State에르다Script14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 321, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에드다마저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에드다마저이동 : TriggerState {
            internal State에드다마저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDeadStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadStopCinematic : TriggerState {
            internal StateDeadStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{1101, 1102});
                context.CreateMonster(spawnIds: new []{10000, 10001, 10002});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAchievement(triggerId: 199, type: "trigger", code: "snowkingbjorn");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetPortal(portalId: 91, visible: false, enabled: false, minimapVisible: false);
                context.MoveUser(mapId: 52000086, portalId: 30);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State던전종료1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료1 : TriggerState {
            internal State던전종료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3103}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4004, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3104}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: false);
                context.MoveUser(mapId: 52000086, portalId: 30);
                context.DestroyMonster(spawnIds: new []{1101, 1102});
                context.CreateMonster(spawnIds: new []{10000, 10001, 10002});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
