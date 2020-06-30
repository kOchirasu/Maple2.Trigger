using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _02_wait {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 90, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateNotice_90sec_Left(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_90sec_Left : TriggerState {
            internal StateNotice_90sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 26620112, textID: 26620112, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till75sec_01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till75sec_01 : TriggerState {
            internal StateNotice_till75sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620106, textID: 26620106, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till75sec_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till75sec_02 : TriggerState {
            internal StateNotice_till75sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620107, textID: 26620107, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_75sec_Left(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_75sec_Left : TriggerState {
            internal StateNotice_75sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 26620113, textID: 26620113, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till60sec_01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till60sec_01 : TriggerState {
            internal StateNotice_till60sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620106, textID: 26620106, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till60sec_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till60sec_02 : TriggerState {
            internal StateNotice_till60sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620107, textID: 26620107, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_60sec_Left(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_60sec_Left : TriggerState {
            internal StateNotice_60sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 26620108, textID: 26620108, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till45sec_01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till45sec_01 : TriggerState {
            internal StateNotice_till45sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620106, textID: 26620106, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till45sec_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till45sec_02 : TriggerState {
            internal StateNotice_till45sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620107, textID: 26620107, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_45sec_Left(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_45sec_Left : TriggerState {
            internal StateNotice_45sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 26620109, textID: 26620109, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till30sec_01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till30sec_01 : TriggerState {
            internal StateNotice_till30sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620106, textID: 26620106, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till30sec_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till30sec_02 : TriggerState {
            internal StateNotice_till30sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620107, textID: 26620107, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_30sec_Left(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_30sec_Left : TriggerState {
            internal StateNotice_30sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 26620110, textID: 26620110, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till15sec_01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till15sec_01 : TriggerState {
            internal StateNotice_till15sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620106, textID: 26620106, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till15sec_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till15sec_02 : TriggerState {
            internal StateNotice_till15sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620107, textID: 26620107, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_15sec_Left(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_15sec_Left : TriggerState {
            internal StateNotice_15sec_Left(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 26620111, textID: 26620111, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till0sec_01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till0sec_01 : TriggerState {
            internal StateNotice_till0sec_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620106, textID: 26620106, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNotice_till0sec_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice_till0sec_02 : TriggerState {
            internal StateNotice_till0sec_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26620107, textID: 26620107, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "BattleField_Event");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}