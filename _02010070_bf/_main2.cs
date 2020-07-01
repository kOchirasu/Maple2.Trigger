namespace Maple2.Trigger._02010070_bf {
    public static class _main2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108});
                context.SetInteractObject(arg1: new[] {10000834}, arg2: 1);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {95001}, arg2: false);
                context.DestroyMonster(arg1: new[] {22210, 22211, 22212, 22213});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999993})) {
                    context.State = new State대기시간안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간안내01 : TriggerState {
            internal State대기시간안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 22210, 22211, 22212, 22213}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기시간02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간02 : TriggerState {
            internal State대기시간02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02010070_BF__MAIN__4$", arg3: 5000, arg4: "0");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999983})) {
                    context.State = new State시작1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작1 : TriggerState {
            internal State시작1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100706, textId: 20100706, duration: 7000);
                context.MoveNpc(arg1: 2108, arg2: "MS2PatrolData0");
                context.SetConversation(arg1: 1, arg2: 2108, arg3: "$02010070_BF__MAIN__1$", arg4: 4);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {88123})) {
                    context.State = new State시작112(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작112 : TriggerState {
            internal State시작112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2108, arg3: "$02010070_BF__MAIN__2$", arg4: 4);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100707, textId: 20100707);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000834}, arg2: 0)) {
                    context.State = new State시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작2 : TriggerState {
            internal State시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {95001}, arg2: true);
                context.HideGuideSummary(entityId: 20100707);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100708, textId: 20100708);
                context.DestroyMonster(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108});
                context.CreateMonster(arg1: new[] {2000, 2001, 2002, 2003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State시작32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작32 : TriggerState {
            internal State시작32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2004, 2005}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005})) {
                    context.State = new State시작3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작3 : TriggerState {
            internal State시작3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20100708);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100709, textId: 20100709);
                context.CreateMonster(arg1: new[] {2006, 2007, 2008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2006, 2007, 2008})) {
                    context.State = new State시간1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시간1 : TriggerState {
            internal State시간1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20100709);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작5 : TriggerState {
            internal State시작5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {70002, 70003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(arg1: new[] {70001}, arg2: true);
                    context.SetSkill(arg1: new[] {70004}, arg2: true);
                    context.State = new State시작6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작6 : TriggerState {
            internal State시작6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 6);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(arg1: 02010070, arg2: 9);
                    context.State = new State시작7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작7 : TriggerState {
            internal State시작7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작8 : TriggerState {
            internal State시작8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}