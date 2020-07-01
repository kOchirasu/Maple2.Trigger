namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_05 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 707, arg2: new[] {751})) {
                    context.State = new StateNPC소멸751(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {752})) {
                    context.State = new StateNPC소멸752(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {753})) {
                    context.State = new StateNPC소멸753(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {754})) {
                    context.State = new StateNPC소멸754(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {755})) {
                    context.State = new StateNPC소멸755(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {756})) {
                    context.State = new StateNPC소멸756(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {757})) {
                    context.State = new StateNPC소멸757(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {758})) {
                    context.State = new StateNPC소멸758(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {759})) {
                    context.State = new StateNPC소멸759(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {761})) {
                    context.State = new StateNPC소멸761(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {762})) {
                    context.State = new StateNPC소멸762(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {591})) {
                    context.State = new StateNPC소멸591(context);
                    return;
                }

                if (context.NpcDetected(arg1: 707, arg2: new[] {592})) {
                    context.State = new StateNPC소멸592(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸751 : TriggerState {
            internal StateNPC소멸751(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {751});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸752 : TriggerState {
            internal StateNPC소멸752(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {752});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸753 : TriggerState {
            internal StateNPC소멸753(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {753});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸754 : TriggerState {
            internal StateNPC소멸754(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {754});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸755 : TriggerState {
            internal StateNPC소멸755(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {755});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸756 : TriggerState {
            internal StateNPC소멸756(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {756});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸757 : TriggerState {
            internal StateNPC소멸757(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {757});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸758 : TriggerState {
            internal StateNPC소멸758(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {758});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸759 : TriggerState {
            internal StateNPC소멸759(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {759});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸761 : TriggerState {
            internal StateNPC소멸761(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {761});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸762 : TriggerState {
            internal StateNPC소멸762(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {762});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸591 : TriggerState {
            internal StateNPC소멸591(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {591});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸592 : TriggerState {
            internal StateNPC소멸592(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {592});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}