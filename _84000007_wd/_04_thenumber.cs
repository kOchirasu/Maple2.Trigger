using System;

namespace Maple2.Trigger._84000007_wd {
    public static class _04_thenumber {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BannerCheckIn", value: 1)) {
                    context.State = new StateBannerCheckIn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBannerCheckIn : TriggerState {
            internal StateBannerCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9001, arg2: 70, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 70);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 69, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 69);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 68, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 68);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 67, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 67);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 66, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 66);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 65, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 65);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 64, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 64);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 63, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 63);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 62, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 62);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 61, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 61);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 60, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 60);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 59, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 59);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 58, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 58);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 57, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 57);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 56, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 56);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 55, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 55);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 54, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 54);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 53, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 53);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 52, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 52);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 51, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 51);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 50, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 50);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 49, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 49);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 48, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 48);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 47, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 47);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 46, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 46);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 45, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 45);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 44, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 44);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 43, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 43);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 42, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 42);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 41, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 41);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 40, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 40);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 39, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 39);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 38, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 38);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 37, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 37);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 36, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 36);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 35, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 35);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 34, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 34);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 33, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 33);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 32, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 32);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 31, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 31);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 30, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 30);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 29, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 29);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 28, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 28);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 27, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 27);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 26, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 26);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 25, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 25);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 24, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 24);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 23, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 23);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 22, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 22);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 21, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 21);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 20, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 20);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 19, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 19);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 18, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 18);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 17, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 17);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 16, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 16);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 15, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 15);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 14, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 14);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 13, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 13);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 12, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 12);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 11, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 11);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 10, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 10);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 9, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 09);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 8, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 08);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 7, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 07);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 6, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 06);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 5, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 05);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 4, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 04);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 3, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 03);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 2, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 02);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 1, arg3: "Equal")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 01);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }

                if (!context.UserDetected(arg1: "9001")) {
                    context.SetUserValue(triggerID: 5, key: "BannerNumber", value: 00);
                    context.SetUserValue(triggerID: 5, key: "SetBanner", value: 1);
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "BannerCheckIn", value: 0);
                context.SetUserValue(key: "BannerNumber", value: 100);
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