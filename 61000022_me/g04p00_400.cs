namespace Maple2.Trigger._61000022_me {
    public static class _g04p00_400 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{110, 111, 112, 113, 114, 115, 120, 121, 122, 123, 124, 125, 130, 131, 132, 133, 134, 135, 140, 141, 142, 143, 144, 145, 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225, 230, 231, 232, 233, 234, 235, 240, 241, 242, 243, 244, 245, 310, 311, 312, 313, 314, 315, 320, 321, 322, 323, 324, 325, 330, 331, 332, 333, 334, 335, 340, 341, 342, 343, 344, 345, 410, 411, 412, 413, 414, 415, 420, 421, 422, 423, 424, 425, 430, 431, 432, 433, 434, 435, 440, 441, 442, 443, 444, 445}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P01Set") == 1) {
                    return new StateNumberOnP01(context);
                }

                if (context.GetUserValue(key: "G04P02Set") == 1) {
                    return new StateNumberOnP02(context);
                }

                if (context.GetUserValue(key: "G04P03Set") == 1) {
                    return new StateNumberOnP03(context);
                }

                if (context.GetUserValue(key: "G04P04Set") == 1) {
                    return new StateNumberOnP04(context);
                }

                if (context.GetUserValue(key: "G04P05Set") == 1) {
                    return new StateNumberOnP05(context);
                }

                if (context.GetUserValue(key: "G04P06Set") == 1) {
                    return new StateNumberOnP06(context);
                }

                if (context.GetUserValue(key: "G04P07Set") == 1) {
                    return new StateNumberOnP07(context);
                }

                if (context.GetUserValue(key: "G04P08Set") == 1) {
                    return new StateNumberOnP08(context);
                }

                if (context.GetUserValue(key: "G04P09Set") == 1) {
                    return new StateNumberOnP09(context);
                }

                if (context.GetUserValue(key: "G04P10Set") == 1) {
                    return new StateNumberOnP10(context);
                }

                if (context.GetUserValue(key: "G04P11Set") == 1) {
                    return new StateNumberOnP11(context);
                }

                if (context.GetUserValue(key: "G04P12Set") == 1) {
                    return new StateNumberOnP12(context);
                }

                if (context.GetUserValue(key: "G04P13Set") == 1) {
                    return new StateNumberOnP13(context);
                }

                if (context.GetUserValue(key: "G04P14Set") == 1) {
                    return new StateNumberOnP14(context);
                }

                if (context.GetUserValue(key: "G04P15Set") == 1) {
                    return new StateNumberOnP15(context);
                }

                if (context.GetUserValue(key: "G04P16Set") == 1) {
                    return new StateNumberOnP16(context);
                }

                if (context.GetUserValue(key: "G04P17Set") == 1) {
                    return new StateNumberOnP17(context);
                }

                if (context.GetUserValue(key: "G04P18Set") == 1) {
                    return new StateNumberOnP18(context);
                }

                if (context.GetUserValue(key: "G04P19Set") == 1) {
                    return new StateNumberOnP19(context);
                }

                if (context.GetUserValue(key: "G04P20Set") == 1) {
                    return new StateNumberOnP20(context);
                }

                if (context.GetUserValue(key: "G04P21Set") == 1) {
                    return new StateNumberOnP21(context);
                }

                if (context.GetUserValue(key: "G04P22Set") == 1) {
                    return new StateNumberOnP22(context);
                }

                if (context.GetUserValue(key: "G04P23Set") == 1) {
                    return new StateNumberOnP23(context);
                }

                if (context.GetUserValue(key: "G04P24Set") == 1) {
                    return new StateNumberOnP24(context);
                }

                if (context.GetUserValue(key: "G04P25Set") == 1) {
                    return new StateNumberOnP25(context);
                }

                if (context.GetUserValue(key: "G04P26Set") == 1) {
                    return new StateNumberOnP26(context);
                }

                if (context.GetUserValue(key: "G04P27Set") == 1) {
                    return new StateNumberOnP27(context);
                }

                if (context.GetUserValue(key: "G04P28Set") == 1) {
                    return new StateNumberOnP28(context);
                }

                if (context.GetUserValue(key: "G04P29Set") == 1) {
                    return new StateNumberOnP29(context);
                }

                if (context.GetUserValue(key: "G04P30Set") == 1) {
                    return new StateNumberOnP30(context);
                }

                if (context.GetUserValue(key: "G04P31Set") == 1) {
                    return new StateNumberOnP31(context);
                }

                if (context.GetUserValue(key: "G04P32Set") == 1) {
                    return new StateNumberOnP32(context);
                }

                if (context.GetUserValue(key: "G04P33Set") == 1) {
                    return new StateNumberOnP33(context);
                }

                if (context.GetUserValue(key: "G04P34Set") == 1) {
                    return new StateNumberOnP34(context);
                }

                if (context.GetUserValue(key: "G04P35Set") == 1) {
                    return new StateNumberOnP35(context);
                }

                if (context.GetUserValue(key: "G04P36Set") == 1) {
                    return new StateNumberOnP36(context);
                }

                if (context.GetUserValue(key: "G04P37Set") == 1) {
                    return new StateNumberOnP37(context);
                }

                if (context.GetUserValue(key: "G04P38Set") == 1) {
                    return new StateNumberOnP38(context);
                }

                if (context.GetUserValue(key: "G04P39Set") == 1) {
                    return new StateNumberOnP39(context);
                }

                if (context.GetUserValue(key: "G04P40Set") == 1) {
                    return new StateNumberOnP40(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
            }
        }

        private class StateNumberOnP01 : TriggerState {
            internal StateNumberOnP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{115}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{445}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P01TimeLimit") == 1) {
                    return new StateCheckP01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP01 : TriggerState {
            internal StateCheckP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP01(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP01 : TriggerState {
            internal StateNumberOffP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{115}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{445}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP01(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP01 : TriggerState {
            internal StateResetP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P01End", value: 1);
                context.SetUserValue(key: "G04P01Set", value: 0);
                context.SetUserValue(key: "G04P01TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP02 : TriggerState {
            internal StateNumberOnP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P02TimeLimit") == 1) {
                    return new StateCheckP02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP02 : TriggerState {
            internal StateCheckP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP02(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP02 : TriggerState {
            internal StateNumberOffP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP02(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP02 : TriggerState {
            internal StateResetP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P02End", value: 1);
                context.SetUserValue(key: "G04P02Set", value: 0);
                context.SetUserValue(key: "G04P02TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP03 : TriggerState {
            internal StateNumberOnP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P03TimeLimit") == 1) {
                    return new StateCheckP03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP03 : TriggerState {
            internal StateCheckP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP03(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP03 : TriggerState {
            internal StateNumberOffP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP03(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP03 : TriggerState {
            internal StateResetP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P03End", value: 1);
                context.SetUserValue(key: "G04P03Set", value: 0);
                context.SetUserValue(key: "G04P03TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP04 : TriggerState {
            internal StateNumberOnP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P04TimeLimit") == 1) {
                    return new StateCheckP04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP04 : TriggerState {
            internal StateCheckP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP04(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP04 : TriggerState {
            internal StateNumberOffP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP04(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP04 : TriggerState {
            internal StateResetP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P04End", value: 1);
                context.SetUserValue(key: "G04P04Set", value: 0);
                context.SetUserValue(key: "G04P04TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP05 : TriggerState {
            internal StateNumberOnP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{111}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P05TimeLimit") == 1) {
                    return new StateCheckP05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP05 : TriggerState {
            internal StateCheckP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP05(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP05 : TriggerState {
            internal StateNumberOffP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{111}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP05(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP05 : TriggerState {
            internal StateResetP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P05End", value: 1);
                context.SetUserValue(key: "G04P05Set", value: 0);
                context.SetUserValue(key: "G04P05TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP06 : TriggerState {
            internal StateNumberOnP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{220}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{330}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{445}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 0);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 0);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P06TimeLimit") == 1) {
                    return new StateCheckP06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP06 : TriggerState {
            internal StateCheckP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 0);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 0);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP06(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP06 : TriggerState {
            internal StateNumberOffP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{220}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{330}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{445}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP06(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP06 : TriggerState {
            internal StateResetP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P06End", value: 1);
                context.SetUserValue(key: "G04P06Set", value: 0);
                context.SetUserValue(key: "G04P06TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP07 : TriggerState {
            internal StateNumberOnP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{111}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P07TimeLimit") == 1) {
                    return new StateCheckP07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP07 : TriggerState {
            internal StateCheckP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP07(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP07 : TriggerState {
            internal StateNumberOffP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{111}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP07(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP07 : TriggerState {
            internal StateResetP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P07End", value: 1);
                context.SetUserValue(key: "G04P07Set", value: 0);
                context.SetUserValue(key: "G04P07TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP08 : TriggerState {
            internal StateNumberOnP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{120}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{430}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P08TimeLimit") == 1) {
                    return new StateCheckP08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP08 : TriggerState {
            internal StateCheckP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP08(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP08 : TriggerState {
            internal StateNumberOffP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{430}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP08(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP08 : TriggerState {
            internal StateResetP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P08End", value: 1);
                context.SetUserValue(key: "G04P08Set", value: 0);
                context.SetUserValue(key: "G04P08TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP09 : TriggerState {
            internal StateNumberOnP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{115}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{130}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{220}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{320}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{410}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{445}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 0);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 0);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P09TimeLimit") == 1) {
                    return new StateCheckP09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP09 : TriggerState {
            internal StateCheckP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 0);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 0);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP09(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP09 : TriggerState {
            internal StateNumberOffP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{115}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{130}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{220}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{320}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{410}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{445}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP09(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP09 : TriggerState {
            internal StateResetP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P09End", value: 1);
                context.SetUserValue(key: "G04P09Set", value: 0);
                context.SetUserValue(key: "G04P09TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP10 : TriggerState {
            internal StateNumberOnP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{110}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{230}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{340}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{430}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 0);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P10TimeLimit") == 1) {
                    return new StateCheckP10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP10 : TriggerState {
            internal StateCheckP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 0);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP10(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP10 : TriggerState {
            internal StateNumberOffP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{110}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{230}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{340}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{430}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP10(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP10 : TriggerState {
            internal StateResetP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P10End", value: 1);
                context.SetUserValue(key: "G04P10Set", value: 0);
                context.SetUserValue(key: "G04P10TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP11 : TriggerState {
            internal StateNumberOnP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{120}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P11TimeLimit") == 1) {
                    return new StateCheckP11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP11 : TriggerState {
            internal StateCheckP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP11(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP11 : TriggerState {
            internal StateNumberOffP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP11(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP11 : TriggerState {
            internal StateResetP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P11End", value: 1);
                context.SetUserValue(key: "G04P11Set", value: 0);
                context.SetUserValue(key: "G04P11TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP12 : TriggerState {
            internal StateNumberOnP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P12TimeLimit") == 1) {
                    return new StateCheckP12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP12 : TriggerState {
            internal StateCheckP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP12(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP12 : TriggerState {
            internal StateNumberOffP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP12(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP12 : TriggerState {
            internal StateResetP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P12End", value: 1);
                context.SetUserValue(key: "G04P12Set", value: 0);
                context.SetUserValue(key: "G04P12TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP13 : TriggerState {
            internal StateNumberOnP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P13TimeLimit") == 1) {
                    return new StateCheckP13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP13 : TriggerState {
            internal StateCheckP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP13(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP13 : TriggerState {
            internal StateNumberOffP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP13(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP13 : TriggerState {
            internal StateResetP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P13End", value: 1);
                context.SetUserValue(key: "G04P13Set", value: 0);
                context.SetUserValue(key: "G04P13TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP14 : TriggerState {
            internal StateNumberOnP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{310}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P14TimeLimit") == 1) {
                    return new StateCheckP14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP14 : TriggerState {
            internal StateCheckP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP14(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP14 : TriggerState {
            internal StateNumberOffP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{310}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP14(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP14 : TriggerState {
            internal StateResetP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P14End", value: 1);
                context.SetUserValue(key: "G04P14Set", value: 0);
                context.SetUserValue(key: "G04P14TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP15 : TriggerState {
            internal StateNumberOnP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{140}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{330}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 0);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P15TimeLimit") == 1) {
                    return new StateCheckP15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP15 : TriggerState {
            internal StateCheckP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 0);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP15(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP15 : TriggerState {
            internal StateNumberOffP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{140}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{330}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP15(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP15 : TriggerState {
            internal StateResetP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P15End", value: 1);
                context.SetUserValue(key: "G04P15Set", value: 0);
                context.SetUserValue(key: "G04P15TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP16 : TriggerState {
            internal StateNumberOnP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{130}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P16TimeLimit") == 1) {
                    return new StateCheckP16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP16 : TriggerState {
            internal StateCheckP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP16(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP16 : TriggerState {
            internal StateNumberOffP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{130}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP16(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP16 : TriggerState {
            internal StateResetP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P16End", value: 1);
                context.SetUserValue(key: "G04P16Set", value: 0);
                context.SetUserValue(key: "G04P16TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP17 : TriggerState {
            internal StateNumberOnP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{110}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{430}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P17TimeLimit") == 1) {
                    return new StateCheckP17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP17 : TriggerState {
            internal StateCheckP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP17(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP17 : TriggerState {
            internal StateNumberOffP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{110}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{430}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP17(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP17 : TriggerState {
            internal StateResetP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P17End", value: 1);
                context.SetUserValue(key: "G04P17Set", value: 0);
                context.SetUserValue(key: "G04P17TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP18 : TriggerState {
            internal StateNumberOnP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P18TimeLimit") == 1) {
                    return new StateCheckP18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP18 : TriggerState {
            internal StateCheckP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP18(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP18 : TriggerState {
            internal StateNumberOffP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP18(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP18 : TriggerState {
            internal StateResetP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P18End", value: 1);
                context.SetUserValue(key: "G04P18Set", value: 0);
                context.SetUserValue(key: "G04P18TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP19 : TriggerState {
            internal StateNumberOnP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{310}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P19TimeLimit") == 1) {
                    return new StateCheckP19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP19 : TriggerState {
            internal StateCheckP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP19(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP19 : TriggerState {
            internal StateNumberOffP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{240}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{310}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP19(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP19 : TriggerState {
            internal StateResetP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P19End", value: 1);
                context.SetUserValue(key: "G04P19Set", value: 0);
                context.SetUserValue(key: "G04P19TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP20 : TriggerState {
            internal StateNumberOnP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P20TimeLimit") == 1) {
                    return new StateCheckP20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP20 : TriggerState {
            internal StateCheckP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP20(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP20 : TriggerState {
            internal StateNumberOffP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP20(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP20 : TriggerState {
            internal StateResetP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P20End", value: 1);
                context.SetUserValue(key: "G04P20Set", value: 0);
                context.SetUserValue(key: "G04P20TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP21 : TriggerState {
            internal StateNumberOnP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P21TimeLimit") == 1) {
                    return new StateCheckP21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP21 : TriggerState {
            internal StateCheckP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP21(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP21 : TriggerState {
            internal StateNumberOffP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP21(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP21 : TriggerState {
            internal StateResetP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P21End", value: 1);
                context.SetUserValue(key: "G04P21Set", value: 0);
                context.SetUserValue(key: "G04P21TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP22 : TriggerState {
            internal StateNumberOnP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P22TimeLimit") == 1) {
                    return new StateCheckP22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP22 : TriggerState {
            internal StateCheckP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP22(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP22 : TriggerState {
            internal StateNumberOffP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP22(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP22 : TriggerState {
            internal StateResetP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P22End", value: 1);
                context.SetUserValue(key: "G04P22Set", value: 0);
                context.SetUserValue(key: "G04P22TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP23 : TriggerState {
            internal StateNumberOnP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P23TimeLimit") == 1) {
                    return new StateCheckP23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP23 : TriggerState {
            internal StateCheckP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP23(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP23 : TriggerState {
            internal StateNumberOffP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP23(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP23 : TriggerState {
            internal StateResetP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P23End", value: 1);
                context.SetUserValue(key: "G04P23Set", value: 0);
                context.SetUserValue(key: "G04P23TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP24 : TriggerState {
            internal StateNumberOnP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{130}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P24TimeLimit") == 1) {
                    return new StateCheckP24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP24 : TriggerState {
            internal StateCheckP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP24(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP24 : TriggerState {
            internal StateNumberOffP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{130}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP24(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP24 : TriggerState {
            internal StateResetP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P24End", value: 1);
                context.SetUserValue(key: "G04P24Set", value: 0);
                context.SetUserValue(key: "G04P24TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP25 : TriggerState {
            internal StateNumberOnP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P25TimeLimit") == 1) {
                    return new StateCheckP25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP25 : TriggerState {
            internal StateCheckP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP25(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP25 : TriggerState {
            internal StateNumberOffP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP25(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP25 : TriggerState {
            internal StateResetP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P25End", value: 1);
                context.SetUserValue(key: "G04P25Set", value: 0);
                context.SetUserValue(key: "G04P25TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP26 : TriggerState {
            internal StateNumberOnP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{110}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{140}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{410}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{435}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P26TimeLimit") == 1) {
                    return new StateCheckP26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP26 : TriggerState {
            internal StateCheckP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP26(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP26 : TriggerState {
            internal StateNumberOffP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{110}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{140}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{410}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{435}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP26(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP26 : TriggerState {
            internal StateResetP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P26End", value: 1);
                context.SetUserValue(key: "G04P26Set", value: 0);
                context.SetUserValue(key: "G04P26TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP27 : TriggerState {
            internal StateNumberOnP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{111}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P27TimeLimit") == 1) {
                    return new StateCheckP27(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP27 : TriggerState {
            internal StateCheckP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP27(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP27 : TriggerState {
            internal StateNumberOffP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{111}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP27(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP27 : TriggerState {
            internal StateResetP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P27End", value: 1);
                context.SetUserValue(key: "G04P27Set", value: 0);
                context.SetUserValue(key: "G04P27TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP28 : TriggerState {
            internal StateNumberOnP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{111}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{210}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{320}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{420}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 0);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P28TimeLimit") == 1) {
                    return new StateCheckP28(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP28 : TriggerState {
            internal StateCheckP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 0);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP28(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP28 : TriggerState {
            internal StateNumberOffP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{111}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{210}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{320}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{420}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP28(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP28 : TriggerState {
            internal StateResetP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P28End", value: 1);
                context.SetUserValue(key: "G04P28Set", value: 0);
                context.SetUserValue(key: "G04P28TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP29 : TriggerState {
            internal StateNumberOnP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P29TimeLimit") == 1) {
                    return new StateCheckP29(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP29 : TriggerState {
            internal StateCheckP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP29(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP29 : TriggerState {
            internal StateNumberOffP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP29(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP29 : TriggerState {
            internal StateResetP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P29End", value: 1);
                context.SetUserValue(key: "G04P29Set", value: 0);
                context.SetUserValue(key: "G04P29TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP30 : TriggerState {
            internal StateNumberOnP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{230}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{340}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 0);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P30TimeLimit") == 1) {
                    return new StateCheckP30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP30 : TriggerState {
            internal StateCheckP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 0);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP30(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP30 : TriggerState {
            internal StateNumberOffP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{230}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{340}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP30(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP30 : TriggerState {
            internal StateResetP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P30End", value: 1);
                context.SetUserValue(key: "G04P30Set", value: 0);
                context.SetUserValue(key: "G04P30TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP31 : TriggerState {
            internal StateNumberOnP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P31TimeLimit") == 1) {
                    return new StateCheckP31(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP31 : TriggerState {
            internal StateCheckP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP31(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP31 : TriggerState {
            internal StateNumberOffP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP31(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP31 : TriggerState {
            internal StateResetP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P31End", value: 1);
                context.SetUserValue(key: "G04P31Set", value: 0);
                context.SetUserValue(key: "G04P31TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP32 : TriggerState {
            internal StateNumberOnP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P32TimeLimit") == 1) {
                    return new StateCheckP32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP32 : TriggerState {
            internal StateCheckP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP32(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP32 : TriggerState {
            internal StateNumberOffP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP32(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP32 : TriggerState {
            internal StateResetP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P32End", value: 1);
                context.SetUserValue(key: "G04P32Set", value: 0);
                context.SetUserValue(key: "G04P32TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP33 : TriggerState {
            internal StateNumberOnP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{410}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P33TimeLimit") == 1) {
                    return new StateCheckP33(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP33 : TriggerState {
            internal StateCheckP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP33(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP33 : TriggerState {
            internal StateNumberOffP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{410}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP33(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP33 : TriggerState {
            internal StateResetP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P33End", value: 1);
                context.SetUserValue(key: "G04P33Set", value: 0);
                context.SetUserValue(key: "G04P33TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP34 : TriggerState {
            internal StateNumberOnP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{320}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{435}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 0);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P34TimeLimit") == 1) {
                    return new StateCheckP34(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP34 : TriggerState {
            internal StateCheckP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 0);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP34(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP34 : TriggerState {
            internal StateNumberOffP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{320}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{435}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP34(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP34 : TriggerState {
            internal StateResetP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P34End", value: 1);
                context.SetUserValue(key: "G04P34Set", value: 0);
                context.SetUserValue(key: "G04P34TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP35 : TriggerState {
            internal StateNumberOnP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P35TimeLimit") == 1) {
                    return new StateCheckP35(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP35 : TriggerState {
            internal StateCheckP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP35(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP35 : TriggerState {
            internal StateNumberOffP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP35(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP35 : TriggerState {
            internal StateResetP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P35End", value: 1);
                context.SetUserValue(key: "G04P35Set", value: 0);
                context.SetUserValue(key: "G04P35TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP36 : TriggerState {
            internal StateNumberOnP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P36TimeLimit") == 1) {
                    return new StateCheckP36(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP36 : TriggerState {
            internal StateCheckP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP36(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP36 : TriggerState {
            internal StateNumberOffP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{421}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP36(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP36 : TriggerState {
            internal StateResetP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P36End", value: 1);
                context.SetUserValue(key: "G04P36Set", value: 0);
                context.SetUserValue(key: "G04P36TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP37 : TriggerState {
            internal StateNumberOnP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P37TimeLimit") == 1) {
                    return new StateCheckP37(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP37 : TriggerState {
            internal StateCheckP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP37(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP37 : TriggerState {
            internal StateNumberOffP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP37(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP37 : TriggerState {
            internal StateResetP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P37End", value: 1);
                context.SetUserValue(key: "G04P37Set", value: 0);
                context.SetUserValue(key: "G04P37TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP38 : TriggerState {
            internal StateNumberOnP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P38TimeLimit") == 1) {
                    return new StateCheckP38(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP38 : TriggerState {
            internal StateCheckP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP38(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP38 : TriggerState {
            internal StateNumberOffP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{321}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP38(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP38 : TriggerState {
            internal StateResetP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P38End", value: 1);
                context.SetUserValue(key: "G04P38Set", value: 0);
                context.SetUserValue(key: "G04P38TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP39 : TriggerState {
            internal StateNumberOnP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P39TimeLimit") == 1) {
                    return new StateCheckP39(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP39 : TriggerState {
            internal StateCheckP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP39(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP39 : TriggerState {
            internal StateNumberOffP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{241}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP39(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP39 : TriggerState {
            internal StateResetP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P39End", value: 1);
                context.SetUserValue(key: "G04P39Set", value: 0);
                context.SetUserValue(key: "G04P39TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP40 : TriggerState {
            internal StateNumberOnP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new []{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{220}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 0);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P40TimeLimit") == 1) {
                    return new StateCheckP40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP40 : TriggerState {
            internal StateCheckP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 0);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP40(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP40 : TriggerState {
            internal StateNumberOffP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{220}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{331}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP40(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP40 : TriggerState {
            internal StateResetP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G04P40End", value: 1);
                context.SetUserValue(key: "G04P40Set", value: 0);
                context.SetUserValue(key: "G04P40TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
