using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000140_qd {
    public static class _main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateCameraCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_01 : TriggerState {
            internal StateCameraCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_02 : TriggerState {
            internal StateCameraCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraCinematic_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_04 : TriggerState {
            internal StateCameraCinematic_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCameraCinematic_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_05 : TriggerState {
            internal StateCameraCinematic_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State삼자대화_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
            }
        }

        private class State삼자대화_01 : TriggerState {
            internal State삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State투르카소멸_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000140_QD__MAIN__0$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State삼자대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_02 : TriggerState {
            internal State삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__1$", duration: 3000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State삼자대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대화_03 : TriggerState {
            internal State삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__2$", duration: 2500, align: Align.Right);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2003");
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__3$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new State투르카소멸_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카소멸_01 : TriggerState {
            internal State투르카소멸_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State투르카소멸_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카소멸_02 : TriggerState {
            internal State투르카소멸_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State어둠의졸개_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어둠의졸개_01 : TriggerState {
            internal State어둠의졸개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103, 104}, arg2: true);
                context.ShowGuideSummary(entityId: 25201401, textId: 25201401);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103, 104})) {
                    return new State졸개퇴치완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸개퇴치완료_01 : TriggerState {
            internal State졸개퇴치완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201401);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State졸개퇴치완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸개퇴치완료_02 : TriggerState {
            internal State졸개퇴치완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000140, portalId: 99);
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State졸개퇴치완료_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸개퇴치완료_03 : TriggerState {
            internal State졸개퇴치완료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State알론과대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론과대화_01 : TriggerState {
            internal State알론과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State투르카Combat_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000140_QD__MAIN__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론과대화_02 : TriggerState {
            internal State알론과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론과대화_03 : TriggerState {
            internal State알론과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000140_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론과대화_04 : TriggerState {
            internal State알론과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__7$", duration: 2500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__8$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new State알론과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론과대화_05 : TriggerState {
            internal State알론과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000140_QD__MAIN__9$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론과대화_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2003");
            }
        }

        private class State알론과대화_06 : TriggerState {
            internal State알론과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__10$", duration: 2000, align: Align.Right);
                context.MoveUserPath(patrolName: "MS2PatrolData_2008");
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State알론과대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론과대화_07 : TriggerState {
            internal State알론과대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003, 8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    return new State2차삼자대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_01 : TriggerState {
            internal State2차삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__11$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차삼자대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_02 : TriggerState {
            internal State2차삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000140_QD__MAIN__12$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차삼자대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_03 : TriggerState {
            internal State2차삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__13$", duration: 2500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__14$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    return new State2차삼자대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_04 : TriggerState {
            internal State2차삼자대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__15$", duration: 2500, align: Align.Center);
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__16$", duration: 2500, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    return new State2차삼자대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_05 : TriggerState {
            internal State2차삼자대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__17$", duration: 2500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__18$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new State2차삼자대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_06 : TriggerState {
            internal State2차삼자대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__19$", duration: 2500, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차삼자대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_07 : TriggerState {
            internal State2차삼자대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__20$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차삼자대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_08 : TriggerState {
            internal State2차삼자대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__21$", duration: 2000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State투르카Combat_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Combat_01 : TriggerState {
            internal State투르카Combat_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{106}, arg2: true);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{105}, arg2: true);
                context.ShowGuideSummary(entityId: 25201402, textId: 25201402);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State투르카Combat_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Combat_02 : TriggerState {
            internal State투르카Combat_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.HideGuideSummary(entityId: 25201402);
                context.MoveUser(mapId: 52000140, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Combat_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Combat_03 : TriggerState {
            internal State투르카Combat_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.DestroyMonster(spawnIds: new []{106});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2008");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3차삼자대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차삼자대화_01 : TriggerState {
            internal State3차삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__22$", duration: 2500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003329, script: "$52000140_QD__MAIN__23$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new State3차삼자대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차삼자대화_02 : TriggerState {
            internal State3차삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000140_QD__MAIN__24$", duration: 2000);
                context.MoveUserPath(patrolName: "MS2PatrolData_2005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    return new State3차삼자대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차삼자대화_03 : TriggerState {
            internal State3차삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.AddCinematicTalk(npcId: 11003328, script: "$52000140_QD__MAIN__25$", duration: 2000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    return new State투르카Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Exit_01 : TriggerState {
            internal State투르카Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.DestroyMonster(spawnIds: new []{102});
                context.SetPcEmotionSequence(sequenceNames: new []{"Priest_Skill_Divine_Protection_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new State투르카Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Exit_02 : TriggerState {
            internal State투르카Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC의부상_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC의부상_01 : TriggerState {
            internal StatePC의부상_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 10000f);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC의부상_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC의부상_02 : TriggerState {
            internal StatePC의부상_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8004, 8005}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC의부상_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC의부상_03 : TriggerState {
            internal StatePC의부상_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000141, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
