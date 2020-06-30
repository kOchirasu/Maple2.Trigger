using System;

namespace Maple2.Trigger._02000352_bf {
    public static class _lever_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State닫힘상태(context);

        private class State닫힘상태 : TriggerState {
            internal State닫힘상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6111}, arg2: true, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {6101}, arg2: false, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000822}, arg2: 1)) {
                    context.State = new State작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 111, textID: 20000080);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000822}, arg2: 0)) {
                    context.State = new State열림상태(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 111);
            }
        }

        private class State열림상태 : TriggerState {
            internal State열림상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new int[] {9000002}, arg2: true);
                context.SetMesh(arg1: new int[] {6111}, arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new int[] {6101}, arg2: true, arg4: 200, arg5: 15f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6002}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State열림_끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 113, textID: 40011);
                context.CameraSelect(arg1: 8001, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}