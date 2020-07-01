namespace Maple2.Trigger._02000066_bf {
    public static class _npc08 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.SetActor(arg1: 208, arg2: false, arg3: "Dead_A");
                context.SetInteractObject(arg1: new[] {10000376}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateNPC생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC생성 : TriggerState {
            internal StateNPC생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new[] {2008}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000376}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC생성조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC생성조건 : TriggerState {
            internal StateNPC생성조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2008})) {
                    context.SetEffect(arg1: new[] {605}, arg2: true);
                    context.ShowGuideSummary(entityId: 20000663, textId: 20000663);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    return new StateNPC소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.DestroyMonster(arg1: new[] {2008});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20000663);
                    return new State오브젝트반응(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 208, arg2: true, arg3: "Dead_A");
                context.SetInteractObject(arg1: new[] {10000376}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000376}, arg2: 0)) {
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
                context.CreateMonster(arg1: new[] {2008}, arg2: false);
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
                context.SetActor(arg1: 208, arg2: false, arg3: "Dead_A");
                context.SetConversation(arg1: 1, arg2: 2008, arg3: "$02000066_BF__NPC08__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2008})) {
                    return new StateNPC생성조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}