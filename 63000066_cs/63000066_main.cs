using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000066_cs {
    public static class _63000066_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 111, 112, 113, 114, 115, 116}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000351}, questStates: new byte[]{1})) {
                    return new State서랍장안내(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000351}, questStates: new byte[]{2})) {
                    return new StateLadder안내(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State서랍장안내 : TriggerState {
            internal State서랍장안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300661, textId: 26300661);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{30000351}, questStates: new byte[]{2})) {
                    return new StateLadder안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder안내 : TriggerState {
            internal StateLadder안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300661);
                context.ShowGuideSummary(entityId: 26300662, textId: 26300662);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{703}, questIds: new []{30000351}, questStates: new byte[]{2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300662);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
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
                if (context.WaitTick(waitTick: 500)) {
                    return new State마리엔Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_01 : TriggerState {
            internal State마리엔Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.AddCinematicTalk(npcId: 11004293, script: "$63000066_CS__63000066_MAIN__0$", duration: 2500, align: Align.Right);
                context.SetSceneSkip(state: new State스킵종료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_02 : TriggerState {
            internal State마리엔Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State마리엔Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_03 : TriggerState {
            internal State마리엔Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Suprise_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_04 : TriggerState {
            internal State마리엔Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_05 : TriggerState {
            internal State마리엔Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004293, script: "$63000066_CS__63000066_MAIN__1$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_07 : TriggerState {
            internal State마리엔Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004293, script: "$63000066_CS__63000066_MAIN__2$", duration: 3000, align: Align.Right);
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
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State마리엔Spawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_09 : TriggerState {
            internal State마리엔Spawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "Think_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_10 : TriggerState {
            internal State마리엔Spawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Spawn_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Spawn_11 : TriggerState {
            internal State마리엔Spawn_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004293, script: "$63000066_CS__63000066_MAIN__3$", duration: 2500, align: Align.Right);
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
                context.SetEffect(triggerIds: new []{5003}, visible: true);
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
                context.FaceEmotion(spawnId: 0);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State스킵종료 : TriggerState {
            internal State스킵종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.FaceEmotion(spawnId: 0);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(triggerIds: new []{5003}, visible: false);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
