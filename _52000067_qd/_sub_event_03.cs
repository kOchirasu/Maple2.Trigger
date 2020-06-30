using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {591, 592}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {537, 538, 539}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 591, arg2: "Emotion_Failure_Idle_A", arg3: 600000f);
                context.SetNpcEmotionLoop(arg1: 592, arg2: "Emotion_Failure_Idle_A", arg3: 600000f);
                context.SetConversation(arg1: 1, arg2: 591, arg3: "$52000067_QD__SUB_EVENT_03__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 592, arg3: "$52000067_QD__SUB_EVENT_03__1$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {537, 538, 539})) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 591, arg2: "Talk_A");
                context.SetNpcEmotionSequence(arg1: 592, arg2: "Idle_A");
                context.SetConversation(arg1: 1, arg2: 591, arg3: "$52000067_QD__SUB_EVENT_03__2$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new Stateending(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending : TriggerState {
            internal Stateending(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 591, arg2: "MS2PatrolData_5010");
                context.MoveNpc(arg1: 592, arg2: "MS2PatrolData_5010");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}