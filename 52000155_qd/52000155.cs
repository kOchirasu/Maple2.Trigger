namespace Maple2.Trigger._52000155_qd {
    public static class _52000155 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{40002728}, questStates: new byte[]{3})) {
                    return new State전직하러_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{40002725}, questStates: new byte[]{3})) {
                    return new StateGuide_01(context);
                }

                if (context.UserDetected(boxIds: new []{2002})) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_03 : TriggerState {
            internal StateWait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{108, 109, 110}, arg2: false);
                context.MoveUser(mapId: 52000155, portalId: 6001);
                context.CameraSelectPath(pathIds: new []{4003, 4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State빅스제시_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빅스제시_01 : TriggerState {
            internal State빅스제시_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{40002725}, questStates: new byte[]{2})) {
                    return new State만취상태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State만취상태 : TriggerState {
            internal State만취상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000155_QD__52000155__0$", arg3: false);
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State만취상태_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State만취상태_01 : TriggerState {
            internal State만취상태_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{105, 106}, arg2: false);
                context.DestroyMonster(spawnIds: new []{108, 109});
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Down_Idle_A", duration: 90000000f);
                context.SetNpcEmotionLoop(spawnId: 106, sequenceName: "Down_Idle_A", duration: 90000000f);
                context.MoveUser(mapId: 52000155, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정리2_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리2_02 : TriggerState {
            internal State정리2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리2_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리2_03 : TriggerState {
            internal State정리2_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{40002726}, questStates: new byte[]{2})) {
                    return new StateGuide_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide_01 : TriggerState {
            internal StateGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: true);
                context.DestroyMonster(spawnIds: new []{110});
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.ShowGuideSummary(entityId: 25201551, textId: 25201551, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{40002727}, questStates: new byte[]{2})) {
                    return new StateGuide_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide_02 : TriggerState {
            internal StateGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{40002728}, questStates: new byte[]{2})) {
                    return new State전직하러_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직하러_01 : TriggerState {
            internal State전직하러_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직하러_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직하러_02 : TriggerState {
            internal State전직하러_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000157, portalId: 6003);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
