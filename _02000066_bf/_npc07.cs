using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _npc07 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetActor(arg1: 207, arg2: false, arg3: "Dead_A");
                context.SetInteractObject(arg1: new int[] {10000375}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {103})) {
                    context.State = new StateNPC생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC생성 : TriggerState {
            internal StateNPC생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new int[] {2007}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000375}, arg2: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC생성조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC생성조건 : TriggerState {
            internal StateNPC생성조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2007})) {
                    context.SetEffect(arg1: new int[] {605}, arg2: true);
                    context.ShowGuideSummary(entityID: 20000663, textID: 20000663);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.DestroyMonster(arg1: new int[] {2007});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityID: 20000663);
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 207, arg2: true, arg3: "Dead_A");
                context.SetInteractObject(arg1: new int[] {10000375}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000375}, arg2: 0)) {
                    context.State = new State부활(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부활 : TriggerState {
            internal State부활(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new int[] {2007}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사 : TriggerState {
            internal StateNPC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 207, arg2: false, arg3: "Dead_A");
                context.SetConversation(arg1: 1, arg2: 2007, arg3: "$02000066_BF__NPC07__1$", arg4: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2007})) {
                    context.State = new StateNPC생성조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}