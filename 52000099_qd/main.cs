using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000099_qd {
    public static class _main {
        public class State50100520Quest체크 : TriggerState {
            internal State50100520Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50100520}, questStates: new byte[]{3})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50100520}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50100540Quest체크 : TriggerState {
            internal State50100540Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50100540}, questStates: new byte[]{3})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50100540}, questStates: new byte[]{2})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50100540}, questStates: new byte[]{1})) {
                    return new StatePhase_end_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 701, skillId: 99910180);
                context.SetActor(triggerId: 3101, visible: false, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 3102, visible: false, initialSequence: "Attack_Idle_A");
                context.SetLocalCamera(cameraId: 8017, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, visible: true);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{7001, 7002, 7003}, visible: false);
                context.SetEffect(triggerIds: new []{7004}, visible: true);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateReady2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady2 : TriggerState {
            internal StateReady2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.MoveUser(mapId: 52000099, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart2 : TriggerState {
            internal StateStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateScene_07(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8001, 8002, 8003}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__20$", duration: 5000, align: Align.Left);
                context.CameraSelectPath(pathIds: new []{8004, 8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2004");
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__21$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006, 8007}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2005");
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__22$", duration: 3000, align: Align.Left);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7002}, visible: true);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__23$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "IceSphere_A,Attack_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 71000007, level: 1, arg4: false, arg5: false);
                context.AddBuff(boxIds: new []{701}, skillId: 71000008, level: 1, arg4: false, arg5: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Attack_Idle_A", duration: 3000f);
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
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSkip();
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
                context.ShowGuideSummary(entityId: 25200991, textId: 25200991, duration: 5000);
                context.CreateMonster(spawnIds: new []{201, 202, 205, 204}, arg2: true);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, visible: false);
                context.AddBalloonTalk(spawnId: 101, msg: "$52000099_QD__MAIN__24$", duration: 3000);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 204, 205})) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$52000099_QD__MAIN__25$", duration: 3000);
                context.CreateMonster(spawnIds: new []{201, 202, 203}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203})) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$52000099_QD__MAIN__26$", duration: 3000);
                context.CreateMonster(spawnIds: new []{206, 207, 203, 202}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{206, 207, 203, 202})) {
                    return new StateScene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_12 : TriggerState {
            internal StateScene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{123}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_13 : TriggerState {
            internal StateScene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000099, portalId: 2);
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, visible: true);
                context.CameraSelectPath(pathIds: new []{8011, 8012}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_14 : TriggerState {
            internal StateScene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StatePhase_b_scene_05(context));
                context.RemoveBuff(boxId: 103, skillId: 71000007);
                context.RemoveBuff(boxId: 103, skillId: 71000008);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePhase_b_scene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_02 : TriggerState {
            internal StatePhase_b_scene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(triggerId: 701, type: "trigger", code: "Defence1Clear");
                context.MoveNpc(spawnId: 123, patrolName: "MS2PatrolData_2102");
                context.MoveUser(mapId: 52000099, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePhase_b_scene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_03 : TriggerState {
            internal StatePhase_b_scene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8015, 8016}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2008");
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__27$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__28$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__17$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__18$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__19$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePhase_b_scene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_04 : TriggerState {
            internal StatePhase_b_scene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePhase_b_scene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_05 : TriggerState {
            internal StatePhase_b_scene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{122}, arg2: true);
                context.DestroyMonster(spawnIds: new []{123}, arg2: true);
                context.CreateMonster(spawnIds: new []{124}, arg2: true);
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, visible: false);
                context.AddBuff(boxIds: new []{701}, skillId: 71000007, level: 1, arg4: false, arg5: false);
                context.AddBuff(boxIds: new []{701}, skillId: 71000008, level: 1, arg4: false, arg5: false);
                context.SetMesh(triggerIds: new []{3001, 3003, 3004}, visible: true);
                context.MoveUser(mapId: 52000099, portalId: 3);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetLocalCamera(cameraId: 8017, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePhase_b_scene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_06 : TriggerState {
            internal StatePhase_b_scene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "81", seconds: 81, autoRemove: true, display: true);
                context.ShowGuideSummary(entityId: 25200993, textId: 25200993);
                context.CreateMonster(spawnIds: new []{208}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_07 : TriggerState {
            internal StatePhase_b_scene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{209}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_08 : TriggerState {
            internal StatePhase_b_scene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{210}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_09 : TriggerState {
            internal StatePhase_b_scene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{212, 213}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_10 : TriggerState {
            internal StatePhase_b_scene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{211}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_11 : TriggerState {
            internal StatePhase_b_scene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{214, 216}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_12 : TriggerState {
            internal StatePhase_b_scene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{209, 210}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_13 : TriggerState {
            internal StatePhase_b_scene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{211, 211}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_14 : TriggerState {
            internal StatePhase_b_scene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{213, 214}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_15 : TriggerState {
            internal StatePhase_b_scene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{215, 216}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_16 : TriggerState {
            internal StatePhase_b_scene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{210, 211}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_17 : TriggerState {
            internal StatePhase_b_scene_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{212, 213}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_18 : TriggerState {
            internal StatePhase_b_scene_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{212, 213, 214}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePhase_b_scene_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_19 : TriggerState {
            internal StatePhase_b_scene_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "81")) {
                    return new StatePhase_b_scene_end(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220});
            }
        }

        private class StatePhase_b_scene_end : TriggerState {
            internal StatePhase_b_scene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, visible: true);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false);
                context.HideGuideSummary(entityId: 25200993);
                context.SetLocalCamera(cameraId: 8017, enabled: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StatePhase_b_skip_1(context));
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000099, portalId: 3);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "Defence2Clear");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_b_scene_end_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_02 : TriggerState {
            internal StatePhase_b_scene_end_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Disappoint_Idle_A", "Emotion_Disappoint_Idle_A", "Emotion_Disappoint_Idle_A", "Emotion_Disappoint_Idle_A"});
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8018, 8017}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StatePhase_b_scene_end_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_03 : TriggerState {
            internal StatePhase_b_scene_end_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8019, 8020}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StatePhase_b_scene_end_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_04 : TriggerState {
            internal StatePhase_b_scene_end_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3101, visible: true, initialSequence: "Regen_A");
                context.SetActor(triggerId: 3102, visible: true, initialSequence: "Regen_A");
                context.SetEffect(triggerIds: new []{7006, 7007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StatePhase_b_scene_end_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_05 : TriggerState {
            internal StatePhase_b_scene_end_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3101, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 3102, visible: true, initialSequence: "Idle_A");
                context.SetPcEmotionSequence(sequenceNames: new []{"Jump_Damg_A", "Attack_Idle_A", "Attack_Idle_A", "Attack_Idle_A", "Attack_Idle_A", "Attack_Idle_A", "Attack_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePhase_b_scene_end_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_06 : TriggerState {
            internal StatePhase_b_scene_end_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3101, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 3102, visible: true, initialSequence: "Attack_01_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StatePhase_b_scene_end_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_07 : TriggerState {
            internal StatePhase_b_scene_end_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7004}, visible: true);
                context.MoveUser(mapId: 52000099, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePhase_b_scene_end_07_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_07_ready : TriggerState {
            internal StatePhase_b_scene_end_07_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3102, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePhase_b_scene_end_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_08 : TriggerState {
            internal StatePhase_b_scene_end_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{124}, arg2: true);
                context.CameraSelectPath(pathIds: new []{8021}, returnView: false);
                context.CreateMonster(spawnIds: new []{106, 103}, arg2: true);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Disappoint_Idle_A", "Emotion_Disappoint_Idle_A", "Emotion_Disappoint_Idle_A", "Emotion_Disappoint_Idle_A"});
                context.AddCinematicTalk(npcId: 11004034, illustId: "LapentaMage_Idle", script: "$52000099_QD__MAIN__33$", duration: 4000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__34$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePhase_b_scene_end_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_09 : TriggerState {
            internal StatePhase_b_scene_end_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2009");
                context.AddCinematicTalk(npcId: 11000076, illustId: "11000076", script: "$52000099_QD__MAIN__29$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004034, illustId: "LapentaMage_Idle", script: "$52000099_QD__MAIN__30$", duration: 5000, align: Align.Left);
                context.SetActor(triggerId: 3101, visible: false, initialSequence: "Regen_A");
                context.SetActor(triggerId: 3102, visible: false, initialSequence: "Regen_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePhase_b_scene_end_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_scene_end_10 : TriggerState {
            internal StatePhase_b_scene_end_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.AddCinematicTalk(npcId: 11000076, illustId: "11000076", script: "$52000099_QD__MAIN__31$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePhase_c_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_01 : TriggerState {
            internal StatePhase_c_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8023}, returnView: false);
                context.CreateMonster(spawnIds: new []{110, 126}, arg2: true);
                context.SetEffect(triggerIds: new []{7100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_02 : TriggerState {
            internal StatePhase_c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111}, arg2: true);
                context.SetEffect(triggerIds: new []{7101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_03 : TriggerState {
            internal StatePhase_c_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{112}, arg2: true);
                context.SetEffect(triggerIds: new []{7102}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_04 : TriggerState {
            internal StatePhase_c_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{113}, arg2: true);
                context.SetEffect(triggerIds: new []{7103}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_05 : TriggerState {
            internal StatePhase_c_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{114}, arg2: true);
                context.SetEffect(triggerIds: new []{7104}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_06 : TriggerState {
            internal StatePhase_c_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{115}, arg2: true);
                context.SetEffect(triggerIds: new []{7105}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_07 : TriggerState {
            internal StatePhase_c_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{116}, arg2: true);
                context.SetEffect(triggerIds: new []{7106}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_08 : TriggerState {
            internal StatePhase_c_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{117}, arg2: true);
                context.SetEffect(triggerIds: new []{7107}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_09 : TriggerState {
            internal StatePhase_c_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{118}, arg2: true);
                context.SetEffect(triggerIds: new []{7108}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_10 : TriggerState {
            internal StatePhase_c_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{119}, arg2: true);
                context.SetEffect(triggerIds: new []{7109}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_11 : TriggerState {
            internal StatePhase_c_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{120}, arg2: true);
                context.SetEffect(triggerIds: new []{7110}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_c_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_12 : TriggerState {
            internal StatePhase_c_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121}, arg2: true);
                context.SetEffect(triggerIds: new []{7111}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePhase_c_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_13 : TriggerState {
            internal StatePhase_c_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11000076, script: "$52000099_QD__MAIN__32$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_14 : TriggerState {
            internal StatePhase_c_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2081");
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_2082");
                context.MoveNpc(spawnId: 119, patrolName: "MS2PatrolData_2083");
                context.MoveNpc(spawnId: 118, patrolName: "MS2PatrolData_2085");
                context.MoveNpc(spawnId: 117, patrolName: "MS2PatrolData_2091");
                context.MoveNpc(spawnId: 116, patrolName: "MS2PatrolData_2092");
                context.MoveNpc(spawnId: 115, patrolName: "MS2PatrolData_2087");
                context.MoveNpc(spawnId: 114, patrolName: "MS2PatrolData_2088");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2084");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_2089");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2086");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2090");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePhase_c_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_15 : TriggerState {
            internal StatePhase_c_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_c_16 : TriggerState {
            internal StatePhase_c_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270, 3101, 3102}, visible: false);
                context.CreateMonster(spawnIds: new []{201, 202, 205, 204, 211, 212, 215, 214, 215, 216, 217, 218}, arg2: true);
                context.AddBuff(boxIds: new []{701}, skillId: 99910180, level: 1, arg4: false, arg5: false);
                context.DestroyMonster(spawnIds: new []{103});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(timerId: "82", seconds: 82, autoRemove: true, display: true);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8023, enabled: true);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 205, 204, 211, 212, 215, 214})) {
                    return new StatePhase_c_end(context);
                }

                if (context.TimeExpired(timerId: "82")) {
                    return new StatePhase_c_end(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "82");
                context.DestroyMonster(spawnIds: new []{201, 202, 205, 204, 211, 212, 215, 214});
            }
        }

        private class StatePhase_c_end : TriggerState {
            internal StatePhase_c_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetLocalCamera(cameraId: 8023, enabled: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_end_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2081");
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_2082");
                context.MoveNpc(spawnId: 119, patrolName: "MS2PatrolData_2083");
                context.MoveNpc(spawnId: 118, patrolName: "MS2PatrolData_2085");
                context.MoveNpc(spawnId: 117, patrolName: "MS2PatrolData_2091");
                context.MoveNpc(spawnId: 116, patrolName: "MS2PatrolData_2092");
                context.MoveNpc(spawnId: 115, patrolName: "MS2PatrolData_2087");
                context.MoveNpc(spawnId: 114, patrolName: "MS2PatrolData_2088");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2084");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_2089");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2086");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2090");
            }
        }

        private class StatePhase_b_skip_1 : TriggerState {
            internal StatePhase_b_skip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3101, visible: false);
                context.SetActor(triggerId: 3102, visible: false);
                context.DestroyMonster(spawnIds: new []{124}, arg2: true);
                context.DestroyMonster(spawnIds: new []{126}, arg2: true);
                context.DestroyMonster(spawnIds: new []{110}, arg2: true);
                context.DestroyMonster(spawnIds: new []{111}, arg2: true);
                context.DestroyMonster(spawnIds: new []{112}, arg2: true);
                context.DestroyMonster(spawnIds: new []{113}, arg2: true);
                context.DestroyMonster(spawnIds: new []{114}, arg2: true);
                context.DestroyMonster(spawnIds: new []{115}, arg2: true);
                context.DestroyMonster(spawnIds: new []{116}, arg2: true);
                context.DestroyMonster(spawnIds: new []{117}, arg2: true);
                context.DestroyMonster(spawnIds: new []{118}, arg2: true);
                context.DestroyMonster(spawnIds: new []{119}, arg2: true);
                context.DestroyMonster(spawnIds: new []{120}, arg2: true);
                context.DestroyMonster(spawnIds: new []{121}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_b_skip_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_skip_2 : TriggerState {
            internal StatePhase_b_skip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{126, 106, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_b_skip_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_skip_3 : TriggerState {
            internal StatePhase_b_skip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2081");
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_2082");
                context.MoveNpc(spawnId: 119, patrolName: "MS2PatrolData_2083");
                context.MoveNpc(spawnId: 118, patrolName: "MS2PatrolData_2085");
                context.MoveNpc(spawnId: 117, patrolName: "MS2PatrolData_2091");
                context.MoveNpc(spawnId: 116, patrolName: "MS2PatrolData_2092");
                context.MoveNpc(spawnId: 115, patrolName: "MS2PatrolData_2087");
                context.MoveNpc(spawnId: 114, patrolName: "MS2PatrolData_2088");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2084");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_2089");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2086");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2090");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePhase_b_skip_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_skip_4 : TriggerState {
            internal StatePhase_b_skip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000099, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_b_skip_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_b_skip_5 : TriggerState {
            internal StatePhase_b_skip_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270, 3101, 3102}, visible: false);
                context.CreateMonster(spawnIds: new []{201, 202, 205, 204, 211, 212, 215, 214, 215, 216, 217, 218}, arg2: true);
                context.AddBuff(boxIds: new []{701}, skillId: 99910180, level: 1, arg4: false, arg5: false);
                context.DestroyMonster(spawnIds: new []{103});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(timerId: "82", seconds: 82, autoRemove: true, display: true);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8023, enabled: true);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 205, 204, 211, 212, 215, 214})) {
                    return new StatePhase_b_skip_end(context);
                }

                if (context.TimeExpired(timerId: "82")) {
                    return new StatePhase_b_skip_end(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "82");
                context.DestroyMonster(spawnIds: new []{201, 202, 205, 204, 211, 212, 215, 214});
            }
        }

        private class StatePhase_b_skip_end : TriggerState {
            internal StatePhase_b_skip_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetLocalCamera(cameraId: 8023, enabled: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_end_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2081");
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_2082");
                context.MoveNpc(spawnId: 119, patrolName: "MS2PatrolData_2083");
                context.MoveNpc(spawnId: 118, patrolName: "MS2PatrolData_2085");
                context.MoveNpc(spawnId: 117, patrolName: "MS2PatrolData_2091");
                context.MoveNpc(spawnId: 116, patrolName: "MS2PatrolData_2092");
                context.MoveNpc(spawnId: 115, patrolName: "MS2PatrolData_2087");
                context.MoveNpc(spawnId: 114, patrolName: "MS2PatrolData_2088");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2084");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_2089");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2086");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2090");
            }
        }

        private class StatePhase_end_01 : TriggerState {
            internal StatePhase_end_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3101, visible: false);
                context.SetActor(triggerId: 3102, visible: false);
                context.SetVisibleBreakableObject(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, visible: false);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_02 : TriggerState {
            internal StatePhase_end_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{126, 110, 106, 111}, arg2: true);
                context.SetEffect(triggerIds: new []{7101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_03 : TriggerState {
            internal StatePhase_end_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{112}, arg2: true);
                context.SetEffect(triggerIds: new []{7102}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_04 : TriggerState {
            internal StatePhase_end_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{113}, arg2: true);
                context.SetEffect(triggerIds: new []{7103}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_05 : TriggerState {
            internal StatePhase_end_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{114}, arg2: true);
                context.SetEffect(triggerIds: new []{7104}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_06 : TriggerState {
            internal StatePhase_end_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{115}, arg2: true);
                context.SetEffect(triggerIds: new []{7105}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_07 : TriggerState {
            internal StatePhase_end_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{116}, arg2: true);
                context.SetEffect(triggerIds: new []{7106}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_08 : TriggerState {
            internal StatePhase_end_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{117}, arg2: true);
                context.SetEffect(triggerIds: new []{7107}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_09 : TriggerState {
            internal StatePhase_end_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{118}, arg2: true);
                context.SetEffect(triggerIds: new []{7108}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_10 : TriggerState {
            internal StatePhase_end_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{119}, arg2: true);
                context.SetEffect(triggerIds: new []{7109}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_11 : TriggerState {
            internal StatePhase_end_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{120}, arg2: true);
                context.SetEffect(triggerIds: new []{7110}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePhase_end_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end_12 : TriggerState {
            internal StatePhase_end_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121}, arg2: true);
                context.SetEffect(triggerIds: new []{7111}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePhase_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePhase_end : TriggerState {
            internal StatePhase_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8023, enabled: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_end_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2081");
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_2082");
                context.MoveNpc(spawnId: 119, patrolName: "MS2PatrolData_2083");
                context.MoveNpc(spawnId: 118, patrolName: "MS2PatrolData_2085");
                context.MoveNpc(spawnId: 117, patrolName: "MS2PatrolData_2091");
                context.MoveNpc(spawnId: 116, patrolName: "MS2PatrolData_2092");
                context.MoveNpc(spawnId: 115, patrolName: "MS2PatrolData_2087");
                context.MoveNpc(spawnId: 114, patrolName: "MS2PatrolData_2088");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2084");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_2089");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2086");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2090");
            }
        }

        private class StatePhase_c_end_02 : TriggerState {
            internal StatePhase_c_end_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(triggerId: 701, type: "trigger", code: "AlonRpClear");
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveUser(mapId: 52000099, portalId: 2);
                context.CreateMonster(spawnIds: new []{104}, arg2: true);
                context.RemoveBuff(boxId: 701, skillId: 99910180);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
