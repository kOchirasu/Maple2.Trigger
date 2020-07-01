namespace Maple2.Trigger._02000254_bf {
    public static class _elite {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 801, arg2: false, arg3: false);
                context.SetLadder(arg1: 802, arg2: false, arg3: false);
                context.SetLadder(arg1: 803, arg2: false, arg3: false);
                context.SetLadder(arg1: 804, arg2: false, arg3: false);
                context.SetLadder(arg1: 805, arg2: false, arg3: false);
                context.SetLadder(arg1: 806, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {903})) {
                    context.State = new State딜레이1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이1 : TriggerState {
            internal State딜레이1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State2탄(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State클리어딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2탄 : TriggerState {
            internal State2탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104});
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State3탄(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State클리어딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3탄 : TriggerState {
            internal State3탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {105});
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State4탄(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State클리어딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4탄 : TriggerState {
            internal State4탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.CreateMonster(arg1: new[] {104});
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State5탄(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State클리어딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5탄 : TriggerState {
            internal State5탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {103});
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State2탄(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State클리어딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어딜레이 : TriggerState {
            internal State클리어딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어 : TriggerState {
            internal State클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State클리어2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어2 : TriggerState {
            internal State클리어2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__ELITE__0$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State클리어3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어3 : TriggerState {
            internal State클리어3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.DestroyMonster(arg1: new[] {103});
                context.DestroyMonster(arg1: new[] {104});
                context.DestroyMonster(arg1: new[] {105});
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State사다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성 : TriggerState {
            internal State사다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 801, arg2: true, arg3: true);
                context.SetLadder(arg1: 802, arg2: true, arg3: true);
                context.SetLadder(arg1: 803, arg2: true, arg3: true);
                context.SetLadder(arg1: 804, arg2: true, arg3: true);
                context.SetLadder(arg1: 805, arg2: true, arg3: true);
                context.SetLadder(arg1: 806, arg2: true, arg3: true);
                context.DungeonClear();
                context.HideGuideSummary(entityId: 20002524);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}