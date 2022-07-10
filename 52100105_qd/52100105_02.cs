namespace Maple2.Trigger._52100105_qd {
    public static class _52100105_02 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{50101030}, questStates: new byte[]{3})) {
                    return new StateWait_03(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{50101020}, questStates: new byte[]{2})) {
                    return new StateWait_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_03 : TriggerState {
            internal StateWait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCinematic보러(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic보러 : TriggerState {
            internal StateCinematic보러(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52100105, portalId: 4);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
