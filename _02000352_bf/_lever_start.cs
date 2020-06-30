using System;

namespace Maple2.Trigger._02000352_bf {
    public static class _lever_start {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State작동(context);

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6201}, arg2: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000821}, arg2: 1);
                context.SetMesh(
                    arg1: new int[]
                        {6150, 6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163},
                    arg2: true, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {6150, 6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163},
                    arg2: false, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000821}, arg2: 0)) {
                    context.State = new State열림상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열림상태 : TriggerState {
            internal State열림상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new int[] {9000001}, arg2: true);
                context.SetMesh(arg1: new int[] {6211}, arg2: false, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new int[] {6201}, arg2: true, arg4: 200, arg5: 15f);
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
                context.SetMesh(arg1: new int[] {6001}, arg2: false, arg4: 0, arg5: 10f);
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

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}