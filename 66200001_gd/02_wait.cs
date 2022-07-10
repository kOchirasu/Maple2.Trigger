namespace Maple2.Trigger._66200001_gd {
    public static class _02_wait {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 90, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateNotice_90sec_Left(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_90sec_Left : TriggerState {
            internal StateNotice_90sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 26620112, textId: 26620112, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till75sec_01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till75sec_01 : TriggerState {
            internal StateNotice_till75sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620106, textId: 26620106, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till75sec_02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till75sec_02 : TriggerState {
            internal StateNotice_till75sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620107, textId: 26620107, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_75sec_Left(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_75sec_Left : TriggerState {
            internal StateNotice_75sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 26620113, textId: 26620113, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till60sec_01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till60sec_01 : TriggerState {
            internal StateNotice_till60sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620106, textId: 26620106, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till60sec_02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till60sec_02 : TriggerState {
            internal StateNotice_till60sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620107, textId: 26620107, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_60sec_Left(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_60sec_Left : TriggerState {
            internal StateNotice_60sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 26620108, textId: 26620108, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till45sec_01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till45sec_01 : TriggerState {
            internal StateNotice_till45sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620106, textId: 26620106, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till45sec_02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till45sec_02 : TriggerState {
            internal StateNotice_till45sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620107, textId: 26620107, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_45sec_Left(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_45sec_Left : TriggerState {
            internal StateNotice_45sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 26620109, textId: 26620109, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till30sec_01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till30sec_01 : TriggerState {
            internal StateNotice_till30sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620106, textId: 26620106, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till30sec_02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till30sec_02 : TriggerState {
            internal StateNotice_till30sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620107, textId: 26620107, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_30sec_Left(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_30sec_Left : TriggerState {
            internal StateNotice_30sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 26620110, textId: 26620110, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till15sec_01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till15sec_01 : TriggerState {
            internal StateNotice_till15sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620106, textId: 26620106, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till15sec_02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till15sec_02 : TriggerState {
            internal StateNotice_till15sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620107, textId: 26620107, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_15sec_Left(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_15sec_Left : TriggerState {
            internal StateNotice_15sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 26620111, textId: 26620111, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till0sec_01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till0sec_01 : TriggerState {
            internal StateNotice_till0sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620106, textId: 26620106, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNotice_till0sec_02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice_till0sec_02 : TriggerState {
            internal StateNotice_till0sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620107, textId: 26620107, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
