using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000126_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100210}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.MoveUser(mapId: 52000126, portalId: 6002);
                context.SetSceneSkip(state: new StateBattle_ready(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003209, script: "$52000126_QD__MAIN__0$", duration: 2000, align: Align.Left);
                context.CreateMonster(spawnIds: new []{301, 302, 303}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003209, script: "$52000126_QD__MAIN__1$", duration: 2000, align: Align.Left);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3003");
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_3004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003214, script: "$52000126_QD__MAIN__2$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003214, script: "$52000126_QD__MAIN__3$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003214, script: "$52000126_QD__MAIN__4$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005, 4006, 4007}, returnView: false);
                context.AddCinematicTalk(npcId: 11003214, script: "$52000126_QD__MAIN__5$", duration: 3000, align: Align.Left);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: true);
                context.SetOnetimeEffect(id: 20, enabled: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3005");
                context.SetNpcEmotionLoop(spawnId: 302, sequenceName: "Attack_Idle_A", duration: 7000f);
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Attack_Idle_A", duration: 7000f);
                context.AddCinematicTalk(npcId: 11003213, script: "$52000126_QD__MAIN__6$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11003214, script: "$52000126_QD__MAIN__7$", duration: 3000, align: Align.Left);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattle_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_ready : TriggerState {
            internal StateBattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{301, 302, 303});
                context.CreateMonster(spawnIds: new []{601, 602, 603}, arg2: true);
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
                context.SetEventUI(arg1: 1, script: "$52000126_QD__MAIN__8$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602, 603})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "maskbattle");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
