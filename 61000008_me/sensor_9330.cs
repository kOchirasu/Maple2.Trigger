namespace Maple2.Trigger._61000008_me {
    public static class _sensor_9330 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box33Check", value: 10);
                context.SetMesh(arg1: new[] {533, 5330}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Box33Check") == 0) {
                    return new StateSensor0(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 1) {
                    return new StateSensor1(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 2) {
                    return new StateSensor2(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 3) {
                    return new StateSensor3(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 4) {
                    return new StateSensor4(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 5) {
                    return new StateSensor5(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 7) {
                    return new StateSensor7(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 8) {
                    return new StateSensor8(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 9) {
                    return new StateSensor9(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 6) {
                    return new StateSensor10(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 15) {
                    return new StateSensor15(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 20) {
                    return new StateSensor20(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 25) {
                    return new StateSensor25(context);
                }

                if (context.GetUserValue(key: "Box33Check") == 30) {
                    return new StateSensor30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor0 : TriggerState {
            internal StateSensor0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateFail(context);
            }

            public override void OnExit() { }
        }

        private class StateSensor1 : TriggerState {
            internal StateSensor1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 1) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 1) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor2 : TriggerState {
            internal StateSensor2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 2) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor3 : TriggerState {
            internal StateSensor3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 3) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor4 : TriggerState {
            internal StateSensor4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 4) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor5 : TriggerState {
            internal StateSensor5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 5) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7 : TriggerState {
            internal StateSensor7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 7) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 7) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor8 : TriggerState {
            internal StateSensor8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 8) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 8) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor9 : TriggerState {
            internal StateSensor9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 9) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 9) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor10 : TriggerState {
            internal StateSensor10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 10) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 10) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor15 : TriggerState {
            internal StateSensor15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 15) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 15) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor20 : TriggerState {
            internal StateSensor20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 20) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 20) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor25 : TriggerState {
            internal StateSensor25(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 25) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 25) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor30 : TriggerState {
            internal StateSensor30(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 30) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9330) != 30) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalPass : TriggerState {
            internal StateNormalPass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 0);
                context.SetMesh(arg1: new[] {533}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGamblePass : TriggerState {
            internal StateGamblePass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 0);
                context.SetUserValue(triggerId: 3, key: "GamblePass", value: 33);
                context.SetMesh(arg1: new[] {533}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.WriteLog(arg1: "dancedancestop", arg2: 9330, arg3: "char_event", arg4: 4, arg5: "gamble");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGambleReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJackpotPass : TriggerState {
            internal StateJackpotPass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 0);
                context.SetUserValue(triggerId: 3, key: "JackpotPass", value: 33);
                context.SetMesh(arg1: new[] {533}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.WriteLog(arg1: "dancedancestop", arg2: 9330, arg3: "char_event", arg4: 4, arg5: "jackpot");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateJackpotReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Fail_01");
                context.SetMesh(arg1: new[] {533}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {5330}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleReset : TriggerState {
            internal StateGambleReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9330, arg2: "trigger", arg3: "ddstop_gamble");
                context.MiniGameGiveExp(boxId: 9330, expRate: 0.1f, isOutSide: "false");
                context.SetUserValue(key: "Box33Check", value: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJackpotReset : TriggerState {
            internal StateJackpotReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9330, arg2: "trigger", arg3: "ddstop_gamble");
                context.MiniGameGiveExp(boxId: 9330, expRate: 0.3f, isOutSide: "false");
                context.SetUserValue(key: "Box33Check", value: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box33Check", value: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}