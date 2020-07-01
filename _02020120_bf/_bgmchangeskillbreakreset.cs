namespace Maple2.Trigger._02020120_bf {
    public static class _bgmchangeskillbreakreset {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1220, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "SkillBreakStart", value: 0);
                context.SetUserValue(key: "DungeonReset", value: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 299) == 1) {
                    context.State = new State던전시간작동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시간작동대기 : TriggerState {
            internal State던전시간작동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 399) == 1) {
                    context.State = new State스킬브레이크신호대기_BGM교체(context);
                    return;
                }

                if (context.GetUserValue(key: "BgmChangeTriggerCancel") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크신호대기_BGM교체 : TriggerState {
            internal State스킬브레이크신호대기_BGM교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 19600, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakStart") >= 1) {
                    context.State = new State스킬브레이크로직작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크로직작동 : TriggerState {
            internal State스킬브레이크로직작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6201, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State스킬브레이크실패초기화처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크실패초기화처리 : TriggerState {
            internal State스킬브레이크실패초기화처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1220, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State스킬브레이크실패연출출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크실패연출출력 : TriggerState {
            internal State스킬브레이크실패연출출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State보스한테보내는포탈생성 : TriggerState {
            internal State보스한테보내는포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 1220, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "SkillBreakStart", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // context.State = new State스킬브레이크신호대기_시간다시셋팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스한테보내는포탈생성_시간초기화안함01 : TriggerState {
            internal State보스한테보내는포탈생성_시간초기화안함01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State보스한테보내는포탈생성_시간초기화안함02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스한테보내는포탈생성_시간초기화안함02 : TriggerState {
            internal State보스한테보내는포탈생성_시간초기화안함02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 1220, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "SkillBreakStart", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // context.State = new State스킬브레이크신호대기_시간셋팅안함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}