namespace Maple2.Trigger._02000230_bf {
    public static class _save_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {400}, arg2: false);
                context.SetActor(arg1: 401, arg2: true, arg3: "Emotion_Failure_Idle_A");
                context.SetActor(arg1: 40401, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 40402, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 40403, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 40404, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 40405, arg2: true, arg3: "Attack_02_A");
            }

            public override TriggerState Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000356}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000356}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 400, script: "$02000230_BF__SAVE_04__0$", arg4: 2, arg5: 0);
                context.SetActor(arg1: 40401, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {40411}, arg2: true);
                context.SetActor(arg1: 40402, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {40412}, arg2: true);
                context.SetActor(arg1: 40403, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {40413}, arg2: true);
                context.SetActor(arg1: 40404, arg2: false, arg3: "Attack_Idle_A");
                context.CreateMonster(arg1: new[] {40414}, arg2: true);
                context.SetActor(arg1: 40405, arg2: false, arg3: "Attack_02_A");
                context.CreateMonster(arg1: new[] {40415}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 40411, script: "$02000230_BF__SAVE_04__1$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 40413, script: "$02000230_BF__SAVE_04__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(arg1: new[] {400});
                context.SetActor(arg1: 401, arg2: false, arg3: "Emotion_Failure_Idle_A");
                context.CreateMonster(arg1: new[] {411}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 411, script: "$02000230_BF__SAVE_04__3$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 411, arg2: "MS2PatrolData_411_11000687");
                context.SetConversation(arg1: 1, arg2: 411, script: "$02000230_BF__SAVE_04__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 90411, arg2: new[] {411})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {411});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {40411, 40412, 40413, 40414, 40415})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {40411, 40412, 40413, 40414, 40415})) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "11", arg2: 10);
                context.DestroyMonster(arg1: new[] {40411, 40412, 40413, 40414, 40415});
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