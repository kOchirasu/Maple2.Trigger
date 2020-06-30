using System;

namespace Maple2.Trigger._02020141_bf {
    public static class _interactmesh10014101 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State최초시작(context);

        private class State최초시작 : TriggerState {
            internal State최초시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003149}, arg2: 2);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State탈것_등장대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈것_등장대기 : TriggerState {
            internal State탈것_등장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State탈것_등장연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈것_등장연출 : TriggerState {
            internal State탈것_등장연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {914101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State탈것_등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈것_등장 : TriggerState {
            internal State탈것_등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003149}, arg2: 1);
                context.DestroyMonster(arg1: new int[] {914101});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003149}, arg2: 0)) {
                    context.State = new State인터렉트_동작중(context);
                    return;
                }

                if (context.UserValue(key: "RidingBattle", value: -1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작중 : TriggerState {
            internal State인터렉트_동작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003149}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 40000)) {
                    context.State = new State탈것_등장대기(context);
                    return;
                }

                if (context.UserValue(key: "RidingBattle", value: -1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003149}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}