namespace Maple2.Trigger._52010071_qd {
    public static class _52010071 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new State상황설명(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황설명 : TriggerState {
            internal State상황설명(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 9, script: "$52010071_QD__52010071__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State칠신장들_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칠신장들_01 : TriggerState {
            internal State칠신장들_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State칠신장들_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칠신장들_02 : TriggerState {
            internal State칠신장들_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{4000, 4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검마Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Script_01 : TriggerState {
            internal State검마Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 6000f);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__1$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State검마Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Script_02 : TriggerState {
            internal State검마Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검마Script_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Script_03 : TriggerState {
            internal State검마Script_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 15000f);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__2$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__3$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__4$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new State검마Script_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Script_04 : TriggerState {
            internal State검마Script_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State투르카Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script_01 : TriggerState {
            internal State투르카Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 11000f);
                context.AddCinematicTalk(npcId: 11001956, script: "$52010071_QD__52010071__6$", duration: 5000);
                context.AddCinematicTalk(npcId: 11001956, script: "$52010071_QD__52010071__7$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State둘이말함_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둘이말함_01 : TriggerState {
            internal State둘이말함_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Attack_01_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__8$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State둘이말함_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둘이말함_02 : TriggerState {
            internal State둘이말함_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 18000f);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__15$", duration: 6000);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__9$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__10$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001956, script: "$52010071_QD__52010071__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    return new State검마명령_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마명령_02 : TriggerState {
            internal State검마명령_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006, 4007}, returnView: false);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__12$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State검마명령_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마명령_03 : TriggerState {
            internal State검마명령_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__13$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State검마명령_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마명령_04 : TriggerState {
            internal State검마명령_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.AddCinematicTalk(npcId: 11003894, script: "$52010071_QD__52010071__14$", duration: 5000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동시키기_01(context);
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이동시키기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동시키기_01 : TriggerState {
            internal State이동시키기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52010072, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
