namespace Maple2.Trigger._02000351_bf {
    public static class _lever_02 {
        public class State닫힘상태 : TriggerState {
            internal State닫힘상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000819}, arg2: 0);
                context.SetMesh(
                    arg1: new[] {6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062},
                    arg2: true, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {6081, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092},
                    arg2: false, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000819}, arg2: 1)) {
                    context.State = new State작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000819}, arg2: 0)) {
                    context.State = new State열림상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림상태 : TriggerState {
            internal State열림상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {9000003}, arg2: true);
                context.SetMesh(
                    arg1: new[] {6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062},
                    arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(
                    arg1: new[] {6081, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092},
                    arg2: true, arg4: 200, arg5: 15f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}