namespace Maple2.Trigger._02000292_bf {
    public static class _battle03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetLadder(arg1: 514, arg2: true, arg3: true);
                context.SetLadder(arg1: 515, arg2: true, arg3: true);
                context.DestroyMonster(arg1: new[] {1011, 1012, 1013, 1014, 2011, 2012, 2013, 2014});
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001062}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateMobSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1011, 1012, 1013, 1014}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {1011, 1012, 1013, 1014})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.ChangeMonster(arg1: 1011, arg2: 2011);
                context.ChangeMonster(arg1: 1012, arg2: 2012);
                context.ChangeMonster(arg1: 1013, arg2: 2013);
                context.ChangeMonster(arg1: 1014, arg2: 2014);
                context.SetLadder(arg1: 511, arg2: false, arg3: false);
                context.SetLadder(arg1: 512, arg2: false, arg3: false);
                context.SetLadder(arg1: 513, arg2: false, arg3: false);
                context.SetLadder(arg1: 514, arg2: false, arg3: false);
                context.SetLadder(arg1: 515, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLadderOff01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOff01 : TriggerState {
            internal StateLadderOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002921, textId: 20002921, duration: 5000);
                context.SetInteractObject(arg1: new[] {10001062}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001062}, arg2: 0)) {
                    return new StateLadderOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn01 : TriggerState {
            internal StateLadderOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetLadder(arg1: 514, arg2: true, arg3: true);
                context.SetLadder(arg1: 515, arg2: true, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}