using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020030_qd {
    public static class _main30000332 {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{30000332}, questStates: new byte[]{1})) {
                    return new State천공의탑전경보여주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기 : TriggerState {
            internal State천공의탑전경보여주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State천공의탑전경보여주기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기02 : TriggerState {
            internal State천공의탑전경보여주기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4008, 4010}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "천공의 탑", script: "크리티아스 마법 연구소", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State천공의탑전경보여주기03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기03 : TriggerState {
            internal State천공의탑전경보여주기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52020030, portalId: 6006);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State천공의탑전경보여주기04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State천공의탑전경보여주기04 : TriggerState {
            internal State천공의탑전경보여주기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
