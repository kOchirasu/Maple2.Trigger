namespace Maple2.Trigger._02000347_bf {
    public static class _mob {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateRandomMonster소환(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomMonster소환 : TriggerState {
            internal StateRandomMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new State1번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State2번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State3번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State4번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State5번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State6번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State7번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State8번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State9번소환(context);
                }

                if (context.RandomCondition(arg1: 10f)) {
                    return new State10번소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번소환 : TriggerState {
            internal State1번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번소환 : TriggerState {
            internal State2번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번소환 : TriggerState {
            internal State3번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번소환 : TriggerState {
            internal State4번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1004});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5번소환 : TriggerState {
            internal State5번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1005});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6번소환 : TriggerState {
            internal State6번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7번소환 : TriggerState {
            internal State7번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1007});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8번소환 : TriggerState {
            internal State8번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1008});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9번소환 : TriggerState {
            internal State9번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1009});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10번소환 : TriggerState {
            internal State10번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1010});
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateRandomMonster소환(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}