using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000067_cs {
    public static class _63000067_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000352}, questStates: new byte[]{1})) {
                    return new State인형찾기(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000352}, questStates: new byte[]{2})) {
                    return new State마리엔의방(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateEnd_일반(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인형찾기 : TriggerState {
            internal State인형찾기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300671, textId: 26300671);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{30000352}, questStates: new byte[]{2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔의방 : TriggerState {
            internal State마리엔의방(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{30000352}, questStates: new byte[]{2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300671);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State암전_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_01 : TriggerState {
            internal State마리엔Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State스킵종료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_02 : TriggerState {
            internal State마리엔Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }
        }

        private class State마리엔Spawn_03 : TriggerState {
            internal State마리엔Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_04 : TriggerState {
            internal State마리엔Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000067_CS__63000067_MAIN__0$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_05 : TriggerState {
            internal State마리엔Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000067_CS__63000067_MAIN__1$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_06 : TriggerState {
            internal State마리엔Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_07 : TriggerState {
            internal State마리엔Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000067_CS__63000067_MAIN__2$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Spawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_08 : TriggerState {
            internal State마리엔Spawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Spawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_09 : TriggerState {
            internal State마리엔Spawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000067_CS__63000067_MAIN__3$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Spawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_10 : TriggerState {
            internal State마리엔Spawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, script: "$63000067_CS__63000067_MAIN__4$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_01 : TriggerState {
            internal State마리엔Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(spawnIds: new []{201});
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마리엔Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_02 : TriggerState {
            internal State마리엔Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                return new StateEnd_Quest(context);
            }

            public override void OnExit() { }
        }

        private class State스킵종료 : TriggerState {
            internal State스킵종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                return new StateEnd_Quest(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd_Quest : TriggerState {
            internal StateEnd_Quest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_일반 : TriggerState {
            internal StateEnd_일반(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
