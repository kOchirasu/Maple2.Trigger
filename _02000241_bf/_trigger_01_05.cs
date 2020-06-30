using System;

namespace Maple2.Trigger._02000241_bf {
    public static class _trigger_01_05 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {304}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {701, 702}, arg2: true);
                context.SetActor(arg1: 501, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 502, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 503, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 504, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 505, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 506, arg2: true, arg3: "Closed");
                context.DestroyMonster(arg1: new int[] {601, 602, 603, 604, 605, 606});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "404")) {
                    context.State = new State버튼눌림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {304}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 505, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 506, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new int[] {605, 606}, arg2: false);
                context.MoveNpc(arg1: 605, arg2: "MS2PatrolData_605");
                context.MoveNpc(arg1: 606, arg2: "MS2PatrolData_606");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}