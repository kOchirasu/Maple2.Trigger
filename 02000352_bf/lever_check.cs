namespace Maple2.Trigger._02000352_bf {
    public static class _lever_check {
        public class StateLeverCheck : TriggerState {
            internal StateLeverCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000823, 10000824}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000823}, arg2: 1)) {
                    return new StateLeverCheck2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000824}, arg2: 1)) {
                    return new StateLeverCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck2 : TriggerState {
            internal StateLeverCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000823}, arg2: 0)) {
                    return new StateLeverCheck3_1개(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000824}, arg2: 0)) {
                    return new StateLeverCheck4_1개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck3_1개 : TriggerState {
            internal StateLeverCheck3_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000824}, arg2: 0)) {
                    return new StateLeverCheck완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck4_1개 : TriggerState {
            internal StateLeverCheck4_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000823}, arg2: 0)) {
                    return new StateLeverCheck완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck완료 : TriggerState {
            internal StateLeverCheck완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
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
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetMesh(arg1: new[] {6054, 6055, 6056}, arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new[] {6154, 6155, 6156}, arg2: true, arg4: 200, arg5: 0f);
                context.SetEffect(arg1: new[] {9000005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State열림_끝(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {6003}, arg2: false, arg4: 0, arg5: 10f);
            }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 40011);
                context.CameraSelect(arg1: 8002, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}