namespace Maple2.Trigger._02000292_bf {
    public static class _battle04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 521, arg2: true, arg3: true);
                context.SetLadder(arg1: 522, arg2: true, arg3: true);
                context.SetLadder(arg1: 523, arg2: true, arg3: true);
                context.SetLadder(arg1: 524, arg2: true, arg3: true);
                context.SetLadder(arg1: 525, arg2: true, arg3: true);
                context.DestroyMonster(arg1: new[] {1015});
                context.DestroyMonster(arg1: new[] {1016});
                context.DestroyMonster(arg1: new[] {1017});
                context.DestroyMonster(arg1: new[] {1018});
                context.DestroyMonster(arg1: new[] {1019});
                context.DestroyMonster(arg1: new[] {2015});
                context.DestroyMonster(arg1: new[] {2016});
                context.DestroyMonster(arg1: new[] {2017});
                context.DestroyMonster(arg1: new[] {2018});
                context.DestroyMonster(arg1: new[] {2019});
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001063}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1015}, arg2: false);
                context.CreateMonster(arg1: new[] {1016}, arg2: false);
                context.CreateMonster(arg1: new[] {1017}, arg2: false);
                context.CreateMonster(arg1: new[] {1018}, arg2: false);
                context.CreateMonster(arg1: new[] {1019}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {1015, 1016, 1017, 1018, 1019})) {
                    context.State = new StateMobBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.ChangeMonster(arg1: 1015, arg2: 2015);
                context.ChangeMonster(arg1: 1016, arg2: 2016);
                context.ChangeMonster(arg1: 1017, arg2: 2017);
                context.ChangeMonster(arg1: 1018, arg2: 2018);
                context.ChangeMonster(arg1: 1019, arg2: 2019);
                context.SetLadder(arg1: 521, arg2: false, arg3: false);
                context.SetLadder(arg1: 522, arg2: false, arg3: false);
                context.SetLadder(arg1: 523, arg2: false, arg3: false);
                context.SetLadder(arg1: 524, arg2: false, arg3: false);
                context.SetLadder(arg1: 525, arg2: false, arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLadderOff01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOff01 : TriggerState {
            internal StateLadderOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002921, textId: 20002921, duration: 5000);
                context.SetInteractObject(arg1: new[] {10001063}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001063}, arg2: 0)) {
                    context.State = new StateLadderOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOn01 : TriggerState {
            internal StateLadderOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 521, arg2: true, arg3: true);
                context.SetLadder(arg1: 522, arg2: true, arg3: true);
                context.SetLadder(arg1: 523, arg2: true, arg3: true);
                context.SetLadder(arg1: 524, arg2: true, arg3: true);
                context.SetLadder(arg1: 525, arg2: true, arg3: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}