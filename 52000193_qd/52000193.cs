using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000193_qd {
    public static class _52000193 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateCameraEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202});
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_01 : TriggerState {
            internal StateCameraEffect02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003406}, questStates: new byte[]{2})) {
                    return new StateCameraEffect02_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003407}, questStates: new byte[]{3})) {
                    return new State이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003407}, questStates: new byte[]{2})) {
                    return new State변신_02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003407}, questStates: new byte[]{2})) {
                    return new State변신_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_02 : TriggerState {
            internal StateCameraEffect02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000193_QD__52000193__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000193_QD__52000193__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraEffect03_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_4 : TriggerState {
            internal StateCameraEffect03_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State변신_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State변신_01 : TriggerState {
            internal State변신_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{201});
                context.VisibleMyPc(visible: true);
                context.SetVisibleUI(uiNames: new []{"MessengerBrowser", "GroupMessengerBrowser", "HighlightGameMenu"}, visible: false);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910402, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910402, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraEffect03_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State변신_02 : TriggerState {
            internal State변신_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000193, portalId: 5002);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{201});
                context.VisibleMyPc(visible: true);
                context.SetVisibleUI(uiNames: new []{"MessengerBrowser", "GroupMessengerBrowser", "HighlightGameMenu"}, visible: false);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910402, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{2001}, skillId: 99910402, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraEffect03_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_6 : TriggerState {
            internal StateCameraEffect03_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03_8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_8 : TriggerState {
            internal StateCameraEffect03_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003407}, questStates: new byte[]{3})) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000065, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
