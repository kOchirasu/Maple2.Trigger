namespace Maple2.Trigger._02000331_bf {
    public static class _defence17 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {99993})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new[] {999})) {
                    return new State전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중 : TriggerState {
            internal State전투중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State생존체크01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크01 : TriggerState {
            internal State생존체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 99997, arg2: new[] {601})) {
                    return new State생존체크02(context);
                }

                if (context.MonsterDead(arg1: new[] {601})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크02 : TriggerState {
            internal State생존체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 99997, arg2: new[] {602})) {
                    return new State생존체크03(context);
                }

                if (context.MonsterDead(arg1: new[] {602})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크03 : TriggerState {
            internal State생존체크03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 99997, arg2: new[] {603})) {
                    return new State생존체크04(context);
                }

                if (context.MonsterDead(arg1: new[] {603})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크04 : TriggerState {
            internal State생존체크04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 99997, arg2: new[] {604})) {
                    return new State생존체크05(context);
                }

                if (context.MonsterDead(arg1: new[] {604})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크05 : TriggerState {
            internal State생존체크05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 99997, arg2: new[] {605})) {
                    return new StateAchievement(context);
                }

                if (context.MonsterDead(arg1: new[] {605})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 99996, arg2: "trigger", arg3: "defence_child");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}