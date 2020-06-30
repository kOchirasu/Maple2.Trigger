using System;

namespace Maple2.Trigger._99999840 {
    public static class _invasion_portal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990010, key: "PCmove", value: 0);
                context.SetInteractObject(arg1: new int[] {10002183}, arg2: 2, arg3: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State포탈열림 : TriggerState {
            internal State포탈열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true);
                context.SetInteractObject(arg1: new int[] {10002183}, arg2: 1, arg3: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.ResetTimer(arg1: "1");
                    context.State = new State포탈닫힘(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002183}, arg2: 2)) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990010, key: "PCmove", value: 1);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.DungeonVariable(varID: 2000, value: true)) {
                    context.State = new State포탈열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈닫힘 : TriggerState {
            internal State포탈닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990010, key: "PCmove", value: 0);
                context.SetTimer(arg1: "2", arg2: 60, arg3: true);
                context.SetInteractObject(arg1: new int[] {10002183}, arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.DungeonVariable(varID: 3, value: true)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.ResetTimer(arg1: "2");
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002183}, arg2: 2, arg3: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}