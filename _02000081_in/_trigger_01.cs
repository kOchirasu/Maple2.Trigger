namespace Maple2.Trigger._02000081_in {
    public static class _trigger_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000384}, arg2: 1);
                context.DestroyMonster(arg1: new[] {201});
                context.SetMesh(arg1: new[] {101, 102, 103, 104}, arg2: false);
                context.SetActor(arg1: 501, arg2: true, arg3: "Opened");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000384}, arg2: 0)) {
                    return new State닫히기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닫히기 : TriggerState {
            internal State닫히기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102, 103, 104}, arg2: true);
                context.SetActor(arg1: 501, arg2: true, arg3: "Closed");
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State토무Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무Appear : TriggerState {
            internal State토무Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 402, arg2: new[] {202})) {
                    return new State토무대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무대사 : TriggerState {
            internal State토무대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000081_IN__TRIGGER_01__0$", arg4: 4);
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State토무대사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무대사2 : TriggerState {
            internal State토무대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000081_IN__TRIGGER_01__1$", arg4: 4);
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State토무대사3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무대사3 : TriggerState {
            internal State토무대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000081_IN__TRIGGER_01__2$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State변신(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State변신 : TriggerState {
            internal State변신(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.SetActor(arg1: 501, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {101, 102, 103, 104}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateMonsterCombat(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterCombat : TriggerState {
            internal StateMonsterCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    return new StateWait(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {201})) {
                    return new State토무소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토무소멸 : TriggerState {
            internal State토무소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {201})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new[] {201})) {
                    return new StateWait(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDestroy : TriggerState {
            internal StateWaitDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateTriggerReset(context);
                }

                if (context.MonsterInCombat(arg1: new[] {201})) {
                    return new State토무소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {201})) {
                    return new State토무소멸(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {201})) {
                    context.DestroyMonster(arg1: new[] {201});
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}