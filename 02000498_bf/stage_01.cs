using System.Numerics;

namespace Maple2.Trigger._02000498_bf {
    public static class _stage_01 {
        public class StateStartCinematic_6 : TriggerState {
            internal StateStartCinematic_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    return new StateFadeOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut : TriggerState {
            internal StateFadeOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadeOut_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_2 : TriggerState {
            internal StateFadeOut_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "곧 새로운 차원으로 당신을 안내 합니다.", duration: 3000);
                context.SetEffect(triggerIds: new []{500, 501}, visible: true);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBeginWait_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait_1 : TriggerState {
            internal StateBeginWait_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserToPos(position: new Vector3(433f, -6777f, 8701f));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadeIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn : TriggerState {
            internal StateFadeIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ChangeBackground(dds: "BG_Lith_C.dds");
                context.SetAmbientLight(color: new Vector3(199f, 207f, 214f));
                context.SetDirectionalLight(diffuseColor: new Vector3(255f, 255f, 255f), specularColor: new Vector3(255f, 255f, 255f));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{100010}, skillId: 70000103, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    // return new State안내02(context);
                    return null;
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
    }
}
