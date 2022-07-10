using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000124_qd {
    public static class _main_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100145}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100145, 60100146, 60100147, 60100148, 60100149, 60100150}, questStates: new byte[]{2})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000124, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.CreateMonster(spawnIds: new []{401, 402}, arg2: true);
                context.AddCinematicTalk(npcId: 11000069, script: "$52000124_QD__MAIN_01__0$", duration: 2000, align: Align.Left);
                context.SetSceneSkip(state: new StateBattle_ready(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000069, script: "$52000124_QD__MAIN_01__1$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, arg2: true);
                context.AddCinematicTalk(npcId: 11003304, script: "$52000124_QD__MAIN_01__2$", duration: 2000, align: Align.Left);
                context.AddBalloonTalk(spawnId: 101, msg: "$52000124_QD__MAIN_01__3$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003304, script: "$52000124_QD__MAIN_01__4$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000069, script: "$52000124_QD__MAIN_01__5$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003304, script: "$52000124_QD__MAIN_01__6$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003304, script: "$52000124_QD__MAIN_01__7$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_ready : TriggerState {
            internal StateBattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{401, 402});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{601, 602}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleMsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleMsg : TriggerState {
            internal StateBattleMsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000124_QD__MAIN_01__8$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "eveguard");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWinready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWinready : TriggerState {
            internal StateWinready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{601, 602});
                context.MoveUser(mapId: 52000124, portalId: 6001);
                context.CreateMonster(spawnIds: new []{302}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3002");
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
                context.AddCinematicTalk(npcId: 11003196, illustId: "Katvan_normal", script: "$52000124_QD__MAIN_01__9$", duration: 3000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{302});
                context.CreateMonster(spawnIds: new []{301}, arg2: true);
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

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateDel : TriggerState {
            internal StateDel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
