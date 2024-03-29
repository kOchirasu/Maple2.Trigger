using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010040_qd {
    public static class _52010040 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000013}, questStates: new byte[]{2})) {
                    return new State도입부Cinematic01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000015}, questStates: new byte[]{3})) {
                    return new State엔딩Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도입부Cinematic01 : TriggerState {
            internal State도입부Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200, 300, 301, 302, 303}, arg2: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State도입부Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도입부Cinematic02 : TriggerState {
            internal State도입부Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010040_QD__52010040__0$", script: "$52010040_QD__52010040__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{2000, 2001, 2002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State도입부Cinematic03_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도입부Cinematic03_b : TriggerState {
            internal State도입부Cinematic03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_blicheCome");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State도입부Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도입부Cinematic03 : TriggerState {
            internal State도입부Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State도입부Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도입부Cinematic04 : TriggerState {
            internal State도입부Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic01 : TriggerState {
            internal State엔딩Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic02 : TriggerState {
            internal State엔딩Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_normal", script: "$52010040_QD__52010040__2$", duration: 6200, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{2012, 2013}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_blicheCome");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_bliche_front");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State엔딩Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic03 : TriggerState {
            internal State엔딩Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010040_QD__52010040__3$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic04 : TriggerState {
            internal State엔딩Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010040_QD__52010040__4$", duration: 5400, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{2010, 2011, 2014}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State엔딩Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic05 : TriggerState {
            internal State엔딩Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010040_QD__52010040__5$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4100)) {
                    return new State엔딩Cinematic06_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic06_b : TriggerState {
            internal State엔딩Cinematic06_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010040_QD__52010040__6$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State엔딩Cinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic06 : TriggerState {
            internal State엔딩Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔딩Cinematic07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic07 : TriggerState {
            internal State엔딩Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000422, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
