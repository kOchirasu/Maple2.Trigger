namespace Maple2.Trigger._02000399_bf {
    public static class _02_tireziptrack {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {100});
                context.SetUserValue(key: "TireSpawn", value: 0);
                context.SetInteractObject(arg1: new[] {10001149}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "TireSpawn") == 1) {
                    context.State = new StateGuideInteract(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideInteract : TriggerState {
            internal StateGuideInteract(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039903, textId: 20039903);
                context.SetInteractObject(arg1: new[] {10001149}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001149}, arg2: 0)) {
                    context.State = new StateTireSpawn(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20039903);
            }
        }

        private class StateTireSpawn : TriggerState {
            internal StateTireSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039904, textId: 20039904, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateGuideTireHold(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTireHold : TriggerState {
            internal StateGuideTireHold(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039905, textId: 20039905, duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTireMove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTireMove : TriggerState {
            internal StateTireMove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_100");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateTireRemove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTireRemove01 : TriggerState {
            internal StateTireRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {100});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTireResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTireResetDelay : TriggerState {
            internal StateTireResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTireReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTireReset : TriggerState {
            internal StateTireReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001149}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001149}, arg2: 0)) {
                    context.State = new StateTireSpawnAgain(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTireSpawnAgain : TriggerState {
            internal StateTireSpawnAgain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTireMoveAgain(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTireMoveAgain : TriggerState {
            internal StateTireMoveAgain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_100");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateTireRemove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}