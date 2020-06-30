using System;

namespace Maple2.Trigger._52020010_qd {
    public static class _main_c {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200055},
                    arg3: new byte[] {2})) {
                    context.State = new StateActor_On(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200055},
                    arg3: new byte[] {3})) {
                    context.State = new StateActor_On(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {1})) {
                    context.State = new StateActor_On(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {2})) {
                    context.State = new StateActor_Off(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {3})) {
                    context.State = new StateActor_Off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActor_On : TriggerState {
            internal StateActor_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8001, arg2: true, arg3: "Event_01_A");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {2})) {
                    context.State = new StateActor_Off(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {3})) {
                    context.State = new StateActor_Off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActor_Off : TriggerState {
            internal StateActor_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8001, arg2: true, arg3: "Event_01_A");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {2})) {
                    context.State = new StateActor_Off(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2007}, arg2: new int[] {60200060},
                    arg3: new byte[] {2})) {
                    context.State = new StateActor_Off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}