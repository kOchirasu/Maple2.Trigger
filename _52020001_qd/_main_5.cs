namespace Maple2.Trigger._52020001_qd {
    public static class _main_5 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {4})) {
                    context.State = new State기다림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기다림 : TriggerState {
            internal State기다림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "OpenBossGauge", maxGaugePoint: 300, title: "출력 에너지");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State체력조건_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체력조건_1 : TriggerState {
            internal State체력조건_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetShadowExpeditionPoints() >= 150) {
                    context.State = new State알림_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림_1 : TriggerState {
            internal State알림_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "에너지가 50%충전 되었습니다.", arg3: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State체력조건_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {6000041, 6000042}, arg2: false);
                context.AddBuff(arg1: new[] {6000041}, arg2: 49286001, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {6000042}, arg2: 49286001, arg3: 1, arg4: true);
            }
        }

        private class State체력조건_2 : TriggerState {
            internal State체력조건_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetShadowExpeditionPoints() >= 300) {
                    context.State = new State알림_5(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg2: "trigger", arg3: "EscapeToKritias");
            }
        }

        private class State알림_5 : TriggerState {
            internal State알림_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "에너지가 100%충전 되었습니다.", arg3: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State알림_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림_6 : TriggerState {
            internal State알림_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "곧 최대 출력으로 돌진 합니다.", arg3: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마지막_연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출 : TriggerState {
            internal State마지막_연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {2000009}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State캐릭터숨기기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State캐릭터숨기기 : TriggerState {
            internal State캐릭터숨기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {7002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마지막_연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출_2 : TriggerState {
            internal State마지막_연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateAI연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAI연출 : TriggerState {
            internal StateAI연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.CameraSelectPath(arg1: new[] {2000013}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateAI연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAI연출_2 : TriggerState {
            internal StateAI연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 0, arg3: "준비완료! 크리티아스로 돌진!", arg4: 3, arg5: 0);
                context.SetAiExtraData(key: "wing", value: 1, boxId: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "wing", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State끝_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝_2 : TriggerState {
            internal State끝_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020001, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}