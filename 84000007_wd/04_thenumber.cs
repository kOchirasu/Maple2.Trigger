namespace Maple2.Trigger._84000007_wd {
    public static class _04_thenumber {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BannerCheckIn") == 1) {
                    return new StateBannerCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBannerCheckIn : TriggerState {
            internal StateBannerCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) == 70) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 70);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 69) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 69);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 68) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 68);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 67) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 67);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 66) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 66);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 65) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 65);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 64) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 64);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 63) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 63);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 62) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 62);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 61) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 61);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 60) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 60);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 59) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 59);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 58) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 58);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 57) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 57);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 56) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 56);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 55) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 55);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 54) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 54);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 53) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 53);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 52) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 52);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 51) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 51);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 50) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 50);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 49) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 49);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 48) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 48);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 47) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 47);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 46) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 46);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 45) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 45);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 44) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 44);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 43) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 43);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 42) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 42);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 41) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 41);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 40) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 40);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 39) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 39);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 38) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 38);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 37) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 37);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 36) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 36);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 35) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 35);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 34) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 34);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 33) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 33);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 32) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 32);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 31) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 31);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 30) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 30);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 29) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 29);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 28) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 28);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 27) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 27);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 26) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 26);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 25) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 25);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 24) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 24);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 23) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 23);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 22) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 22);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 21) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 21);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 20) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 20);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 19) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 19);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 18) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 18);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 17) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 17);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 16) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 16);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 15) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 15);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 14) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 14);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 13) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 13);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 12) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 12);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 11) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 11);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 10) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 10);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 9) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 09);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 8) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 08);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 7) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 07);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 6) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 06);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 5) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 05);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 4) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 04);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 3) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 03);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 2) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 02);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (context.GetUserCount(boxId: 9001) == 1) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 01);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                if (!context.UserDetected(arg1: new[] {9001})) {
                    context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 00);
                    context.SetUserValue(triggerId: 5, key: "SetBanner", value: 1);
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "BannerCheckIn", value: 0);
                context.SetUserValue(key: "BannerNumber", value: 100);
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