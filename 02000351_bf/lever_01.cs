namespace Maple2.Trigger._02000351_bf {
    public static class _lever_01 {
        public class State닫힘상태 : TriggerState {
            internal State닫힘상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001, 6002}, arg2: true, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025, 6026}, arg2: false, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000818}, arg2: 1)) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 111, textId: 20000080);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000818}, arg2: 0)) {
                    return new StateOpen(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
            }
        }

        private class StateOpen : TriggerState {
            internal StateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetMesh(arg1: new[] {6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025, 6026}, arg2: true, arg4: 200, arg5: 15f);
                context.SetEffect(arg1: new[] {9000002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001, 6002}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State열림_끝(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}