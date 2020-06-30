using System;

namespace Maple2.Trigger._99999876 {
    public static class _17000_minipuzzle_chatchupnpc {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ChangeNpc", value: 0);
                context.DestroyMonster(arg1: new int[] {17101, 17102});
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateSettingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSettingDelay : TriggerState {
            internal StateSettingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {17101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "ChangeNpc", value: 1)) {
                    context.State = new StateChatchUpNpc(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChatchUpNpc : TriggerState {
            internal StateChatchUpNpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false, arg5: 0);
                context.ChangeMonster(arg1: 17101, arg2: 17102);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateChatchUpNpc_Quit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChatchUpNpc_Quit : TriggerState {
            internal StateChatchUpNpc_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.DestroyMonster(arg1: new int[] {17101, 17102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}