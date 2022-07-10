namespace Maple2.Trigger._52000067_qd {
    public static class _sub_event_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 707, spawnIds: new []{751})) {
                    return new StateNPCDestroy751(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{752})) {
                    return new StateNPCDestroy752(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{753})) {
                    return new StateNPCDestroy753(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{754})) {
                    return new StateNPCDestroy754(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{755})) {
                    return new StateNPCDestroy755(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{756})) {
                    return new StateNPCDestroy756(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{757})) {
                    return new StateNPCDestroy757(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{758})) {
                    return new StateNPCDestroy758(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{759})) {
                    return new StateNPCDestroy759(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{761})) {
                    return new StateNPCDestroy761(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{762})) {
                    return new StateNPCDestroy762(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{591})) {
                    return new StateNPCDestroy591(context);
                }

                if (context.NpcDetected(boxId: 707, spawnIds: new []{592})) {
                    return new StateNPCDestroy592(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy751 : TriggerState {
            internal StateNPCDestroy751(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{751});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy752 : TriggerState {
            internal StateNPCDestroy752(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{752});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy753 : TriggerState {
            internal StateNPCDestroy753(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{753});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy754 : TriggerState {
            internal StateNPCDestroy754(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{754});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy755 : TriggerState {
            internal StateNPCDestroy755(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{755});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy756 : TriggerState {
            internal StateNPCDestroy756(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{756});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy757 : TriggerState {
            internal StateNPCDestroy757(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{757});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy758 : TriggerState {
            internal StateNPCDestroy758(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{758});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy759 : TriggerState {
            internal StateNPCDestroy759(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{759});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy761 : TriggerState {
            internal StateNPCDestroy761(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{761});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy762 : TriggerState {
            internal StateNPCDestroy762(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{762});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy591 : TriggerState {
            internal StateNPCDestroy591(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{591});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy592 : TriggerState {
            internal StateNPCDestroy592(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{592});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
