using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000046_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{60100215}, questStates: new byte[]{2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{60100215}, questStates: new byte[]{3})) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.DestroyMonster(spawnIds: new []{1001, 1002, 2002});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera : TriggerState {
            internal StateCamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002, 4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "ChatUp_A");
                context.AddCinematicTalk(npcId: 11003216, script: "$52000046_QD__MAIN__0$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, scale: 2.3f, title: "$52000046_QD__MAIN__1$", script: "$52000046_QD__MAIN__2$", align: Align.Center | Align.Left, offsetRateX: -0.15f, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 2002, 101});
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEmd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEmd : TriggerState {
            internal StateEmd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
