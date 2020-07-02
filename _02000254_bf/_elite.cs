namespace Maple2.Trigger._02000254_bf {
    public static class _elite {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 801, arg2: false, arg3: false);
                context.SetLadder(arg1: 802, arg2: false, arg3: false);
                context.SetLadder(arg1: 803, arg2: false, arg3: false);
                context.SetLadder(arg1: 804, arg2: false, arg3: false);
                context.SetLadder(arg1: 805, arg2: false, arg3: false);
                context.SetLadder(arg1: 806, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {903})) {
                    return new StateDelay1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay1 : TriggerState {
            internal StateDelay1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State2탄(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    return new StateClearDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State3탄(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    return new StateClearDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State4탄(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    return new StateClearDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State5탄(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    return new StateClearDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State2탄(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    return new StateClearDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearDelay : TriggerState {
            internal StateClearDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                return new StateClear2(context);
            }

            public override void OnExit() { }
        }

        private class StateClear2 : TriggerState {
            internal StateClear2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__ELITE__0$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateClear3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear3 : TriggerState {
            internal StateClear3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.DestroyMonster(arg1: new[] {103, 104, 105});
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateLadderCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation : TriggerState {
            internal StateLadderCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}