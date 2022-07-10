namespace Maple2.Trigger._61000022_me {
    public static class _sensor_9320 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box32Check", value: 10);
                context.SetMesh(triggerIds: new []{532, 5320}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Box32Check") == 0) {
                    return new StateSensor0(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 1) {
                    return new StateSensor1(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 2) {
                    return new StateSensor2(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 3) {
                    return new StateSensor3(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 4) {
                    return new StateSensor4(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 5) {
                    return new StateSensor5(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 7) {
                    return new StateSensor7(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 8) {
                    return new StateSensor8(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 9) {
                    return new StateSensor9(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 6) {
                    return new StateSensor10(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 15) {
                    return new StateSensor15(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 20) {
                    return new StateSensor20(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 25) {
                    return new StateSensor25(context);
                }

                if (context.GetUserValue(key: "Box32Check") == 30) {
                    return new StateSensor30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor0 : TriggerState {
            internal StateSensor0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateFail(context);
            }

            public override void OnExit() { }
        }

        private class StateSensor1 : TriggerState {
            internal StateSensor1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 1) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 1) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor2 : TriggerState {
            internal StateSensor2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 2) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor3 : TriggerState {
            internal StateSensor3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 3) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor4 : TriggerState {
            internal StateSensor4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 4) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor5 : TriggerState {
            internal StateSensor5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 5) {
                    return new StateNormalPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7 : TriggerState {
            internal StateSensor7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 7) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 7) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor8 : TriggerState {
            internal StateSensor8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 8) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 8) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor9 : TriggerState {
            internal StateSensor9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 9) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 9) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor10 : TriggerState {
            internal StateSensor10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 10) {
                    return new StateGamblePass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 10) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor15 : TriggerState {
            internal StateSensor15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 15) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 15) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor20 : TriggerState {
            internal StateSensor20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 20) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 20) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor25 : TriggerState {
            internal StateSensor25(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 25) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 25) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor30 : TriggerState {
            internal StateSensor30(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9320) == 30) {
                    return new StateJackpotPass(context);
                }

                if (context.GetUserCount(boxId: 9320) != 30) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalPass : TriggerState {
            internal StateNormalPass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9320}, sound: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 0);
                context.SetMesh(triggerIds: new []{532}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{9320}, sound: "DDStop_Stage_GamblePass_01");
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 0);
                context.SetUserValue(triggerId: 3, key: "GamblePass", value: 32);
                context.SetMesh(triggerIds: new []{532}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.WriteLog(logName: "dancedancestop", triggerId: 9320, @event: "char_event", arg4: 4, arg5: "gamble");
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{9320}, sound: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 0);
                context.SetUserValue(triggerId: 3, key: "JackpotPass", value: 32);
                context.SetMesh(triggerIds: new []{532}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.WriteLog(logName: "dancedancestop", triggerId: 9320, @event: "char_event", arg4: 4, arg5: "jackpot");
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{9320}, sound: "DDStop_Stage_Fail_01");
                context.SetMesh(triggerIds: new []{532}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{5320}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 4);
            }

            public override TriggerState? Execute() {
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
                context.SetAchievement(triggerId: 9320, type: "trigger", code: "ddstop_gamble");
                context.MiniGameGiveExp(boxId: 9320, expRate: 0.1f, isOutSide: false);
                context.SetUserValue(key: "Box32Check", value: 10);
            }

            public override TriggerState? Execute() {
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
                context.SetAchievement(triggerId: 9320, type: "trigger", code: "ddstop_gamble");
                context.MiniGameGiveExp(boxId: 9320, expRate: 0.3f, isOutSide: false);
                context.SetUserValue(key: "Box32Check", value: 10);
            }

            public override TriggerState? Execute() {
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
                context.SetUserValue(key: "Box32Check", value: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
