namespace Maple2.Trigger._99999876 {
    public static class _17000_minipuzzle_chatchupnpc {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ChangeNpc", value: 0);
                context.DestroyMonster(spawnIds: new []{17101, 17102});
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateSettingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSettingDelay : TriggerState {
            internal StateSettingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{17101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ChangeNpc") == 1) {
                    return new StateChatchUpNpc(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChatchUpNpc : TriggerState {
            internal StateChatchUpNpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: true, display: false, vOffset: 0);
                context.ChangeMonster(removeSpawnId: 17101, addSpawnId: 17102);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateChatchUpNpc_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChatchUpNpc_Quit : TriggerState {
            internal StateChatchUpNpc_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.DestroyMonster(spawnIds: new []{17101, 17102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
