namespace Maple2.Trigger._61000022_me {
    public static class _sensor_9230 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box23Check", value: 10);
                context.SetMesh(arg1: new[] {523}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {5230}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Box23Check") == 0) {
                    context.State = new StateSensor0(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 1) {
                    context.State = new StateSensor1(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 2) {
                    context.State = new StateSensor2(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 3) {
                    context.State = new StateSensor3(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 4) {
                    context.State = new StateSensor4(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 5) {
                    context.State = new StateSensor5(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 7) {
                    context.State = new StateSensor7(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 8) {
                    context.State = new StateSensor8(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 9) {
                    context.State = new StateSensor9(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 6) {
                    context.State = new StateSensor10(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 15) {
                    context.State = new StateSensor15(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 20) {
                    context.State = new StateSensor20(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 25) {
                    context.State = new StateSensor25(context);
                    return;
                }

                if (context.GetUserValue(key: "Box23Check") == 30) {
                    context.State = new StateSensor30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor0 : TriggerState {
            internal StateSensor0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor1 : TriggerState {
            internal StateSensor1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 1) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 1) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor2 : TriggerState {
            internal StateSensor2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 2) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 2) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor3 : TriggerState {
            internal StateSensor3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 3) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 3) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor4 : TriggerState {
            internal StateSensor4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 4) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 4) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor5 : TriggerState {
            internal StateSensor5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 5) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 5) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7 : TriggerState {
            internal StateSensor7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 7) {
                    context.State = new StateGamblePass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 7) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor8 : TriggerState {
            internal StateSensor8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 8) {
                    context.State = new StateGamblePass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 8) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor9 : TriggerState {
            internal StateSensor9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 9) {
                    context.State = new StateGamblePass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 9) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor10 : TriggerState {
            internal StateSensor10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 10) {
                    context.State = new StateGamblePass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 10) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor15 : TriggerState {
            internal StateSensor15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 15) {
                    context.State = new StateJackpotPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 15) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor20 : TriggerState {
            internal StateSensor20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 20) {
                    context.State = new StateJackpotPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 20) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor25 : TriggerState {
            internal StateSensor25(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 25) {
                    context.State = new StateJackpotPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 25) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor30 : TriggerState {
            internal StateSensor30(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 30) {
                    context.State = new StateJackpotPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 30) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalPass : TriggerState {
            internal StateNormalPass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 0);
                context.SetMesh(arg1: new[] {523}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGamblePass : TriggerState {
            internal StateGamblePass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 0);
                context.SetUserValue(triggerId: 3, key: "GamblePass", value: 23);
                context.SetMesh(arg1: new[] {523}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.WriteLog(arg1: "dancedancestop", arg2: 9230, arg3: "char_event", arg4: 4, arg5: "gamble");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGambleReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJackpotPass : TriggerState {
            internal StateJackpotPass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 0);
                context.SetUserValue(triggerId: 3, key: "JackpotPass", value: 23);
                context.SetMesh(arg1: new[] {523}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.WriteLog(arg1: "dancedancestop", arg2: 9230, arg3: "char_event", arg4: 4, arg5: "jackpot");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateJackpotReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Fail_01");
                context.SetMesh(arg1: new[] {523}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {5230}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleReset : TriggerState {
            internal StateGambleReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9230, arg2: "trigger", arg3: "ddstop_gamble");
                context.MiniGameGiveExp(boxId: 9230, expRate: 0.1f, isOutSide: "false");
                context.SetUserValue(key: "Box23Check", value: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJackpotReset : TriggerState {
            internal StateJackpotReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9230, arg2: "trigger", arg3: "ddstop_gamble");
                context.MiniGameGiveExp(boxId: 9230, expRate: 0.3f, isOutSide: "false");
                context.SetUserValue(key: "Box23Check", value: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box23Check", value: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}