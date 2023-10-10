using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000146_qd {
    public static class _52000146_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State한번더Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한번더Wait : TriggerState {
            internal State한번더Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_01 : TriggerState {
            internal StateCamera이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_02 : TriggerState {
            internal StateCamera이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000146_QD__52000146_MAIN__0$", script: "$52000146_QD__52000146_MAIN__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera리셋_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋_01 : TriggerState {
            internal StateCamera리셋_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera리셋_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋_02 : TriggerState {
            internal StateCamera리셋_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera리셋_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋_03 : TriggerState {
            internal StateCamera리셋_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State걸으며대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_01 : TriggerState {
            internal State걸으며대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State걸으며대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_02 : TriggerState {
            internal State걸으며대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__2$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__3$", duration: 4000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State걸으며대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_03 : TriggerState {
            internal State걸으며대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State걸으며대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_04 : TriggerState {
            internal State걸으며대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__5$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State걸으며대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_05 : TriggerState {
            internal State걸으며대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__6$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State걸으며대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State걸으며대화_06 : TriggerState {
            internal State걸으며대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__7$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State멈춰서대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State멈춰서대화_01 : TriggerState {
            internal State멈춰서대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__8$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State멈춰서대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State멈춰서대화_02 : TriggerState {
            internal State멈춰서대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__9$", duration: 4000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_01 : TriggerState {
            internal State전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{102, 103, 104, 105, 106});
                context.CreateMonster(spawnIds: new []{107, 108, 109, 110, 111}, arg2: true);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{112}, arg2: false);
                context.ShowGuideSummary(entityId: 25201461, textId: 25201461);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{107, 108, 109, 110, 111})) {
                    return new State전투_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_02 : TriggerState {
            internal State전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{107, 108, 109, 110, 111}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{107, 108, 109, 110, 111})) {
                    return new State전투종료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료_01 : TriggerState {
            internal State전투종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201461);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투종료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료_02 : TriggerState {
            internal State전투종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000146, portalId: 99);
                context.DestroyMonster(spawnIds: new []{112});
                context.CreateMonster(spawnIds: new []{113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투종료_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료_03 : TriggerState {
            internal State전투종료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투후대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_01 : TriggerState {
            internal State전투후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State스킵도착_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__10$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_02 : TriggerState {
            internal State전투후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__11$", duration: 3000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_03 : TriggerState {
            internal State전투후대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__12$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_04 : TriggerState {
            internal State전투후대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__13$", duration: 3500, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_05 : TriggerState {
            internal State전투후대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__14$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_06 : TriggerState {
            internal State전투후대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000146_QD__52000146_MAIN__15$", duration: 4000, illustId: "Hastur_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_07 : TriggerState {
            internal State전투후대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투후대화_08(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{113});
            }
        }

        private class State전투후대화_08 : TriggerState {
            internal State전투후대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__16$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State전투후대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵도착_01 : TriggerState {
            internal State스킵도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{113});
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스킵도착_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵도착_02 : TriggerState {
            internal State스킵도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투후대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_09 : TriggerState {
            internal State전투후대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000146_QD__52000146_MAIN__17$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전투후대화_10(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class State전투후대화_10 : TriggerState {
            internal State전투후대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투후대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후대화_11 : TriggerState {
            internal State전투후대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State하스터찾기_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__18$", duration: 4000, align: Align.Right);
                context.AddCinematicTalk(npcId: 0, script: "$52000146_QD__52000146_MAIN__19$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new State하스터찾기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터찾기_01 : TriggerState {
            internal State하스터찾기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201462, textId: 25201462);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201462);
                context.MoveUser(mapId: 52000147, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
