using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000099_qd {
    public static class _main {
        public class State50100520Quest체크 : TriggerState {
            internal State50100520Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100520}, arg3: new byte[] {3})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100520}, arg3: new byte[] {2})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100520}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50100540Quest체크 : TriggerState {
            internal State50100540Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100540}, arg3: new byte[] {3})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100540}, arg3: new byte[] {2})) {
                    return new StatePhase_end_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100540}, arg3: new byte[] {1})) {
                    return new StatePhase_end_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 701, arg2: 99910180);
                context.SetActor(arg1: 3101, arg2: false, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 3102, arg2: false, arg3: "Attack_Idle_A");
                context.SetLocalCamera(cameraId: 8017, enable: false);
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, arg2: true);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {7001, 7002, 7003}, arg2: false);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateReady2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady2 : TriggerState {
            internal StateReady2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.MoveUser(arg1: 52000099, arg2: 1);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8001, 8002, 8003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8004, 8005}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2004");
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__21$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8006, 8007}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2005");
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__22$", duration: 3000, align: Align.Left);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7002}, arg2: true);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__23$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "IceSphere_A,Attack_Idle_A");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8009}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.AddBuff(arg1: new[] {701}, arg2: 71000007, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {701}, arg2: 71000008, arg3: 1, arg4: false, arg5: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_Idle_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSkip();
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {201, 202, 205, 204}, arg2: true);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
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
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000099_QD__MAIN__24$", duration: 3000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2007");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 204, 205})) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000099_QD__MAIN__25$", duration: 3000);
                context.CreateMonster(arg1: new[] {201, 202, 203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203})) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000099_QD__MAIN__26$", duration: 3000);
                context.CreateMonster(arg1: new[] {206, 207, 203, 202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {206, 207, 203, 202})) {
                    return new StateScene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_12 : TriggerState {
            internal StateScene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {123}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 52000099, arg2: 2);
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, arg2: true);
                context.CameraSelectPath(pathIds: new[] {8011, 8012}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.RemoveBuff(arg1: 103, arg2: 71000007);
                context.RemoveBuff(arg1: 103, arg2: 71000008);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "Defence1Clear");
                context.MoveNpc(arg1: 123, arg2: "MS2PatrolData_2102");
                context.MoveUser(arg1: 52000099, arg2: 2);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8015, 8016}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2008");
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__27$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__28$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__17$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__18$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__19$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {122}, arg2: true);
                context.DestroyMonster(arg1: new[] {123}, arg2: true);
                context.CreateMonster(arg1: new[] {124}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, arg2: false);
                context.AddBuff(arg1: new[] {701}, arg2: 71000007, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {701}, arg2: 71000008, arg3: 1, arg4: false, arg5: false);
                context.SetMesh(arg1: new[] {3001, 3003, 3004}, arg2: true);
                context.MoveUser(arg1: 52000099, arg2: 3);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetLocalCamera(cameraId: 8017, enable: true);
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "81", arg2: 81, arg3: true, arg4: true);
                context.ShowGuideSummary(entityId: 25200993, textId: 25200993);
                context.CreateMonster(arg1: new[] {208}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {209}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {210}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {212, 213}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {211}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {214, 216}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {209, 210}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {211, 211}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {213, 214}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {215, 216}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {210, 211}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {212, 213}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {212, 213, 214}, arg2: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "81")) {
                    return new StatePhase_b_scene_end(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220});
            }
        }

        private class StatePhase_b_scene_end : TriggerState {
            internal StatePhase_b_scene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, arg2: true);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004}, arg2: false);
                context.HideGuideSummary(entityId: 25200993);
                context.SetLocalCamera(cameraId: 8017, enable: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StatePhase_b_skip_1(context));
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000099, arg2: 3);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "Defence2Clear");
            }

            public override TriggerState Execute() {
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
                context.SetPcEmotionSequence(arg1: "Emotion_Disappoint_Idle_A,Emotion_Disappoint_Idle_A,Emotion_Disappoint_Idle_A,Emotion_Disappoint_Idle_A");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new[] {8018, 8017}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8019, 8020}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 3101, arg2: true, arg3: "Regen_A");
                context.SetActor(arg1: 3102, arg2: true, arg3: "Regen_A");
                context.SetEffect(arg1: new[] {7006, 7007}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 3101, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 3102, arg2: true, arg3: "Idle_A");
                context.SetPcEmotionSequence(arg1: "Jump_Damg_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 3101, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 3102, arg2: true, arg3: "Attack_01_A");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7004}, arg2: true);
                context.MoveUser(arg1: 52000099, arg2: 2);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 3102, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {124}, arg2: true);
                context.CameraSelectPath(pathIds: new[] {8021}, arg2: false);
                context.CreateMonster(arg1: new[] {106, 103}, arg2: true);
                context.SetPcEmotionSequence(arg1: "Emotion_Disappoint_Idle_A,Emotion_Disappoint_Idle_A,Emotion_Disappoint_Idle_A,Emotion_Disappoint_Idle_A");
                context.AddCinematicTalk(npcId: 11004034, illustId: "LapentaMage_Idle", script: "$52000099_QD__MAIN__33$", duration: 4000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003087, illustId: "11003087", script: "$52000099_QD__MAIN__34$", duration: 2000, align: Align.Right);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8022}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2009");
                context.AddCinematicTalk(npcId: 11000076, illustId: "11000076", script: "$52000099_QD__MAIN__29$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004034, illustId: "LapentaMage_Idle", script: "$52000099_QD__MAIN__30$", duration: 5000, align: Align.Left);
                context.SetActor(arg1: 3101, arg2: false, arg3: "Regen_A");
                context.SetActor(arg1: 3102, arg2: false, arg3: "Regen_A");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.AddCinematicTalk(npcId: 11000076, illustId: "11000076", script: "$52000099_QD__MAIN__31$", duration: 5000, align: Align.Left);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8023}, arg2: false);
                context.CreateMonster(arg1: new[] {110, 126}, arg2: true);
                context.SetEffect(arg1: new[] {7100}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {111}, arg2: true);
                context.SetEffect(arg1: new[] {7101}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {112}, arg2: true);
                context.SetEffect(arg1: new[] {7102}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {113}, arg2: true);
                context.SetEffect(arg1: new[] {7103}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {114}, arg2: true);
                context.SetEffect(arg1: new[] {7104}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {115}, arg2: true);
                context.SetEffect(arg1: new[] {7105}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {116}, arg2: true);
                context.SetEffect(arg1: new[] {7106}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {117}, arg2: true);
                context.SetEffect(arg1: new[] {7107}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {118}, arg2: true);
                context.SetEffect(arg1: new[] {7108}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {119}, arg2: true);
                context.SetEffect(arg1: new[] {7109}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {120}, arg2: true);
                context.SetEffect(arg1: new[] {7110}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {121}, arg2: true);
                context.SetEffect(arg1: new[] {7111}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8022}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11000076, script: "$52000099_QD__MAIN__32$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2081");
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_2082");
                context.MoveNpc(arg1: 119, arg2: "MS2PatrolData_2083");
                context.MoveNpc(arg1: 118, arg2: "MS2PatrolData_2085");
                context.MoveNpc(arg1: 117, arg2: "MS2PatrolData_2091");
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_2092");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_2087");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_2088");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2084");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_2089");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_2086");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2090");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270, 3101, 3102}, arg2: false);
                context.CreateMonster(arg1: new[] {201, 202, 205, 204, 211, 212, 215, 214, 215, 216, 217, 218}, arg2: true);
                context.AddBuff(arg1: new[] {701}, arg2: 99910180, arg3: 1, arg4: false, arg5: false);
                context.DestroyMonster(arg1: new[] {103});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(id: "82", arg2: 82, arg3: true, arg4: true);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8023, enable: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 205, 204, 211, 212, 215, 214})) {
                    return new StatePhase_c_end(context);
                }

                if (context.TimeExpired(arg1: "82")) {
                    return new StatePhase_c_end(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "82");
                context.DestroyMonster(arg1: new[] {201, 202, 205, 204, 211, 212, 215, 214});
            }
        }

        private class StatePhase_c_end : TriggerState {
            internal StatePhase_c_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetLocalCamera(cameraId: 8023, enable: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_end_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2081");
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_2082");
                context.MoveNpc(arg1: 119, arg2: "MS2PatrolData_2083");
                context.MoveNpc(arg1: 118, arg2: "MS2PatrolData_2085");
                context.MoveNpc(arg1: 117, arg2: "MS2PatrolData_2091");
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_2092");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_2087");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_2088");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2084");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_2089");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_2086");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2090");
            }
        }

        private class StatePhase_b_skip_1 : TriggerState {
            internal StatePhase_b_skip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3101, arg2: false);
                context.SetActor(arg1: 3102, arg2: false);
                context.DestroyMonster(arg1: new[] {124}, arg2: true);
                context.DestroyMonster(arg1: new[] {126}, arg2: true);
                context.DestroyMonster(arg1: new[] {110}, arg2: true);
                context.DestroyMonster(arg1: new[] {111}, arg2: true);
                context.DestroyMonster(arg1: new[] {112}, arg2: true);
                context.DestroyMonster(arg1: new[] {113}, arg2: true);
                context.DestroyMonster(arg1: new[] {114}, arg2: true);
                context.DestroyMonster(arg1: new[] {115}, arg2: true);
                context.DestroyMonster(arg1: new[] {116}, arg2: true);
                context.DestroyMonster(arg1: new[] {117}, arg2: true);
                context.DestroyMonster(arg1: new[] {118}, arg2: true);
                context.DestroyMonster(arg1: new[] {119}, arg2: true);
                context.DestroyMonster(arg1: new[] {120}, arg2: true);
                context.DestroyMonster(arg1: new[] {121}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {126, 106, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2081");
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_2082");
                context.MoveNpc(arg1: 119, arg2: "MS2PatrolData_2083");
                context.MoveNpc(arg1: 118, arg2: "MS2PatrolData_2085");
                context.MoveNpc(arg1: 117, arg2: "MS2PatrolData_2091");
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_2092");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_2087");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_2088");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2084");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_2089");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_2086");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2090");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000099, arg2: 3);
            }

            public override TriggerState Execute() {
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
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270, 3101, 3102}, arg2: false);
                context.CreateMonster(arg1: new[] {201, 202, 205, 204, 211, 212, 215, 214, 215, 216, 217, 218}, arg2: true);
                context.AddBuff(arg1: new[] {701}, arg2: 99910180, arg3: 1, arg4: false, arg5: false);
                context.DestroyMonster(arg1: new[] {103});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(id: "82", arg2: 82, arg3: true, arg4: true);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8023, enable: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 205, 204, 211, 212, 215, 214})) {
                    return new StatePhase_b_skip_end(context);
                }

                if (context.TimeExpired(arg1: "82")) {
                    return new StatePhase_b_skip_end(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "82");
                context.DestroyMonster(arg1: new[] {201, 202, 205, 204, 211, 212, 215, 214});
            }
        }

        private class StatePhase_b_skip_end : TriggerState {
            internal StatePhase_b_skip_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetLocalCamera(cameraId: 8023, enable: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_end_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2081");
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_2082");
                context.MoveNpc(arg1: 119, arg2: "MS2PatrolData_2083");
                context.MoveNpc(arg1: 118, arg2: "MS2PatrolData_2085");
                context.MoveNpc(arg1: 117, arg2: "MS2PatrolData_2091");
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_2092");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_2087");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_2088");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2084");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_2089");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_2086");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2090");
            }
        }

        private class StatePhase_end_01 : TriggerState {
            internal StatePhase_end_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3101, arg2: false);
                context.SetActor(arg1: 3102, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2251, 2252, 2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270}, arg2: false);
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {126, 110, 106, 111}, arg2: true);
                context.SetEffect(arg1: new[] {7101}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {112}, arg2: true);
                context.SetEffect(arg1: new[] {7102}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {113}, arg2: true);
                context.SetEffect(arg1: new[] {7103}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {114}, arg2: true);
                context.SetEffect(arg1: new[] {7104}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {115}, arg2: true);
                context.SetEffect(arg1: new[] {7105}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {116}, arg2: true);
                context.SetEffect(arg1: new[] {7106}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {117}, arg2: true);
                context.SetEffect(arg1: new[] {7107}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {118}, arg2: true);
                context.SetEffect(arg1: new[] {7108}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {119}, arg2: true);
                context.SetEffect(arg1: new[] {7109}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {120}, arg2: true);
                context.SetEffect(arg1: new[] {7110}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {121}, arg2: true);
                context.SetEffect(arg1: new[] {7111}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetLocalCamera(cameraId: 8023, enable: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePhase_c_end_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2081");
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_2082");
                context.MoveNpc(arg1: 119, arg2: "MS2PatrolData_2083");
                context.MoveNpc(arg1: 118, arg2: "MS2PatrolData_2085");
                context.MoveNpc(arg1: 117, arg2: "MS2PatrolData_2091");
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_2092");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_2087");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_2088");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2084");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_2089");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_2086");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2090");
            }
        }

        private class StatePhase_c_end_02 : TriggerState {
            internal StatePhase_c_end_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "AlonRpClear");
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveUser(arg1: 52000099, arg2: 2);
                context.CreateMonster(arg1: new[] {104}, arg2: true);
                context.RemoveBuff(arg1: 701, arg2: 99910180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}