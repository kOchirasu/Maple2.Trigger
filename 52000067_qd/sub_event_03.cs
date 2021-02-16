namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {591, 592}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {537, 538, 539}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 591, arg2: "Emotion_Failure_Idle_A", arg3: 600000f);
                context.SetNpcEmotionLoop(arg1: 592, arg2: "Emotion_Failure_Idle_A", arg3: 600000f);
                context.SetConversation(arg1: 1, arg2: 591, script: "$52000067_QD__SUB_EVENT_03__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 592, script: "$52000067_QD__SUB_EVENT_03__1$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {537, 538, 539})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 591, arg2: "Talk_A");
                context.SetNpcEmotionSequence(arg1: 592, arg2: "Idle_A");
                context.SetConversation(arg1: 1, arg2: 591, script: "$52000067_QD__SUB_EVENT_03__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 591, arg2: "MS2PatrolData_5010");
                context.MoveNpc(arg1: 592, arg2: "MS2PatrolData_5010");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}