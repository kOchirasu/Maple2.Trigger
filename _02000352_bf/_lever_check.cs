using System;

namespace Maple2.Trigger._02000352_bf {
    public static class _lever_check {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레버체크(context);

        private class State레버체크 : TriggerState {
            internal State레버체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000823}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000824}, arg2: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000823}, arg2: 1)) {
                    context.State = new State레버체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000824}, arg2: 1)) {
                    context.State = new State레버체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버체크2 : TriggerState {
            internal State레버체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000823}, arg2: 0)) {
                    context.State = new State레버체크3_1개(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000824}, arg2: 0)) {
                    context.State = new State레버체크4_1개(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버체크3_1개 : TriggerState {
            internal State레버체크3_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000824}, arg2: 0)) {
                    context.State = new State레버체크완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버체크4_1개 : TriggerState {
            internal State레버체크4_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000823}, arg2: 0)) {
                    context.State = new State레버체크완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버체크완료 : TriggerState {
            internal State레버체크완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetMesh(arg1: new int[] {6054, 6055, 6056}, arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new int[] {6154, 6155, 6156}, arg2: true, arg4: 200, arg5: 0f);
                context.SetEffect(arg1: new int[] {9000005}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State열림_끝(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new int[] {6003}, arg2: false, arg4: 0, arg5: 10f);
            }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 113, textID: 40011);
                context.CameraSelect(arg1: 8002, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 113);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}