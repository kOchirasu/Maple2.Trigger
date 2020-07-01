namespace Maple2.Trigger._02000292_bf {
    public static class _battle02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 501, arg2: true, arg3: true);
                context.SetLadder(arg1: 502, arg2: true, arg3: true);
                context.SetLadder(arg1: 503, arg2: true, arg3: true);
                context.DestroyMonster(arg1: new[] {1006, 1007, 1008, 1009, 1010, 2006, 2007, 2008, 2009, 2010});
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001061}, arg2: 0);
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
                context.CreateMonster(arg1: new[] {1006, 1007, 1008, 1009, 1010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {1006, 1007, 1008, 1009, 1010})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.ChangeMonster(arg1: 1006, arg2: 2006);
                context.ChangeMonster(arg1: 1007, arg2: 2007);
                context.ChangeMonster(arg1: 1008, arg2: 2008);
                context.ChangeMonster(arg1: 1009, arg2: 2009);
                context.ChangeMonster(arg1: 1010, arg2: 2010);
                context.SetLadder(arg1: 501, arg2: false, arg3: false);
                context.SetLadder(arg1: 502, arg2: false, arg3: false);
                context.SetLadder(arg1: 503, arg2: false, arg3: false);
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
                context.SetInteractObject(arg1: new[] {10001061}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001061}, arg2: 0)) {
                    return new StateLadderOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn01 : TriggerState {
            internal StateLadderOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 501, arg2: true, arg3: true);
                context.SetLadder(arg1: 502, arg2: true, arg3: true);
                context.SetLadder(arg1: 503, arg2: true, arg3: true);
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