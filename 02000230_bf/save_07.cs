namespace Maple2.Trigger._02000230_bf {
    public static class _save_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {700}, arg2: false);
                context.SetActor(arg1: 701, arg2: true, arg3: "Emotion_Failure_Idle_A");
                context.SetActor(arg1: 70701, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 70702, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 70703, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 70704, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 70705, arg2: true, arg3: "Attack_02_A");
            }

            public override TriggerState Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000359}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000359}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 700, arg3: "$02000230_BF__SAVE_07__0$", arg4: 2, arg5: 0);
                context.SetActor(arg1: 70701, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {70711}, arg2: true);
                context.SetActor(arg1: 70702, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {70712}, arg2: true);
                context.SetActor(arg1: 70703, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {70713}, arg2: true);
                context.SetActor(arg1: 70704, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {70714}, arg2: true);
                context.SetActor(arg1: 70705, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {70715}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 70711, arg3: "$02000230_BF__SAVE_07__1$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 70713, arg3: "$02000230_BF__SAVE_07__2$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State도망과공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망과공격 : TriggerState {
            internal State도망과공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {700});
                context.SetActor(arg1: 701, arg2: false, arg3: "Emotion_Failure_Idle_A");
                context.CreateMonster(arg1: new[] {711}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 711, arg3: "$02000230_BF__SAVE_07__3$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 711, arg2: "MS2PatrolData_711_11000687");
                context.SetConversation(arg1: 1, arg2: 711, arg3: "$02000230_BF__SAVE_07__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 90711, arg2: new[] {711})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {711});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {70711, 70712, 70713, 70714, 70715})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {70711, 70712, 70713, 70714, 70715})) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 10);
                context.DestroyMonster(arg1: new[] {70711, 70712, 70713, 70714, 70715});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}