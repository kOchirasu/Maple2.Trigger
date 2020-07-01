namespace Maple2.Trigger._02000292_bf {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.DestroyMonster(arg1: new[] {1002});
                context.DestroyMonster(arg1: new[] {1003});
                context.DestroyMonster(arg1: new[] {1004});
                context.DestroyMonster(arg1: new[] {1005});
                context.DestroyMonster(arg1: new[] {2001});
                context.DestroyMonster(arg1: new[] {2002});
                context.DestroyMonster(arg1: new[] {2003});
                context.DestroyMonster(arg1: new[] {2004});
                context.DestroyMonster(arg1: new[] {2005});
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
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {1001, 1002, 1003, 1004, 1005})) {
                    context.State = new StateMobBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.ChangeMonster(arg1: 1001, arg2: 2001);
                context.ChangeMonster(arg1: 1002, arg2: 2002);
                context.ChangeMonster(arg1: 1003, arg2: 2003);
                context.ChangeMonster(arg1: 1004, arg2: 2004);
                context.ChangeMonster(arg1: 1005, arg2: 2005);
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
                context.ShowGuideSummary(entityId: 20002925, textId: 20002925, duration: 3000);
                context.SetInteractObject(arg1: new[] {10001061}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001061}, arg2: 0)) {
                    context.State = new StateLadderOn01(context);
                    return;
                }
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