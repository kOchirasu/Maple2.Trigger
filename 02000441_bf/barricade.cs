namespace Maple2.Trigger._02000441_bf {
    public static class _barricade {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{80000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateCheckUser04_GuildRaid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckUser04_GuildRaid : TriggerState {
            internal StateCheckUser04_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, clearAtZero: true, display: false, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) >= 4) {
                    return new StateMaxCount04_Start(context);
                }

                if (context.GetUserCount(boxId: 701) < 4) {
                    return new StateMaxCount04_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait : TriggerState {
            internal StateMaxCount04_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) >= 4) {
                    return new StateMaxCount04_Start(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMaxCount04_Start(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMaxCount04_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Start : TriggerState {
            internal StateMaxCount04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                return new StateDungeonStart(context);
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 904, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2038801, key: "start", value: 1);
                context.SetEffect(triggerIds: new []{70001, 70002, 70003}, visible: false);
                context.SetMesh(triggerIds: new []{80000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706})) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000441_BF__BARRICADE__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateBlock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock : TriggerState {
            internal StateBlock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{80000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{70001, 70002, 70003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
