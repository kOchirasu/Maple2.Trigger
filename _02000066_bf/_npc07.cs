namespace Maple2.Trigger._02000066_bf {
    public static class _npc07 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.SetActor(arg1: 207, arg2: false, arg3: "Dead_A");
                context.SetInteractObject(arg1: new[] {10000375}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateNPCCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation : TriggerState {
            internal StateNPCCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new[] {2007}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000375}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPCCreation조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation조건 : TriggerState {
            internal StateNPCCreation조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2007})) {
                    context.SetEffect(arg1: new[] {605}, arg2: true);
                    context.ShowGuideSummary(entityId: 20000663, textId: 20000663);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.DestroyMonster(arg1: new[] {2007});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20000663);
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 207, arg2: true, arg3: "Dead_A");
                context.SetInteractObject(arg1: new[] {10000375}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000375}, arg2: 0)) {
                    return new State부활(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부활 : TriggerState {
            internal State부활(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new[] {2007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC대사 : TriggerState {
            internal StateNPC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 207, arg2: false, arg3: "Dead_A");
                context.SetConversation(arg1: 1, arg2: 2007, arg3: "$02000066_BF__NPC07__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2007})) {
                    return new StateNPCCreation조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}